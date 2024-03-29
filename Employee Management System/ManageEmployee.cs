﻿using System;
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
    public partial class ManageEmployee : MainForm
    {
        private readonly string defaultEmpNo;

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
            DateOfBirth.Format = DateTimePickerFormat.Custom;
            DateOfBirth.CustomFormat = "yyyy/MM/dd";
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            this.FillEmpNo();
        }

        //Fill the combo box with EmpNo details
        private void FillEmpNo()
        {
            string query = $@"SELECT * FROM {Database.employee}";

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

        //Get the data of all fillable boxes in the form
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

        //Clear all textboxes in form
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
            DateOfBirth.Text = DateTime.Today.ToString(); //reset date time
            ClearTextBoxes(this.Controls);

        }

        //Function when combo box choice is changed by user
        private void EmpNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateButtonVisibility();

            if (EmpNo.Text == this.defaultEmpNo)
            {
                ClearBtn.PerformClick();
                return;
            }

            string parameterName = "@empNo";

            string query = $@"SELECT * FROM {Database.employee} WHERE empNo = {parameterName}";

            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand(query, con);

                    sqlCommand.Parameters.Add(new SqlParameter(parameterName, EmpNo.Text));

                    SqlDataReader row = sqlCommand.ExecuteReader();

                    this.FillFormData(row);

                }
                catch (Exception ex)
                {
                    ShowConnectError();
                }
            }
        }

        //set update, register and delete button states
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

        //Completely fill form with data from database
        private void FillFormData(SqlDataReader row)
        {
            while (row.Read())
            {
                int count = 1;

                List<(string, string)> empData = this.GetEmpData();

                foreach ((string key, _) in empData)
                {
                    //special case for gender radio button
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

                    //Change first letter of fieldName to capital
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

        //Create insert query for form insert
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

            string query = $@"INSERT INTO {Database.employee}({fieldName}) VALUES ({parameterName})";

            SqlCommand sqlCommand = new SqlCommand(query, con);

            foreach ((string key, string data) in empData)
            {
                sqlCommand.Parameters.Add(new SqlParameter("@" + key, data));
            }

            return sqlCommand;
        }

        //Create update query for form update
        private SqlCommand ConstructUpdateQuery(SqlConnection con)
        {
            string updateEntries = "";
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

                updateEntries += key + "= @" + key + separator;
            }

            string parameterName = "@empNo";

            string query = $@"UPDATE {Database.employee} SET {updateEntries} WHERE empNo = {parameterName}";

            SqlCommand sqlCommand = new SqlCommand(query, con);

            foreach ((string key, string data) in empData)
            {
                sqlCommand.Parameters.Add(new SqlParameter("@" + key, data));
            }

            sqlCommand.Parameters.Add(new SqlParameter(parameterName, EmpNo.Text));

            return sqlCommand;
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
            else
            {
                Application.Exit();
            }
        }



        private void ExitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowExitApp();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string deleteMsg = "Are you sure, Do you want to delete this record";
            string deleteCaption = "Delete";

            DialogResult result = MessageBox.Show(deleteMsg, deleteCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.DeleteRecord();
            }
        }

        //Method to delete row from database
        private void DeleteRecord()
        {
            string parameterName = "@empNo";
            string query = $@"DELETE FROM {Database.employee} WHERE empNo = {parameterName}";
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    sqlCommand.Parameters.Add(new SqlParameter("@empNo", EmpNo.Text));
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Record deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EmpNo.Items.Clear();
                    this.FillEmpNo();
                }
                catch (Exception ex)
                {
                    ShowConnectError();
                }
            }
        }
    }
}
