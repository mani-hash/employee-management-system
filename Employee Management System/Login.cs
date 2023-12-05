using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class Login : Form
    {
        private string passwordVisible;
        private string passwordHidden;

        public Login()
        {
            InitializeComponent();
            this.passwordVisible = "Show";
            this.passwordHidden = "Hide";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            PasswordView.Text = this.passwordVisible;
        }

        private void PasswordView_Click(object sender, EventArgs e)
        {
            if (PasswordView.Text == this.passwordVisible)
            {
                PasswordView.Text = this.passwordHidden;
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordView.Text = this.passwordVisible;
                Password.UseSystemPasswordChar = true;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Username.Clear();
            Password.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            string exitMsg = "Are you sure, Do you really want to exit?";
            string exitCaption = "Exit";

            DialogResult result = MessageBox.Show(exitMsg, exitCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DisplayRegistrationForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private static void InvalidLogin()
        {
            string errorMsg = "Invalid Login Credentials! Please check your username/password and try again..";
            string errorCaption = "Invalid Login";
            MessageBox.Show(errorMsg, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string? connectionString = Database.GetConnectionString();
            string query = $@"SELECT * FROM Login WHERE username = @UsernameValue AND password = @PasswordValue";

            if (connectionString == null)
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand(query, con);

                    sqlCommand.Parameters.Add(new SqlParameter("@UsernameValue", Username.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("@PasswordValue", Password.Text));

                    SqlDataReader row = sqlCommand.ExecuteReader();

                    if (row.HasRows)
                    {
                        this.DisplayRegistrationForm();
                    }
                    else
                    {
                        InvalidLogin();
                    }

                }
                catch (Exception ex)
                {
                    string errorMsg = "An error occured";
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
