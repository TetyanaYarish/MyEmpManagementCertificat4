using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmpManagementLogic
{
    public class Person
    {
        //field
        private string name;

        //prop
        public string Name { get => name; set => name = value; }

        //cons
        public Person(string name)
        {
            this.name = name;
        }

        //methods
        public override string ToString()
        {
            return name;
        }
    }
}
