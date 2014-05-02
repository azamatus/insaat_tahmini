using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Materials
    {
        private int id;
        private string materialName;
        private string unit;
        private double price;
        private string section;
        private int _sectionId;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string MaterialName
        {
            get { return materialName; }
            set { materialName = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Section
        {
            get { return section; }
            set { section = value; }
        }

        public int SectionId
        {
            get { return _sectionId; }
            set { _sectionId = value; }
        }
    }
}
