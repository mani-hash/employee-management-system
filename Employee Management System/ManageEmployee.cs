using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Employee_Management_System
{
    public partial class ManageEmployee : Form
    {
        private string defaultEmpNo;

        private string? connectionString;

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
            this.defaultEmpNo = "New Register";
            this.connectionString = Database.GetConnectionString();

            DateOfBirth.Format = DateTimePickerFormat.Custom;
            DateOfBirth.CustomFormat = "yyyy/MM/dd";
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            this.FillEmpNo();
        }

        private void FillEmpNo()
        {

            string query = "SELECT * FROM Employee";

            if (this.connectionString == null)
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand(query, con);

                    SqlDataReader row = sqlCommand.ExecuteReader();

                    EmpNo.Items.Add(this.defaultEmpNo);

                    if (row == null)
                    {
                        return;
                    }

                    while (row.Read())
                    {
                        EmpNo.Items.Add(row[0].ToString());
                    }

                    EmpNo.Text = this.defaultEmpNo;

                }
                catch (Exception ex)
                {
                    ShowConnectError();
                }
            }
        }

        private List<(string, string)> GetEmpData()
        {
            List<(string, string)> empData = new List<(string, string)>()
            {
                ("firstName", FirstName.Text),
                ("lastName", LastName.Text),
                ("dateOfBirth", DateOfBirth.Text),
                ("gender", this.TxtGender),
                ("address", Address.Text),
                ("email", Email.Text),
                ("mobilePhone", MobilePhone.Text),
                ("homePhone", HomePhone.Text),
                ("departmentName", DepartmentName.Text),
                ("designation", Designation.Text),
                ("employeeType", EmployeeType.Text)
            };

            return empData;


        }

        private static void ClearTextBoxes(Control.ControlCollection ctrlCollection)
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
            EmpNo.Text = this.defaultEmpNo;
            DateOfBirth.Text = DateTime.Today.ToString();
            ClearTextBoxes(this.Controls);

        }

        private void EmpNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateButtonVisibility();

            if (EmpNo.Text == this.defaultEmpNo)
            {
                ClearBtn.PerformClick();
                return;
            }

            string query = $@"SELECT * FROM Employee WHERE empNo = @empNo";

            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand(query, con);

                    sqlCommand.Parameters.Add(new SqlParameter("@empNo", EmpNo.Text));

                    SqlDataReader row = sqlCommand.ExecuteReader();

                    this.FillFormData(row);

                }
                catch (Exception ex)
                {
                    ShowConnectError();
                }
            }
        }

        private void UpdateButtonVisibility()
        {
            if (EmpNo.Text == this.defaultEmpNo)
            {
                RegisterBtn.Enabled = true;
                UpdateBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
            else
            {
                RegisterBtn.Enabled = false;
                UpdateBtn.Enabled = true;
                DeleteBtn.Enabled = true;
            }
        }

        private void FillFormData(SqlDataReader row)
        {
            while (row.Read())
            {
                int count = 1;

                List<(string, string)> empData = this.GetEmpData();

                foreach ((string key, _) in empData)
                {
                    if (key == "gender")
                    {
                        if (row[count].ToString() == "male")
                        {
                            Male.Checked = true;
                        }
                        else
                        {
                            Female.Checked = true;
                        }

                        count++;
                        continue;

                    }
                    string fieldName = $"{key[0].ToString().ToUpper()}{key.Substring(1)}";

                    Control? control = this.Controls.Find(fieldName, true)[0];
                    if (control != null)
                    {
                        control.Text = row[count].ToString();

                    }
                    count++;
                }

            }
        }

        private SqlCommand ConstructInsertQuery(SqlConnection con)
        {
            string fieldName = "";
            string parameterName = "";

            List<(string, string)> empData = this.GetEmpData();

            List<string> keyNames = empData.Select(item => item.Item1).ToList();

            int list_length = keyNames.Count;

            string separator = ",";

            foreach (string key in keyNames)
            {
                if (keyNames[list_length - 1] == key)
                {
                    separator = "";
                }

                fieldName += key + separator;
                parameterName += "@" + key + separator;
            }

            string query = $@"INSERT INTO Employee({fieldName}) VALUES ({parameterName})";

            SqlCommand sqlCommand = new SqlCommand(query, con);

            foreach ((string key, string data) in empData)
            {
                sqlCommand.Parameters.Add(new SqlParameter("@" + key, data));
            }

            return sqlCommand;
        }

        private SqlCommand ConstructUpdateQuery(SqlConnection con)
        {
            string updateEntries = "";
            List <(string, string)> empData = this.GetEmpData();

            List<string> keyNames = empData.Select(item => item.Item1).ToList();

            int list_length = keyNames.Count;

            string separator = ",";

            foreach (string key in keyNames)
            {
                if (keyNames[list_length - 1] == key)
                {
                    separator = "";
                }

                updateEntries += key + "= @" + key + separator;
            }

            string query = $@"UPDATE Employee SET {updateEntries} WHERE empNo = @empNo";

            SqlCommand sqlCommand = new SqlCommand(query, con);

            foreach ((string key, string data) in empData)
            {
                sqlCommand.Parameters.Add(new SqlParameter("@" + key, data));
            }

            sqlCommand.Parameters.Add(new SqlParameter("@empNo", EmpNo.Text));

            return sqlCommand;
        }

        private static void ShowConnectError()
        {
            string errorMsg = "An error occured!";
            MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {


            if (this.connectionString == null)
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = this.ConstructInsertQuery(con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Record added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EmpNo.Items.Clear();
                    this.FillEmpNo();

                }
                catch (Exception ex)
                {
                    ShowConnectError();
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (this.connectionString == null)
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = this.ConstructUpdateQuery(con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Record updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ShowConnectError();
                }
            }

        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearBtn.PerformClick();
            this.Hide();
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        

        private void ExitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
