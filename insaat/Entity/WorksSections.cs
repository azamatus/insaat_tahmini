using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class WorksSections
    {
        private int id;
        private string sectionName;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string SectionName
        {
            get { return sectionName; }
            set { sectionName = value; }
        }
    }
}
