using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DataHandler
{
    public class Patients : ICollection
    {
        public String ColletionName;
        public ArrayList patientsArray = new ArrayList();

        public Models.Patient this[int index] {
            get { return (Models.Patient)patientsArray[index]; }
        }
        public int Count { get { return patientsArray.Count; } }

        public object SyncRoot { get { return this; } }

        public bool IsSynchronized { get { return false; } }

        public void CopyTo(Array array, int index)
        {
            patientsArray.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return patientsArray.GetEnumerator();
        }
        public void Add(Models.Patient p) {
            patientsArray.Add(p);
        }
    }
}