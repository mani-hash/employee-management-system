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
            mainImage = new PictureBox();
            loginForm = new GroupBox();
            loginBtn = new Button();
            clearBtn = new Button();
            password = new TextBox();
            username = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)mainImage).BeginInit();
            loginForm.SuspendLayout();
            SuspendLayout();
            // 
            // mainImage
            // 
            mainImage.Anchor = AnchorStyles.None;
            mainImage.Image = Properties.Resources.emp_management;
            mainImage.Location = new Point(12, 18);
            mainImage.Name = "mainImage";
            mainImage.Size = new Size(547, 215);
            mainImage.SizeMode = PictureBoxSizeMode.Zoom;
            mainImage.TabIndex = 0;
            mainImage.TabStop = false;
            // 
            // loginForm
            // 
            loginForm.Anchor = AnchorStyles.None;
            loginForm.Controls.Add(loginBtn);
            loginForm.Controls.Add(clearBtn);
            loginForm.Controls.Add(password);
            loginForm.Controls.Add(username);
            loginForm.Controls.Add(passwordLabel);
            loginForm.Controls.Add(usernameLabel);
            loginForm.Font = new Font("Segoe UI", 11F);
            loginForm.Location = new Point(12, 247);
            loginForm.Name = "loginForm";
            loginForm.Size = new Size(547, 271);
            loginForm.TabIndex = 1;
            loginForm.TabStop = false;
            loginForm.Text = "Login";
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Right;
            loginBtn.Location = new Point(379, 209);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(80, 34);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Left;
            clearBtn.Location = new Point(72, 209);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(80, 34);
            clearBtn.TabIndex = 4;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password.Location = new Point(174, 128);
            password.Name = "password";
            password.Size = new Size(285, 27);
            password.TabIndex = 3;
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            username.Location = new Point(174, 70);
            username.Name = "username";
            username.Size = new Size(285, 27);
            username.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(65, 128);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(61, 70);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.None;
            exitBtn.Location = new Point(13, 539);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(80, 34);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(571, 586);
            Controls.Add(exitBtn);
            Controls.Add(loginForm);
            Controls.Add(mainImage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "ABC Cooperation";
            ((System.ComponentModel.ISupportInitialize)mainImage).EndInit();
            loginForm.ResumeLayout(false);
            loginForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox mainImage;
        private GroupBox loginForm;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button clearBtn;
        private TextBox password;
        private TextBox username;
        private Button loginBtn;
        private Button exitBtn;
    }
}
