using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Collection_Car
    {
        private string name;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public Collection_Car (string name)
        {
            this.name = name;
        }
    }
}
