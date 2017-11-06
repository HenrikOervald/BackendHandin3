using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DataHandler
{
    public class Dentists: ICollection
    {
        public String ColletionName;
        public ArrayList dentistsArray = new ArrayList();

        public Models.Dentist this[int index]
        {
            get { return (Models.Dentist)dentistsArray[index]; }
        }
        public int Count { get { return dentistsArray.Count; } }

        public object SyncRoot { get { return this; } }

        public bool IsSynchronized { get { return false; } }

        public void CopyTo(Array array, int index)
        {
            dentistsArray.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return dentistsArray.GetEnumerator();
        }
        public void Add(Models.Dentist p)
        {
            dentistsArray.Add(p);
        }
    }
}