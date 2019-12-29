namespace ProMTA_WindowsForms
{
    partial class RegistrationForm
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
            this.Sign = new System.Windows.Forms.Label();
            this.user_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.date_birth = new System.Windows.Forms.Label();
            this.DateBirth = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.Create_account = new System.Windows.Forms.Button();
            this.Passwordconfirm = new System.Windows.Forms.Label();
            this.passwordCon = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password = new System.Windows.Forms.Label();
            this.Passwordd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Up = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Emailadd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.maleCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.femaleCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sign
            // 
            this.Sign.AutoSize = true;
            this.Sign.BackColor = System.Drawing.Color.Transparent;
            this.Sign.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign.ForeColor = System.Drawing.Color.OrangeRed;
            this.Sign.Location = new System.Drawing.Point(343, 34);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(112, 47);
            this.Sign.TabIndex = 200;
            this.Sign.Text = " Sign";
            // 
            // user_name
            // 
            this.user_name.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.user_name.BackColor = System.Drawing.Color.Gainsboro;
            this.user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_name.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.user_name.HintText = "";
            this.user_name.isPassword = false;
            this.user_name.LineFocusedColor = System.Drawing.Color.Transparent;
            this.user_name.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.user_name.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.user_name.LineThickness = 3;
            this.user_name.Location = new System.Drawing.Point(50, 169);
            this.user_name.Margin = new System.Windows.Forms.Padding(4);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(378, 49);
            this.user_name.TabIndex = 1;
            this.user_name.Text = "Full Name";
            this.user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.OrangeRed;
            this.UserName.Location = new System.Drawing.Point(45, 151);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(141, 27);
            this.UserName.TabIndex = 100;
            this.UserName.Text = "User Name:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.Transparent;
            this.Gender.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.ForeColor = System.Drawing.Color.OrangeRed;
            this.Gender.Location = new System.Drawing.Point(45, 256);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(105, 27);
            this.Gender.TabIndex = 700;
            this.Gender.Text = "Gender:";
            // 
            // date_birth
            // 
            this.date_birth.AutoSize = true;
            this.date_birth.BackColor = System.Drawing.Color.Transparent;
            this.date_birth.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_birth.ForeColor = System.Drawing.Color.OrangeRed;
            this.date_birth.Location = new System.Drawing.Point(45, 367);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(159, 27);
            this.date_birth.TabIndex = 400;
            this.date_birth.Text = "Date of birth:";
            // 
            // DateBirth
            // 
            this.DateBirth.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.DateBirth.BackColor = System.Drawing.Color.Gainsboro;
            this.DateBirth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DateBirth.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DateBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateBirth.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DateBirth.HintText = "";
            this.DateBirth.isPassword = false;
            this.DateBirth.LineFocusedColor = System.Drawing.Color.Transparent;
            this.DateBirth.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.DateBirth.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.DateBirth.LineThickness = 3;
            this.DateBirth.Location = new System.Drawing.Point(50, 385);
            this.DateBirth.Margin = new System.Windows.Forms.Padding(4);
            this.DateBirth.Name = "DateBirth";
            this.DateBirth.Size = new System.Drawing.Size(378, 49);
            this.DateBirth.TabIndex = 30;
            this.DateBirth.Text = "01/01/1990";
            this.DateBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.Create_account);
            this.panel1.Controls.Add(this.Passwordconfirm);
            this.panel1.Controls.Add(this.passwordCon);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Passwordd);
            this.panel1.Controls.Add(this.Up);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Emailadd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(449, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 563);
            this.panel1.TabIndex = 9;
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Image = global::ProMTA_WindowsForms.Properties.Resources.icons8_xbox_x_30;
            this.exit.Location = new System.Drawing.Point(411, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(37, 38);
            this.exit.TabIndex = 301;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Create_account
            // 
            this.Create_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Create_account.ForeColor = System.Drawing.Color.IndianRed;
            this.Create_account.Location = new System.Drawing.Point(133, 473);
            this.Create_account.Name = "Create_account";
            this.Create_account.Size = new System.Drawing.Size(166, 57);
            this.Create_account.TabIndex = 70;
            this.Create_account.Text = "Create Account";
            this.Create_account.UseVisualStyleBackColor = true;
            this.Create_account.Click += new System.EventHandler(this.Create_account_Click);
            // 
            // Passwordconfirm
            // 
            this.Passwordconfirm.AutoSize = true;
            this.Passwordconfirm.BackColor = System.Drawing.Color.Transparent;
            this.Passwordconfirm.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordconfirm.ForeColor = System.Drawing.Color.Gainsboro;
            this.Passwordconfirm.Location = new System.Drawing.Point(31, 365);
            this.Passwordconfirm.Name = "Passwordconfirm";
            this.Passwordconfirm.Size = new System.Drawing.Size(223, 27);
            this.Passwordconfirm.TabIndex = 97;
            this.Passwordconfirm.Text = "Re-Enter Password:";
            // 
            // passwordCon
            // 
            this.passwordCon.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.passwordCon.BackColor = System.Drawing.Color.OrangeRed;
            this.passwordCon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordCon.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordCon.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.passwordCon.HintText = "";
            this.passwordCon.isPassword = true;
            this.passwordCon.LineFocusedColor = System.Drawing.Color.Transparent;
            this.passwordCon.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.passwordCon.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.passwordCon.LineThickness = 3;
            this.passwordCon.Location = new System.Drawing.Point(36, 385);
            this.passwordCon.Margin = new System.Windows.Forms.Padding(4);
            this.passwordCon.Name = "passwordCon";
            this.passwordCon.Size = new System.Drawing.Size(375, 49);
            this.passwordCon.TabIndex = 60;
            this.passwordCon.Text = "XXXXXXXX";
            this.passwordCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Gainsboro;
            this.Password.Location = new System.Drawing.Point(31, 254);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(124, 27);
            this.Password.TabIndex = 99;
            this.Password.Text = "Password:";
            // 
            // Passwordd
            // 
            this.Passwordd.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Passwordd.BackColor = System.Drawing.Color.OrangeRed;
            this.Passwordd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Passwordd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Passwordd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Passwordd.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Passwordd.HintText = "";
            this.Passwordd.isPassword = false;
            this.Passwordd.LineFocusedColor = System.Drawing.Color.Transparent;
            this.Passwordd.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.Passwordd.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.Passwordd.LineThickness = 3;
            this.Passwordd.Location = new System.Drawing.Point(36, 274);
            this.Passwordd.Margin = new System.Windows.Forms.Padding(4);
            this.Passwordd.Name = "Passwordd";
            this.Passwordd.Size = new System.Drawing.Size(375, 49);
            this.Passwordd.TabIndex = 50;
            this.Passwordd.Text = "XXXXXXXX";
            this.Passwordd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Up
            // 
            this.Up.AutoSize = true;
            this.Up.BackColor = System.Drawing.Color.OrangeRed;
            this.Up.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Up.ForeColor = System.Drawing.Color.Gainsboro;
            this.Up.Location = new System.Drawing.Point(-4, 34);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(72, 47);
            this.Up.TabIndex = 300;
            this.Up.Text = "Up";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Gainsboro;
            this.Email.Location = new System.Drawing.Point(31, 151);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(80, 27);
            this.Email.TabIndex = 98;
            this.Email.Text = "Email:";
            // 
            // Emailadd
            // 
            this.Emailadd.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Emailadd.BackColor = System.Drawing.Color.OrangeRed;
            this.Emailadd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Emailadd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Emailadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Emailadd.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Emailadd.HintText = "";
            this.Emailadd.isPassword = false;
            this.Emailadd.LineFocusedColor = System.Drawing.Color.Transparent;
            this.Emailadd.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.Emailadd.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.Emailadd.LineThickness = 3;
            this.Emailadd.Location = new System.Drawing.Point(36, 171);
            this.Emailadd.Margin = new System.Windows.Forms.Padding(4);
            this.Emailadd.Name = "Emailadd";
            this.Emailadd.Size = new System.Drawing.Size(375, 49);
            this.Emailadd.TabIndex = 40;
            this.Emailadd.Text = "someone@example.com";
            this.Emailadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // maleCheckBox
            // 
            this.maleCheckBox.AutoSize = true;
            this.maleCheckBox.Depth = 0;
            this.maleCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.maleCheckBox.Location = new System.Drawing.Point(163, 274);
            this.maleCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.maleCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.maleCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.maleCheckBox.Name = "maleCheckBox";
            this.maleCheckBox.Ripple = true;
            this.maleCheckBox.Size = new System.Drawing.Size(69, 30);
            this.maleCheckBox.TabIndex = 10;
            this.maleCheckBox.Text = "Male";
            this.maleCheckBox.UseVisualStyleBackColor = true;
            // 
            // femaleCheckBox
            // 
            this.femaleCheckBox.AutoSize = true;
            this.femaleCheckBox.Depth = 0;
            this.femaleCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.femaleCheckBox.Location = new System.Drawing.Point(163, 304);
            this.femaleCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.femaleCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.femaleCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.femaleCheckBox.Name = "femaleCheckBox";
            this.femaleCheckBox.Ripple = true;
            this.femaleCheckBox.Size = new System.Drawing.Size(88, 30);
            this.femaleCheckBox.TabIndex = 20;
            this.femaleCheckBox.Text = "Female";
            this.femaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(909, 563);
            this.Controls.Add(this.femaleCheckBox);
            this.Controls.Add(this.maleCheckBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.date_birth);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.DateBirth);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.user_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.Text = "Registration Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sign;
        private Bunifu.Framework.UI.BunifuMaterialTextbox user_name;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label date_birth;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DateBirth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Emailadd;
        private System.Windows.Forms.Label Up;
        private System.Windows.Forms.Button Create_account;
        private System.Windows.Forms.Label Passwordconfirm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordCon;
        private System.Windows.Forms.Label Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Passwordd;
        private MaterialSkin.Controls.MaterialCheckBox maleCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox femaleCheckBox;
        private System.Windows.Forms.Button exit;
    }
}