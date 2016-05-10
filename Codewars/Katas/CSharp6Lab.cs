using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasLab
{
    public class CSharp6Lab
    {
        public class  Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Adress Adress { get; set; }
        }

    }

    public class Adress
    {
        public string Street { get; set; }
    }
}
