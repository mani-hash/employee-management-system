namespace Employee_Management_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            MainImage = new PictureBox();
            LoginForm = new GroupBox();
            PasswordView = new Button();
            LoginBtn = new Button();
            ClearBtn = new Button();
            Password = new TextBox();
            Username = new TextBox();
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            ExitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)MainImage).BeginInit();
            LoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // MainImage
            // 
            MainImage.Anchor = AnchorStyles.None;
            MainImage.Image = Properties.Resources.emp_management;
            MainImage.Location = new Point(12, 18);
            MainImage.Name = "MainImage";
            MainImage.Size = new Size(547, 215);
            MainImage.SizeMode = PictureBoxSizeMode.Zoom;
            MainImage.TabIndex = 0;
            MainImage.TabStop = false;
            // 
            // LoginForm
            // 
            LoginForm.Anchor = AnchorStyles.None;
            LoginForm.Controls.Add(PasswordView);
            LoginForm.Controls.Add(LoginBtn);
            LoginForm.Controls.Add(ClearBtn);
            LoginForm.Controls.Add(Password);
            LoginForm.Controls.Add(Username);
            LoginForm.Controls.Add(PasswordLabel);
            LoginForm.Controls.Add(UsernameLabel);
            LoginForm.Font = new Font("Segoe UI", 11F);
            LoginForm.Location = new Point(12, 247);
            LoginForm.Name = "LoginForm";
            LoginForm.Size = new Size(547, 271);
            LoginForm.TabIndex = 1;
            LoginForm.TabStop = false;
            LoginForm.Text = "Login";
            // 
            // PasswordView
            // 
            PasswordView.Location = new Point(402, 128);
            PasswordView.Name = "PasswordView";
            PasswordView.Size = new Size(57, 27);
            PasswordView.TabIndex = 6;
            PasswordView.UseVisualStyleBackColor = true;
            PasswordView.Click += PasswordView_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.Right;
            LoginBtn.Location = new Point(379, 209);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(80, 34);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Anchor = AnchorStyles.Left;
            ClearBtn.Location = new Point(72, 209);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(80, 34);
            ClearBtn.TabIndex = 4;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Password.Location = new Point(174, 128);
            Password.Name = "Password";
            Password.Size = new Size(228, 27);
            Password.TabIndex = 3;
            Password.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Username.Location = new Point(174, 70);
            Username.Name = "Username";
            Username.Size = new Size(285, 27);
            Username.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(65, 128);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(70, 20);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(61, 70);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(75, 20);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";
            // 
            // ExitBtn
            // 
            ExitBtn.Anchor = AnchorStyles.None;
            ExitBtn.Location = new Point(13, 539);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(80, 34);
            ExitBtn.TabIndex = 6;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(571, 586);
            Controls.Add(ExitBtn);
            Controls.Add(LoginForm);
            Controls.Add(MainImage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "ABC Cooperation";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)MainImage).EndInit();
            LoginForm.ResumeLayout(false);
            LoginForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox MainImage;
        private GroupBox LoginForm;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Button ClearBtn;
        private TextBox Password;
        private TextBox Username;
        private Button LoginBtn;
        private Button ExitBtn;
        private Button PasswordView;
    }
}
