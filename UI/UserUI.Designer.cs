namespace ProMTA_WindowsForms
{
    partial class UserUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_user_UI = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.event_button = new System.Windows.Forms.Button();
            this.add_status_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.laundry_blog = new System.Windows.Forms.Button();
            this.my_data = new System.Windows.Forms.Button();
            this.event_blog = new System.Windows.Forms.Button();
            this.sport_blog = new System.Windows.Forms.Button();
            this.label_front_show = new System.Windows.Forms.Label();
            this.user_choice = new System.Windows.Forms.Panel();
            this.richTextBox_details = new System.Windows.Forms.RichTextBox();
            this.StatusTextBox = new System.Windows.Forms.RichTextBox();
            this.EventTextBox2 = new System.Windows.Forms.RichTextBox();
            this.StatusP = new System.Windows.Forms.Label();
            this.EventP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_picture)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.user_choice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.user_picture);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit_user_UI);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 50);
            this.panel1.TabIndex = 0;
            // 
            // user_picture
            // 
            this.user_picture.Image = global::ProMTA_WindowsForms.Properties.Resources.פרופיל;
            this.user_picture.Location = new System.Drawing.Point(408, 0);
            this.user_picture.Name = "user_picture";
            this.user_picture.Size = new System.Drawing.Size(66, 50);
            this.user_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_picture.TabIndex = 4;
            this.user_picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Pro MTA";
            // 
            // exit_user_UI
            // 
            this.exit_user_UI.FlatAppearance.BorderSize = 0;
            this.exit_user_UI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_user_UI.ForeColor = System.Drawing.Color.White;
            this.exit_user_UI.Image = global::ProMTA_WindowsForms.Properties.Resources.icons8_xbox_x_30;
            this.exit_user_UI.Location = new System.Drawing.Point(831, 6);
            this.exit_user_UI.Name = "exit_user_UI";
            this.exit_user_UI.Size = new System.Drawing.Size(37, 38);
            this.exit_user_UI.TabIndex = 3;
            this.exit_user_UI.UseVisualStyleBackColor = true;
            this.exit_user_UI.Click += new System.EventHandler(this.Exit_user_UI_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.panel2.Controls.Add(this.event_button);
            this.panel2.Controls.Add(this.add_status_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 88);
            this.panel2.TabIndex = 1;
            // 
            // event_button
            // 
            this.event_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.event_button.FlatAppearance.BorderSize = 0;
            this.event_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.event_button.ForeColor = System.Drawing.Color.White;
            this.event_button.Image = global::ProMTA_WindowsForms.Properties.Resources.icons8_event_50;
            this.event_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.event_button.Location = new System.Drawing.Point(442, 0);
            this.event_button.Name = "event_button";
            this.event_button.Size = new System.Drawing.Size(438, 88);
            this.event_button.TabIndex = 4;
            this.event_button.Text = "Add Event";
            this.event_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.event_button.UseVisualStyleBackColor = false;
            this.event_button.Click += new System.EventHandler(this.Event_button_Click);
            // 
            // add_status_button
            // 
            this.add_status_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.add_status_button.FlatAppearance.BorderSize = 0;
            this.add_status_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_status_button.ForeColor = System.Drawing.Color.White;
            this.add_status_button.Image = global::ProMTA_WindowsForms.Properties.Resources.icons8_speaker_notes_50;
            this.add_status_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_status_button.Location = new System.Drawing.Point(0, 0);
            this.add_status_button.Name = "add_status_button";
            this.add_status_button.Size = new System.Drawing.Size(436, 88);
            this.add_status_button.TabIndex = 3;
            this.add_status_button.Text = "Add Status";
            this.add_status_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_status_button.UseVisualStyleBackColor = false;
            this.add_status_button.Click += new System.EventHandler(this.Add_status_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.panel3.Controls.Add(this.laundry_blog);
            this.panel3.Controls.Add(this.my_data);
            this.panel3.Controls.Add(this.event_blog);
            this.panel3.Controls.Add(this.sport_blog);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 717);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 100);
            this.panel3.TabIndex = 2;
            // 
            // laundry_blog
            // 
            this.laundry_blog.FlatAppearance.BorderSize = 0;
            this.laundry_blog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laundry_blog.ForeColor = System.Drawing.Color.White;
            this.laundry_blog.Image = global::ProMTA_WindowsForms.Properties.Resources.icons8_washing_machine_60;
            this.laundry_blog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.laundry_blog.Location = new System.Drawing.Point(442, -3);
            this.laundry_blog.Name = "laundry_blog";
            this.laundry_blog.Size = new System.Drawing.Size(127, 100);
            this.laundry_blog.TabIndex = 3;
            this.laundry_blog.Tag = "0";
            this.laundry_blog.Text = "laundry";
            this.laundry_blog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.laundry_blog.UseVisualStyleBackColor = true;
            this.laundry_blog.Click += new System.EventHandler(this.Blog_Click);
            // 
            // my_data
            // 
            this.my_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.my_data.FlatAppearance.BorderSize = 0;
            this.my_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.my_data.ForeColor = System.Drawing.Color.White;
            this.my_data.Image = global::ProMTA_WindowsForms.Properties.Resources.icons8_person_60;
            this.my_data.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.my_data.Location = new System.Drawing.Point(570, -5);
            this.my_data.Name = "my_data";
            this.my_data.Size = new System.Drawing.Size(127, 103);
            this.my_data.TabIndex = 3;
            this.my_data.Tag = "-1";
            this.my_data.Text = "my data";
            this.my_data.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.my_data.UseVisualStyleBackColor = false;
            this.my_data.Click += new System.EventHandler(this.My_data_Click);
            // 
            // event_blog
            // 
            this.event_blog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.event_blog.FlatAppearance.BorderSize = 0;
            this.event_blog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.event_blog.ForeColor = System.Drawing.Color.White;
            this.event_blog.Image = global::ProMTA_WindowsForms.Properties.Resources.icons8_party_60;
            this.event_blog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.event_blog.Location = new System.Drawing.Point(313, -3);
            this.event_blog.Name = "event_blog";
            this.event_blog.Size = new System.Drawing.Size(127, 103);
            this.event_blog.TabIndex = 3;
            this.event_blog.Tag = "1";
            this.event_blog.Text = "event";
            this.event_blog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.event_blog.UseVisualStyleBackColor = false;
            this.event_blog.Click += new System.EventHandler(this.Blog_Click);
            // 
            // sport_blog
            // 
            this.sport_blog.FlatAppearance.BorderSize = 0;
            this.sport_blog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sport_blog.ForeColor = System.Drawing.Color.White;
            this.sport_blog.Image = global::ProMTA_WindowsForms.Properties.Resources.icons8_running_60;
            this.sport_blog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sport_blog.Location = new System.Drawing.Point(184, -1);
            this.sport_blog.Name = "sport_blog";
            this.sport_blog.Size = new System.Drawing.Size(127, 100);
            this.sport_blog.TabIndex = 3;
            this.sport_blog.Tag = "2";
            this.sport_blog.Text = "sport";
            this.sport_blog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sport_blog.UseVisualStyleBackColor = true;
            this.sport_blog.Click += new System.EventHandler(this.Blog_Click);
            // 
            // label_front_show
            // 
            this.label_front_show.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_front_show.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.label_front_show.Location = new System.Drawing.Point(1, 29);
            this.label_front_show.Name = "label_front_show";
            this.label_front_show.Size = new System.Drawing.Size(121, 38);
            this.label_front_show.TabIndex = 0;
            this.label_front_show.Text = "My Data:";
            // 
            // user_choice
            // 
            this.user_choice.Controls.Add(this.richTextBox_details);
            this.user_choice.Controls.Add(this.label_front_show);
            this.user_choice.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_choice.Location = new System.Drawing.Point(0, 138);
            this.user_choice.Name = "user_choice";
            this.user_choice.Size = new System.Drawing.Size(880, 100);
            this.user_choice.TabIndex = 3;
            // 
            // richTextBox_details
            // 
            this.richTextBox_details.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.richTextBox_details.Location = new System.Drawing.Point(114, 0);
            this.richTextBox_details.Name = "richTextBox_details";
            this.richTextBox_details.ReadOnly = true;
            this.richTextBox_details.Size = new System.Drawing.Size(766, 97);
            this.richTextBox_details.TabIndex = 1;
            this.richTextBox_details.Text = "";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusTextBox.Font = new System.Drawing.Font("Colonna MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.StatusTextBox.Location = new System.Drawing.Point(6, 284);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(433, 427);
            this.StatusTextBox.TabIndex = 4;
            this.StatusTextBox.Text = "";
            // 
            // EventTextBox2
            // 
            this.EventTextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EventTextBox2.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.EventTextBox2.Location = new System.Drawing.Point(444, 284);
            this.EventTextBox2.Name = "EventTextBox2";
            this.EventTextBox2.ReadOnly = true;
            this.EventTextBox2.Size = new System.Drawing.Size(433, 427);
            this.EventTextBox2.TabIndex = 5;
            this.EventTextBox2.Text = "";
            // 
            // StatusP
            // 
            this.StatusP.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.StatusP.Location = new System.Drawing.Point(151, 241);
            this.StatusP.Name = "StatusP";
            this.StatusP.Size = new System.Drawing.Size(109, 40);
            this.StatusP.TabIndex = 6;
            this.StatusP.Text = "Status";
            // 
            // EventP
            // 
            this.EventP.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.EventP.Location = new System.Drawing.Point(621, 241);
            this.EventP.Name = "EventP";
            this.EventP.Size = new System.Drawing.Size(109, 40);
            this.EventP.TabIndex = 7;
            this.EventP.Text = "Event";
            // 
            // UserUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(880, 817);
            this.Controls.Add(this.EventP);
            this.Controls.Add(this.StatusP);
            this.Controls.Add(this.EventTextBox2);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.user_choice);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_picture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.user_choice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_front_show;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button sport_blog;
        private System.Windows.Forms.Button laundry_blog;
        private System.Windows.Forms.Button event_blog;
        private System.Windows.Forms.Button exit_user_UI;
        private System.Windows.Forms.Panel user_choice;
        private System.Windows.Forms.PictureBox user_picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button my_data;
        private System.Windows.Forms.Button event_button;
        private System.Windows.Forms.Button add_status_button;
        private System.Windows.Forms.RichTextBox richTextBox_details;
        private System.Windows.Forms.RichTextBox StatusTextBox;
        private System.Windows.Forms.RichTextBox EventTextBox2;
        private System.Windows.Forms.Label StatusP;
        private System.Windows.Forms.Label EventP;
    }
}