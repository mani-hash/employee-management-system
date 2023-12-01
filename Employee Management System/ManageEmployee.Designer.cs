namespace Employee_Management_System
{
    partial class ManageEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployee));
            logoutLink = new LinkLabel();
            mainLabel = new Label();
            registrationForm = new GroupBox();
            clearBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            registerBtn = new Button();
            departmentDetailsForm = new GroupBox();
            employeeType = new TextBox();
            designation = new TextBox();
            departmentName = new TextBox();
            employeeTypeLabel = new Label();
            designationLabel = new Label();
            departmentNameLabel = new Label();
            contactDetailForm = new GroupBox();
            homePhone = new TextBox();
            homePhoneLabel = new Label();
            mobilePhone = new TextBox();
            email = new TextBox();
            address = new TextBox();
            mobilePhoneLabel = new Label();
            emailLabel = new Label();
            addressLabel = new Label();
            basicDetailsForm = new GroupBox();
            female = new RadioButton();
            male = new RadioButton();
            dateOfBirth = new DateTimePicker();
            lastName = new TextBox();
            firstName = new TextBox();
            genderLabel = new Label();
            dateOfBirthLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            empNo = new ComboBox();
            empNoLabel = new Label();
            registrationForm.SuspendLayout();
            departmentDetailsForm.SuspendLayout();
            contactDetailForm.SuspendLayout();
            basicDetailsForm.SuspendLayout();
            SuspendLayout();
            // 
            // logoutLink
            // 
            logoutLink.Anchor = AnchorStyles.None;
            logoutLink.AutoSize = true;
            logoutLink.Location = new Point(53, 24);
            logoutLink.Name = "logoutLink";
            logoutLink.Size = new Size(45, 15);
            logoutLink.TabIndex = 0;
            logoutLink.TabStop = true;
            logoutLink.Text = "Logout";
            // 
            // mainLabel
            // 
            mainLabel.Anchor = AnchorStyles.None;
            mainLabel.Font = new Font("Segoe UI", 24F);
            mainLabel.Location = new Point(0, 24);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(570, 57);
            mainLabel.TabIndex = 1;
            mainLabel.Text = "Manage Employee";
            mainLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // registrationForm
            // 
            registrationForm.Anchor = AnchorStyles.None;
            registrationForm.AutoSize = true;
            registrationForm.Controls.Add(clearBtn);
            registrationForm.Controls.Add(deleteBtn);
            registrationForm.Controls.Add(updateBtn);
            registrationForm.Controls.Add(registerBtn);
            registrationForm.Controls.Add(departmentDetailsForm);
            registrationForm.Controls.Add(contactDetailForm);
            registrationForm.Controls.Add(basicDetailsForm);
            registrationForm.Controls.Add(empNo);
            registrationForm.Controls.Add(empNoLabel);
            registrationForm.Font = new Font("Segoe UI", 11F);
            registrationForm.Location = new Point(3, 84);
            registrationForm.Name = "registrationForm";
            registrationForm.Size = new Size(567, 746);
            registrationForm.TabIndex = 2;
            registrationForm.TabStop = false;
            registrationForm.Text = "Employee Registration";
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 10F);
            clearBtn.Location = new Point(369, 694);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 26);
            clearBtn.TabIndex = 8;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 10F);
            deleteBtn.Location = new Point(452, 694);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 26);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 10F);
            updateBtn.Location = new Point(109, 694);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 26);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // registerBtn
            // 
            registerBtn.Font = new Font("Segoe UI", 10F);
            registerBtn.Location = new Point(25, 694);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(75, 26);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            // 
            // departmentDetailsForm
            // 
            departmentDetailsForm.Controls.Add(employeeType);
            departmentDetailsForm.Controls.Add(designation);
            departmentDetailsForm.Controls.Add(departmentName);
            departmentDetailsForm.Controls.Add(employeeTypeLabel);
            departmentDetailsForm.Controls.Add(designationLabel);
            departmentDetailsForm.Controls.Add(departmentNameLabel);
            departmentDetailsForm.Location = new Point(24, 506);
            departmentDetailsForm.Name = "departmentDetailsForm";
            departmentDetailsForm.Size = new Size(503, 173);
            departmentDetailsForm.TabIndex = 4;
            departmentDetailsForm.TabStop = false;
            departmentDetailsForm.Text = "Department Details";
            // 
            // employeeType
            // 
            employeeType.Location = new Point(147, 127);
            employeeType.Name = "employeeType";
            employeeType.Size = new Size(158, 27);
            employeeType.TabIndex = 6;
            // 
            // designation
            // 
            designation.Location = new Point(147, 85);
            designation.Name = "designation";
            designation.Size = new Size(158, 27);
            designation.TabIndex = 5;
            // 
            // departmentName
            // 
            departmentName.Location = new Point(147, 45);
            departmentName.Name = "departmentName";
            departmentName.Size = new Size(333, 27);
            departmentName.TabIndex = 4;
            // 
            // employeeTypeLabel
            // 
            employeeTypeLabel.AutoSize = true;
            employeeTypeLabel.Location = new Point(29, 130);
            employeeTypeLabel.Name = "employeeTypeLabel";
            employeeTypeLabel.Size = new Size(110, 20);
            employeeTypeLabel.TabIndex = 2;
            employeeTypeLabel.Text = "Employee Type";
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Location = new Point(50, 85);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new Size(89, 20);
            designationLabel.TabIndex = 1;
            designationLabel.Text = "Designation";
            // 
            // departmentNameLabel
            // 
            departmentNameLabel.AutoSize = true;
            departmentNameLabel.Location = new Point(6, 48);
            departmentNameLabel.Name = "departmentNameLabel";
            departmentNameLabel.Size = new Size(133, 20);
            departmentNameLabel.TabIndex = 0;
            departmentNameLabel.Text = "Department Name";
            // 
            // contactDetailForm
            // 
            contactDetailForm.Controls.Add(homePhone);
            contactDetailForm.Controls.Add(homePhoneLabel);
            contactDetailForm.Controls.Add(mobilePhone);
            contactDetailForm.Controls.Add(email);
            contactDetailForm.Controls.Add(address);
            contactDetailForm.Controls.Add(mobilePhoneLabel);
            contactDetailForm.Controls.Add(emailLabel);
            contactDetailForm.Controls.Add(addressLabel);
            contactDetailForm.Location = new Point(24, 307);
            contactDetailForm.Name = "contactDetailForm";
            contactDetailForm.Size = new Size(503, 182);
            contactDetailForm.TabIndex = 3;
            contactDetailForm.TabStop = false;
            contactDetailForm.Text = "Contact Details";
            // 
            // homePhone
            // 
            homePhone.Location = new Point(344, 133);
            homePhone.Name = "homePhone";
            homePhone.Size = new Size(109, 27);
            homePhone.TabIndex = 8;
            // 
            // homePhoneLabel
            // 
            homePhoneLabel.AutoSize = true;
            homePhoneLabel.Location = new Point(246, 134);
            homePhoneLabel.Name = "homePhoneLabel";
            homePhoneLabel.Size = new Size(96, 20);
            homePhoneLabel.TabIndex = 7;
            homePhoneLabel.Text = "Home phone";
            // 
            // mobilePhone
            // 
            mobilePhone.Location = new Point(120, 130);
            mobilePhone.Name = "mobilePhone";
            mobilePhone.Size = new Size(120, 27);
            mobilePhone.TabIndex = 6;
            // 
            // email
            // 
            email.Location = new Point(120, 94);
            email.Name = "email";
            email.Size = new Size(333, 27);
            email.TabIndex = 5;
            // 
            // address
            // 
            address.Location = new Point(120, 45);
            address.Multiline = true;
            address.Name = "address";
            address.Size = new Size(333, 40);
            address.TabIndex = 4;
            // 
            // mobilePhoneLabel
            // 
            mobilePhoneLabel.AutoSize = true;
            mobilePhoneLabel.Location = new Point(12, 134);
            mobilePhoneLabel.Name = "mobilePhoneLabel";
            mobilePhoneLabel.Size = new Size(102, 20);
            mobilePhoneLabel.TabIndex = 2;
            mobilePhoneLabel.Text = "Mobile phone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(68, 94);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(52, 48);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(62, 20);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address";
            // 
            // basicDetailsForm
            // 
            basicDetailsForm.Controls.Add(female);
            basicDetailsForm.Controls.Add(male);
            basicDetailsForm.Controls.Add(dateOfBirth);
            basicDetailsForm.Controls.Add(lastName);
            basicDetailsForm.Controls.Add(firstName);
            basicDetailsForm.Controls.Add(genderLabel);
            basicDetailsForm.Controls.Add(dateOfBirthLabel);
            basicDetailsForm.Controls.Add(lastNameLabel);
            basicDetailsForm.Controls.Add(firstNameLabel);
            basicDetailsForm.Location = new Point(24, 86);
            basicDetailsForm.Name = "basicDetailsForm";
            basicDetailsForm.Size = new Size(503, 211);
            basicDetailsForm.TabIndex = 2;
            basicDetailsForm.TabStop = false;
            basicDetailsForm.Text = "Basic Details";
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(186, 147);
            female.Name = "female";
            female.Size = new Size(75, 24);
            female.TabIndex = 8;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(120, 147);
            male.Name = "male";
            male.Size = new Size(60, 24);
            male.TabIndex = 7;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Location = new Point(120, 112);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(200, 27);
            dateOfBirth.TabIndex = 6;
            // 
            // lastName
            // 
            lastName.Location = new Point(120, 79);
            lastName.Name = "lastName";
            lastName.Size = new Size(333, 27);
            lastName.TabIndex = 5;
            // 
            // firstName
            // 
            firstName.Location = new Point(120, 45);
            firstName.Name = "firstName";
            firstName.Size = new Size(333, 27);
            firstName.TabIndex = 4;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(57, 149);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(57, 20);
            genderLabel.TabIndex = 3;
            genderLabel.Text = "Gender";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new Point(20, 117);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(94, 20);
            dateOfBirthLabel.TabIndex = 2;
            dateOfBirthLabel.Text = "Date of Birth";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(35, 82);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(34, 48);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // empNo
            // 
            empNo.FormattingEnabled = true;
            empNo.Location = new Point(136, 44);
            empNo.Name = "empNo";
            empNo.Size = new Size(121, 28);
            empNo.TabIndex = 1;
            // 
            // empNoLabel
            // 
            empNoLabel.AutoSize = true;
            empNoLabel.Location = new Point(32, 45);
            empNoLabel.Name = "empNoLabel";
            empNoLabel.Size = new Size(99, 20);
            empNoLabel.TabIndex = 0;
            empNoLabel.Text = "Employee No";
            // 
            // ManageEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 881);
            Controls.Add(registrationForm);
            Controls.Add(logoutLink);
            Controls.Add(mainLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManageEmployee";
            Text = "ABC Cooperation";
            registrationForm.ResumeLayout(false);
            registrationForm.PerformLayout();
            departmentDetailsForm.ResumeLayout(false);
            departmentDetailsForm.PerformLayout();
            contactDetailForm.ResumeLayout(false);
            contactDetailForm.PerformLayout();
            basicDetailsForm.ResumeLayout(false);
            basicDetailsForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel logoutLink;
        private Label mainLabel;
        private GroupBox registrationForm;
        private Button clearBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button registerBtn;
        private GroupBox departmentDetailsForm;
        private TextBox employeeType;
        private TextBox designation;
        private TextBox departmentName;
        private Label employeeTypeLabel;
        private Label designationLabel;
        private Label departmentNameLabel;
        private GroupBox contactDetailForm;
        private TextBox homePhone;
        private Label homePhoneLabel;
        private TextBox mobilePhone;
        private TextBox email;
        private TextBox address;
        private Label mobilePhoneLabel;
        private Label emailLabel;
        private Label addressLabel;
        private GroupBox basicDetailsForm;
        private RadioButton female;
        private RadioButton male;
        private DateTimePicker dateOfBirth;
        private TextBox lastName;
        private TextBox firstName;
        private Label genderLabel;
        private Label dateOfBirthLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private ComboBox empNo;
        private Label empNoLabel;
    }
}