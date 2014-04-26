using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insaat
{
    class Customers
    {
        private int id;
        private string name;
        private string nesne;
        private string contractor;
        private string typeOfWork;
        private string brigade;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Nesne
        {
            get { return nesne; }
            set { nesne = value; }
        }

        public string Contractor
        {
            get { return contractor; }
            set { contractor = value; }
        }

        public string TypeOfWork
        {
            get { return typeOfWork; }
            set { typeOfWork = value; }
        }

        public string Brigade
        {
            get { return brigade; }
            set { brigade = value; }
        }
    }
}
