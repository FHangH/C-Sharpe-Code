using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Collection_Person
    {
        private string name;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public Collection_Person (string name)
        {
            this.name = name;
        }
    }
}
