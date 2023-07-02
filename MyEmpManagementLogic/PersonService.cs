using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmpManagementLogic
{
    public class PersonService
    {
        //fields
        private static Person[] arrPerson = new Person[5];

        //props

        //methods
        public bool AddPerson(Person pObj)
        {
            for (int i = 0; i < arrPerson.Length; i++)
            {
                if (arrPerson[i] == null)
                {
                    arrPerson[i] = pObj;
                    return true; //added
                }
            }
            return false; //not added
        }

        public string DisplayAll()
        {
            string allDetails = "";
            for (int i = 0; i < arrPerson.Length; i++)
            {
                if(arrPerson[i] != null)
                {
                    allDetails += arrPerson[i].ToString() + "\n";
                }
            }
            return allDetails;
        }
    }
}
