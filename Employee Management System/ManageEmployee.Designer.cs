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
            LogoutLink = new LinkLabel();
            MainLabel = new Label();
            RegistrationForm = new GroupBox();
            ClearBtn = new Button();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            RegisterBtn = new Button();
            DepDetailsForm = new GroupBox();
            EmpType = new TextBox();
            Designation = new TextBox();
            DepName = new TextBox();
            EmpTypeLabel = new Label();
            DesignationLabel = new Label();
            DepNameLabel = new Label();
            ContactDetailForm = new GroupBox();
            HomePhone = new TextBox();
            HomePhoneLabel = new Label();
            MobilePhone = new TextBox();
            Email = new TextBox();
            Address = new TextBox();
            MobilePhoneLabel = new Label();
            EmailLabel = new Label();
            AddressLabel = new Label();
            BasicDetailsForm = new GroupBox();
            Female = new RadioButton();
            Male = new RadioButton();
            DateOfBirth = new DateTimePicker();
            LastName = new TextBox();
            FirstName = new TextBox();
            GenderLabel = new Label();
            DateOfBirthLabel = new Label();
            LastNameLabel = new Label();
            FirstNameLabel = new Label();
            EmpNo = new ComboBox();
            EmpNoLabel = new Label();
            RegistrationForm.SuspendLayout();
            DepDetailsForm.SuspendLayout();
            ContactDetailForm.SuspendLayout();
            BasicDetailsForm.SuspendLayout();
            SuspendLayout();
            // 
            // LogoutLink
            // 
            LogoutLink.Anchor = AnchorStyles.None;
            LogoutLink.AutoSize = true;
            LogoutLink.Location = new Point(53, 24);
            LogoutLink.Name = "LogoutLink";
            LogoutLink.Size = new Size(45, 15);
            LogoutLink.TabIndex = 0;
            LogoutLink.TabStop = true;
            LogoutLink.Text = "Logout";
            // 
            // MainLabel
            // 
            MainLabel.Anchor = AnchorStyles.None;
            MainLabel.Font = new Font("Segoe UI", 24F);
            MainLabel.Location = new Point(0, 24);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(570, 57);
            MainLabel.TabIndex = 1;
            MainLabel.Text = "Manage Employee";
            MainLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // RegistrationForm
            // 
            RegistrationForm.Anchor = AnchorStyles.None;
            RegistrationForm.AutoSize = true;
            RegistrationForm.Controls.Add(ClearBtn);
            RegistrationForm.Controls.Add(DeleteBtn);
            RegistrationForm.Controls.Add(UpdateBtn);
            RegistrationForm.Controls.Add(RegisterBtn);
            RegistrationForm.Controls.Add(DepDetailsForm);
            RegistrationForm.Controls.Add(ContactDetailForm);
            RegistrationForm.Controls.Add(BasicDetailsForm);
            RegistrationForm.Controls.Add(EmpNo);
            RegistrationForm.Controls.Add(EmpNoLabel);
            RegistrationForm.Font = new Font("Segoe UI", 11F);
            RegistrationForm.Location = new Point(3, 84);
            RegistrationForm.Name = "RegistrationForm";
            RegistrationForm.Size = new Size(567, 746);
            RegistrationForm.TabIndex = 2;
            RegistrationForm.TabStop = false;
            RegistrationForm.Text = "Employee Registration";
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 10F);
            ClearBtn.Location = new Point(369, 694);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(75, 26);
            ClearBtn.TabIndex = 8;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Font = new Font("Segoe UI", 10F);
            DeleteBtn.Location = new Point(452, 694);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 26);
            DeleteBtn.TabIndex = 7;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new Font("Segoe UI", 10F);
            UpdateBtn.Location = new Point(109, 694);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(75, 26);
            UpdateBtn.TabIndex = 6;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Font = new Font("Segoe UI", 10F);
            RegisterBtn.Location = new Point(25, 694);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(75, 26);
            RegisterBtn.TabIndex = 5;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            // 
            // DepDetailsForm
            // 
            DepDetailsForm.Controls.Add(EmpType);
            DepDetailsForm.Controls.Add(Designation);
            DepDetailsForm.Controls.Add(DepName);
            DepDetailsForm.Controls.Add(EmpTypeLabel);
            DepDetailsForm.Controls.Add(DesignationLabel);
            DepDetailsForm.Controls.Add(DepNameLabel);
            DepDetailsForm.Location = new Point(24, 506);
            DepDetailsForm.Name = "DepDetailsForm";
            DepDetailsForm.Size = new Size(503, 173);
            DepDetailsForm.TabIndex = 4;
            DepDetailsForm.TabStop = false;
            DepDetailsForm.Text = "Department Details";
            // 
            // EmpType
            // 
            EmpType.Location = new Point(147, 127);
            EmpType.Name = "EmpType";
            EmpType.Size = new Size(158, 27);
            EmpType.TabIndex = 6;
            // 
            // Designation
            // 
            Designation.Location = new Point(147, 85);
            Designation.Name = "Designation";
            Designation.Size = new Size(158, 27);
            Designation.TabIndex = 5;
            // 
            // DepName
            // 
            DepName.Location = new Point(147, 45);
            DepName.Name = "DepName";
            DepName.Size = new Size(333, 27);
            DepName.TabIndex = 4;
            // 
            // EmpTypeLabel
            // 
            EmpTypeLabel.AutoSize = true;
            EmpTypeLabel.Location = new Point(29, 130);
            EmpTypeLabel.Name = "EmpTypeLabel";
            EmpTypeLabel.Size = new Size(110, 20);
            EmpTypeLabel.TabIndex = 2;
            EmpTypeLabel.Text = "Employee Type";
            // 
            // DesignationLabel
            // 
            DesignationLabel.AutoSize = true;
            DesignationLabel.Location = new Point(50, 85);
            DesignationLabel.Name = "DesignationLabel";
            DesignationLabel.Size = new Size(89, 20);
            DesignationLabel.TabIndex = 1;
            DesignationLabel.Text = "Designation";
            // 
            // DepNameLabel
            // 
            DepNameLabel.AutoSize = true;
            DepNameLabel.Location = new Point(6, 48);
            DepNameLabel.Name = "DepNameLabel";
            DepNameLabel.Size = new Size(133, 20);
            DepNameLabel.TabIndex = 0;
            DepNameLabel.Text = "Department Name";
            // 
            // ContactDetailForm
            // 
            ContactDetailForm.Controls.Add(HomePhone);
            ContactDetailForm.Controls.Add(HomePhoneLabel);
            ContactDetailForm.Controls.Add(MobilePhone);
            ContactDetailForm.Controls.Add(Email);
            ContactDetailForm.Controls.Add(Address);
            ContactDetailForm.Controls.Add(MobilePhoneLabel);
            ContactDetailForm.Controls.Add(EmailLabel);
            ContactDetailForm.Controls.Add(AddressLabel);
            ContactDetailForm.Location = new Point(24, 307);
            ContactDetailForm.Name = "ContactDetailForm";
            ContactDetailForm.Size = new Size(503, 182);
            ContactDetailForm.TabIndex = 3;
            ContactDetailForm.TabStop = false;
            ContactDetailForm.Text = "Contact Details";
            // 
            // HomePhone
            // 
            HomePhone.Location = new Point(344, 134);
            HomePhone.Name = "HomePhone";
            HomePhone.Size = new Size(109, 27);
            HomePhone.TabIndex = 8;
            // 
            // HomePhoneLabel
            // 
            HomePhoneLabel.AutoSize = true;
            HomePhoneLabel.Location = new Point(246, 134);
            HomePhoneLabel.Name = "HomePhoneLabel";
            HomePhoneLabel.Size = new Size(96, 20);
            HomePhoneLabel.TabIndex = 7;
            HomePhoneLabel.Text = "Home phone";
            // 
            // MobilePhone
            // 
            MobilePhone.Location = new Point(120, 134);
            MobilePhone.Name = "MobilePhone";
            MobilePhone.Size = new Size(120, 27);
            MobilePhone.TabIndex = 6;
            // 
            // Email
            // 
            Email.Location = new Point(120, 94);
            Email.Name = "Email";
            Email.Size = new Size(333, 27);
            Email.TabIndex = 5;
            // 
            // Address
            // 
            Address.Location = new Point(120, 45);
            Address.Multiline = true;
            Address.Name = "Address";
            Address.Size = new Size(333, 40);
            Address.TabIndex = 4;
            // 
            // MobilePhoneLabel
            // 
            MobilePhoneLabel.AutoSize = true;
            MobilePhoneLabel.Location = new Point(12, 134);
            MobilePhoneLabel.Name = "MobilePhoneLabel";
            MobilePhoneLabel.Size = new Size(102, 20);
            MobilePhoneLabel.TabIndex = 2;
            MobilePhoneLabel.Text = "Mobile phone";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(68, 94);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(46, 20);
            EmailLabel.TabIndex = 1;
            EmailLabel.Text = "Email";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(52, 48);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(62, 20);
            AddressLabel.TabIndex = 0;
            AddressLabel.Text = "Address";
            // 
            // BasicDetailsForm
            // 
            BasicDetailsForm.Controls.Add(Female);
            BasicDetailsForm.Controls.Add(Male);
            BasicDetailsForm.Controls.Add(DateOfBirth);
            BasicDetailsForm.Controls.Add(LastName);
            BasicDetailsForm.Controls.Add(FirstName);
            BasicDetailsForm.Controls.Add(GenderLabel);
            BasicDetailsForm.Controls.Add(DateOfBirthLabel);
            BasicDetailsForm.Controls.Add(LastNameLabel);
            BasicDetailsForm.Controls.Add(FirstNameLabel);
            BasicDetailsForm.Location = new Point(24, 86);
            BasicDetailsForm.Name = "BasicDetailsForm";
            BasicDetailsForm.Size = new Size(503, 211);
            BasicDetailsForm.TabIndex = 2;
            BasicDetailsForm.TabStop = false;
            BasicDetailsForm.Text = "Basic Details";
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(186, 147);
            Female.Name = "Female";
            Female.Size = new Size(75, 24);
            Female.TabIndex = 8;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Location = new Point(120, 147);
            Male.Name = "Male";
            Male.Size = new Size(60, 24);
            Male.TabIndex = 7;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = true;
            // 
            // DateOfBirth
            // 
            DateOfBirth.Location = new Point(120, 112);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(200, 27);
            DateOfBirth.TabIndex = 6;
            // 
            // LastName
            // 
            LastName.Location = new Point(120, 79);
            LastName.Name = "LastName";
            LastName.Size = new Size(333, 27);
            LastName.TabIndex = 5;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(120, 45);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(333, 27);
            FirstName.TabIndex = 4;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(57, 149);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(57, 20);
            GenderLabel.TabIndex = 3;
            GenderLabel.Text = "Gender";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new Point(20, 117);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(94, 20);
            DateOfBirthLabel.TabIndex = 2;
            DateOfBirthLabel.Text = "Date of Birth";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(35, 82);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(79, 20);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(34, 48);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(80, 20);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name";
            // 
            // EmpNo
            // 
            EmpNo.FormattingEnabled = true;
            EmpNo.Location = new Point(136, 44);
            EmpNo.Name = "EmpNo";
            EmpNo.Size = new Size(121, 28);
            EmpNo.TabIndex = 1;
            // 
            // EmpNoLabel
            // 
            EmpNoLabel.AutoSize = true;
            EmpNoLabel.Location = new Point(32, 45);
            EmpNoLabel.Name = "EmpNoLabel";
            EmpNoLabel.Size = new Size(99, 20);
            EmpNoLabel.TabIndex = 0;
            EmpNoLabel.Text = "Employee No";
            // 
            // ManageEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 881);
            Controls.Add(RegistrationForm);
            Controls.Add(LogoutLink);
            Controls.Add(MainLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManageEmployee";
            Text = "ABC Cooperation";
            RegistrationForm.ResumeLayout(false);
            RegistrationForm.PerformLayout();
            DepDetailsForm.ResumeLayout(false);
            DepDetailsForm.PerformLayout();
            ContactDetailForm.ResumeLayout(false);
            ContactDetailForm.PerformLayout();
            BasicDetailsForm.ResumeLayout(false);
            BasicDetailsForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel LogoutLink;
        private Label MainLabel;
        private GroupBox RegistrationForm;
        private Button ClearBtn;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button RegisterBtn;
        private GroupBox DepDetailsForm;
        private TextBox EmpType;
        private TextBox Designation;
        private TextBox DepName;
        private Label EmpTypeLabel;
        private Label DesignationLabel;
        private Label DepNameLabel;
        private GroupBox ContactDetailForm;
        private TextBox HomePhone;
        private Label HomePhoneLabel;
        private TextBox MobilePhone;
        private TextBox Email;
        private TextBox Address;
        private Label MobilePhoneLabel;
        private Label EmailLabel;
        private Label AddressLabel;
        private GroupBox BasicDetailsForm;
        private RadioButton Female;
        private RadioButton Male;
        private DateTimePicker DateOfBirth;
        private TextBox LastName;
        private TextBox FirstName;
        private Label GenderLabel;
        private Label DateOfBirthLabel;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private ComboBox EmpNo;
        private Label EmpNoLabel;
    }
}