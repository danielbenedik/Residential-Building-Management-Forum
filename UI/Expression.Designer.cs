using System.Windows.Forms;

namespace ProMTA_WindowsForms
{
    partial class Expression
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
            this.richTextBox_title = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Text = new System.Windows.Forms.RichTextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add_status_button = new System.Windows.Forms.Button();
            this.label_meeting_point = new System.Windows.Forms.Label();
            this.richTextBox_meeting_point = new System.Windows.Forms.RichTextBox();
            this.label_date_time = new System.Windows.Forms.Label();
            this.richTextBox_date_time = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_name_activity = new System.Windows.Forms.Label();
            this.richTextBoxName_Activity = new System.Windows.Forms.RichTextBox();
            this.label_Length_Activity = new System.Windows.Forms.Label();
            this.richTextBoxLen_Activity = new System.Windows.Forms.RichTextBox();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_title
            // 
            this.richTextBox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox_title.Location = new System.Drawing.Point(133, 15);
            this.richTextBox_title.Name = "richTextBox_title";
            this.richTextBox_title.Size = new System.Drawing.Size(658, 41);
            this.richTextBox_title.TabIndex = 0;
            this.richTextBox_title.Text = "";
            // 
            // richTextBox_Text
            // 
            this.richTextBox_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox_Text.Location = new System.Drawing.Point(13, 98);
            this.richTextBox_Text.Name = "richTextBox_Text";
            this.richTextBox_Text.Size = new System.Drawing.Size(775, 83);
            this.richTextBox_Text.TabIndex = 1;
            this.richTextBox_Text.Text = "";
            // 
            // title_label
            // 
            this.title_label.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(6, 15);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(121, 38);
            this.title_label.TabIndex = 2;
            this.title_label.Text = "Title:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text:";
            // 
            // add_status_button
            // 
            this.add_status_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.add_status_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.add_status_button.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.add_status_button.FlatAppearance.BorderSize = 6;
            this.add_status_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_status_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.add_status_button.ForeColor = System.Drawing.Color.White;
            this.add_status_button.Image = global::ProMTA_WindowsForms.Properties.Resources.icons8_speaker_notes_50;
            this.add_status_button.Location = new System.Drawing.Point(795, 0);
            this.add_status_button.Name = "add_status_button";
            this.add_status_button.Size = new System.Drawing.Size(114, 497);
            this.add_status_button.TabIndex = 4;
            this.add_status_button.Text = "ADD";
            this.add_status_button.UseVisualStyleBackColor = false;
            this.add_status_button.Click += new System.EventHandler(this.Add_status_button_Click);
            // 
            // label_meeting_point
            // 
            this.label_meeting_point.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_meeting_point.ForeColor = System.Drawing.Color.White;
            this.label_meeting_point.Location = new System.Drawing.Point(12, 13);
            this.label_meeting_point.Name = "label_meeting_point";
            this.label_meeting_point.Size = new System.Drawing.Size(275, 38);
            this.label_meeting_point.TabIndex = 6;
            this.label_meeting_point.Text = "Meeting Point:";
            // 
            // richTextBox_meeting_point
            // 
            this.richTextBox_meeting_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox_meeting_point.Location = new System.Drawing.Point(293, 17);
            this.richTextBox_meeting_point.Name = "richTextBox_meeting_point";
            this.richTextBox_meeting_point.Size = new System.Drawing.Size(495, 41);
            this.richTextBox_meeting_point.TabIndex = 7;
            this.richTextBox_meeting_point.Text = "";
            // 
            // label_date_time
            // 
            this.label_date_time.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_time.ForeColor = System.Drawing.Color.White;
            this.label_date_time.Location = new System.Drawing.Point(12, 77);
            this.label_date_time.Name = "label_date_time";
            this.label_date_time.Size = new System.Drawing.Size(275, 75);
            this.label_date_time.TabIndex = 8;
            this.label_date_time.Text = "Date And Time\r\nd/m/y 00:00-";
            // 
            // richTextBox_date_time
            // 
            this.richTextBox_date_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox_date_time.Location = new System.Drawing.Point(293, 111);
            this.richTextBox_date_time.Name = "richTextBox_date_time";
            this.richTextBox_date_time.Size = new System.Drawing.Size(496, 41);
            this.richTextBox_date_time.TabIndex = 9;
            this.richTextBox_date_time.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.richTextBox_date_time);
            this.panel1.Controls.Add(this.label_meeting_point);
            this.panel1.Controls.Add(this.richTextBox_meeting_point);
            this.panel1.Controls.Add(this.label_date_time);
            this.panel1.Location = new System.Drawing.Point(0, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 159);
            this.panel1.TabIndex = 10;
            // 
            // label_name_activity
            // 
            this.label_name_activity.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_activity.ForeColor = System.Drawing.Color.White;
            this.label_name_activity.Location = new System.Drawing.Point(12, 384);
            this.label_name_activity.Name = "label_name_activity";
            this.label_name_activity.Size = new System.Drawing.Size(415, 38);
            this.label_name_activity.TabIndex = 11;
            this.label_name_activity.Text = "Name Of The Activity:";
            // 
            // richTextBoxName_Activity
            // 
            this.richTextBoxName_Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBoxName_Activity.Location = new System.Drawing.Point(423, 384);
            this.richTextBoxName_Activity.Name = "richTextBoxName_Activity";
            this.richTextBoxName_Activity.Size = new System.Drawing.Size(368, 41);
            this.richTextBoxName_Activity.TabIndex = 12;
            this.richTextBoxName_Activity.Text = "";
            // 
            // label_Length_Activity
            // 
            this.label_Length_Activity.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Length_Activity.ForeColor = System.Drawing.Color.White;
            this.label_Length_Activity.Location = new System.Drawing.Point(12, 437);
            this.label_Length_Activity.Name = "label_Length_Activity";
            this.label_Length_Activity.Size = new System.Drawing.Size(415, 38);
            this.label_Length_Activity.TabIndex = 13;
            this.label_Length_Activity.Text = "Length Activity:";
            // 
            // richTextBoxLen_Activity
            // 
            this.richTextBoxLen_Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBoxLen_Activity.Location = new System.Drawing.Point(423, 437);
            this.richTextBoxLen_Activity.Name = "richTextBoxLen_Activity";
            this.richTextBoxLen_Activity.Size = new System.Drawing.Size(368, 41);
            this.richTextBoxLen_Activity.TabIndex = 14;
            this.richTextBoxLen_Activity.Text = "";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Image = global::ProMTA_WindowsForms.Properties.Resources.icons8_xbox_x_30;
            this.exit.Location = new System.Drawing.Point(809, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(88, 41);
            this.exit.TabIndex = 15;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Expression
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(909, 497);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.richTextBoxLen_Activity);
            this.Controls.Add(this.label_Length_Activity);
            this.Controls.Add(this.richTextBoxName_Activity);
            this.Controls.Add(this.label_name_activity);
            this.Controls.Add(this.add_status_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.richTextBox_Text);
            this.Controls.Add(this.richTextBox_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expression";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expression";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_title;
        private System.Windows.Forms.RichTextBox richTextBox_Text;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_status_button;
        private Label label_meeting_point;
        private RichTextBox richTextBox_meeting_point;
        private Label label_date_time;
        private RichTextBox richTextBox_date_time;
        private Panel panel1;
        private Label label_name_activity;
        private RichTextBox richTextBoxName_Activity;
        private Label label_Length_Activity;
        private RichTextBox richTextBoxLen_Activity;
        private Button exit;

        public RichTextBox RichTextBox_title { get => richTextBox_title;}
        public RichTextBox RichTextBox_Text { get => richTextBox_Text;}
        public RichTextBox RichTextBoxLen_Activity { get => richTextBoxLen_Activity;}
        public Label Label_Length_Activity { get => label_Length_Activity;}
        public RichTextBox RichTextBoxName_Activity { get => richTextBoxName_Activity;}
        public RichTextBox RichTextBox_meeting_point { get => richTextBox_meeting_point;}
        public RichTextBox RichTextBox_date_time { get => richTextBox_date_time;}
    }
}