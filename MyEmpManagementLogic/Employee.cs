using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmpManagementLogic
{
    public class Employee : Person
    {
        //fields
        private double wage;

        //props
        public double Wage { get => wage; set => wage = value; }

        //cons
        public Employee(string name) : base(name)
        {

        }
        public Employee(string name,double wage) : base(name)
        {
            this.wage = wage;
        }

        //methods
        public override string ToString()
        {
            return base.ToString() + "," + wage;
        }
    }
}
