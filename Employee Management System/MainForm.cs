using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    public class MainForm: Form
    {
        protected readonly string? connectionString;

        public MainForm()
        {
            this.connectionString = Database.GetConnectionString();
        }

        protected static void ShowConnectError()
        {
            string errorMsg = "An error occured!";
            MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected static void ShowExitApp()
        {
            string exitMsg = "Are you sure, Do you really want to exit?";
            string exitCaption = "Exit";

            DialogResult result = MessageBox.Show(exitMsg, exitCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
