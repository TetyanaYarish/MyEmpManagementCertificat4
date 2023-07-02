using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyEmpManagementLogic;//PersonService

namespace MyEmpManagementUI
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            //get all data from the array
            PersonService service = new PersonService();
            string result = service.DisplayAll();

            //display the data on the label
            //if(result == ""){
            //    lblDetails.Text = "No data stored";
            //}
            //else
            //{
            //    lblDetails.Text = result;
            //}

            //MessageBox.Show(result == "" ? "No data stored" : result);
            lblDetails.Text = result == "" ? "No data stored" : result;
        }
    }
}
