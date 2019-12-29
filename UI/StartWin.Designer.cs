namespace ProMTA_WindowsForms
{
    partial class StartWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.Sign_In = new System.Windows.Forms.Label();
            this.user_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Sign_Up = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 55F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(734, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(369, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pro MTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sign_In
            // 
            this.Sign_In.AutoSize = true;
            this.Sign_In.BackColor = System.Drawing.Color.Transparent;
            this.Sign_In.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_In.ForeColor = System.Drawing.Color.DimGray;
            this.Sign_In.Location = new System.Drawing.Point(746, 141);
            this.Sign_In.Name = "Sign_In";
            this.Sign_In.Size = new System.Drawing.Size(133, 40);
            this.Sign_In.TabIndex = 1;
            this.Sign_In.Text = "Sign In";
            // 
            // user_name
            // 
            this.user_name.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.user_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_name.HintForeColor = System.Drawing.Color.Empty;
            this.user_name.HintText = "";
            this.user_name.isPassword = false;
            this.user_name.LineFocusedColor = System.Drawing.Color.Tan;
            this.user_name.LineIdleColor = System.Drawing.Color.Turquoise;
            this.user_name.LineMouseHoverColor = System.Drawing.Color.Tan;
            this.user_name.LineThickness = 3;
            this.user_name.Location = new System.Drawing.Point(753, 198);
            this.user_name.Margin = new System.Windows.Forms.Padding(4);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(370, 36);
            this.user_name.TabIndex = 2;
            this.user_name.Text = "User Name";
            this.user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.Tan;
            this.password.LineIdleColor = System.Drawing.Color.Turquoise;
            this.password.LineMouseHoverColor = System.Drawing.Color.Tan;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(753, 254);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(370, 36);
            this.password.TabIndex = 3;
            this.password.Text = "200000000";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // Sign_Up
            // 
            this.Sign_Up.BackColor = System.Drawing.Color.Teal;
            this.Sign_Up.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up.ForeColor = System.Drawing.Color.Transparent;
            this.Sign_Up.Location = new System.Drawing.Point(875, 410);
            this.Sign_Up.Name = "Sign_Up";
            this.Sign_Up.Size = new System.Drawing.Size(161, 48);
            this.Sign_Up.TabIndex = 6;
            this.Sign_Up.Text = "Sign Up";
            this.Sign_Up.UseVisualStyleBackColor = false;
            this.Sign_Up.Click += new System.EventHandler(this.Sign_Up_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(831, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Not a Member?";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProMTA_WindowsForms.Properties.Resources.pro_college;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 470);
            this.panel1.TabIndex = 7;
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Image = global::ProMTA_WindowsForms.Properties.Resources.icons8_xbox_x_30;
            this.exit.Location = new System.Drawing.Point(1130, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(38, 48);
            this.exit.TabIndex = 9;
            this.exit.Tag = "1";
            this.exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // StartWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1195, 470);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sign_In);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Sign_Up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "StartWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Sign_In;
        private Bunifu.Framework.UI.BunifuMaterialTextbox user_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private System.Windows.Forms.Button Sign_Up;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
    }
}

