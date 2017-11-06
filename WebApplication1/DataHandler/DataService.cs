using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml;
using System.Collections;
using System.Xml.Serialization;


namespace WebApplication1.DataHandler
{
    public class DataService
    {
        ArrayList patients = new ArrayList();
        public DataService() { }
        string pathPatients = @"E:\Henrik\CPH-BusinessBackendProgramming\WebApplication1\WebApplication1\DataHandler\patients.xml";
        string pathDentists = @"E:\Henrik\CPH-BusinessBackendProgramming\WebApplication1\WebApplication1\DataHandler\dentists.xml";

        public Models.Patient CreatePatient(Models.Patient patient) {
            Patients pat = new Patients();
            pat.patientsArray = LoadAllPatients();
            pat.ColletionName = "Patients";
            pat.Add(patient);
            XmlSerializer serializer = new XmlSerializer(typeof(Patients));
            TextWriter writer = new StreamWriter(pathPatients);
            serializer.Serialize(writer, pat);
            writer.Close();
            return patient;
        }


        public ArrayList LoadAllPatients()
        { 
            Patients patients;
            XmlSerializer serializer = new XmlSerializer(typeof(Patients));
            FileStream stream = new FileStream(pathPatients, FileMode.Open);
            patients = (Patients)serializer.Deserialize(stream);
            stream.Close();

            return patients.patientsArray;
        }

        public Models.Dentist CreateDentist(Models.Dentist dentist)
        {
            Dentists dents = new Dentists();
            dents.dentistsArray = LoadAllDentists();
            dents.ColletionName = "Patients";
            dents.Add(dentist);
            XmlSerializer serializer = new XmlSerializer(typeof(Dentists));
            TextWriter writer = new StreamWriter(pathDentists);
            serializer.Serialize(writer, dents);
            writer.Close();
            return dentist;
        }


        public ArrayList LoadAllDentists()
        {
           Dentists dentists;
            XmlSerializer serializer = new XmlSerializer(typeof(Dentists));
            FileStream stream = new FileStream(pathDentists, FileMode.Open);
            dentists = (Dentists)serializer.Deserialize(stream);
            stream.Close();

            return dentists.dentistsArray;
        }
    }
}