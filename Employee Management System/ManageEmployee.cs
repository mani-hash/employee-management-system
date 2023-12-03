using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class ManageEmployee : Form
    {

        private string TxtGender
        {
            get
            {
                string gender = "male";

                if (Female.Checked)
                {
                    gender = "female";
                }

                return gender;
            }
        }

        public ManageEmployee()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            EmpNo.Text = "";
            DateOfBirth.Text = DateTime.Today.ToString();
            this.ClearTextBoxes(this.Controls);
            
        }
    }
}
