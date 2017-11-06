using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.DataHandler;

namespace WebApplication1
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList patients = new ArrayList();
            ArrayList dentists;
            if (Page.IsPostBack) {
                DataHandler.DataService dataService = new DataService();
                patients = dataService.LoadAllPatients();
                dentists = dataService.LoadAllDentists();
            }

            if (patients.Count > 0) {
            }

           
        }

        public void CreateNewDentist()
        {


        }
    }
}