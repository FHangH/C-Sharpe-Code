using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo.List
{
    class PersonName
    {
        private string name;
        
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public PersonName (string name)
        {
            this.name = name;
        }
    }
}
