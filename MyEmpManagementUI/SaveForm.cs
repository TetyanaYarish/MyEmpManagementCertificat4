using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyEmpManagementLogic; //to call logic methods

namespace MyEmpManagementUI
{
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            //create Emp obj
            Employee emp = new Employee(txtName.Text);
            emp.Wage = int.Parse(txtWage.Text);

            //add to array
            PersonService service = new PersonService();
            bool result = service.AddPerson(emp);

            //confirm
            //ternary op: condition test ? true value : false value
            MessageBox.Show(result?"Added":"Not added");
        }

        private void BtnVolunteer_Click(object sender, EventArgs e)
        {
            //create Volunteer obj
            Volunteer v = new Volunteer(txtName.Text);

            //add to array
            PersonService service = new PersonService();
            bool result = service.AddPerson(v);

            //confirm
            MessageBox.Show(result ? "Added" : "Not added");
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {

        }
    }
}
