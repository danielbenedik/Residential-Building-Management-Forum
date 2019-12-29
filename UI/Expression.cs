using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProMTA_WindowsForms
{
    public partial class Expression : Form
    {
        public Expression()
        {
            InitializeComponent();
        }

        public void Get_event_data_from_user(int type)
        {
            // base show for event
            this.richTextBox_date_time.Show();
            this.label_date_time.Show();
            this.richTextBox_meeting_point.Show();
            this.label_meeting_point.Show();

            // topical option type
            switch (type) {
                case 2:
                    this.richTextBoxName_Activity.Show();
                    this.richTextBoxLen_Activity.Show();
                    this.label_name_activity.Show();
                    this.label_Length_Activity.Show();
                    break;
                    default:
                    this.label_name_activity.Hide();
                    this.label_Length_Activity.Hide();
                    this.richTextBoxName_Activity.Hide();
                    this.richTextBoxLen_Activity.Hide();
                    break;

            }

                this.ShowDialog();

        }

        public void Get_Status_data_from_user(int type)
        {
            this.label_date_time.Hide();
            this.label_meeting_point.Hide();
            this.label_name_activity.Hide();
            this.label_Length_Activity.Hide();
            this.richTextBox_date_time.Hide();
            this.richTextBox_meeting_point.Hide();
            this.richTextBoxName_Activity.Hide();
            this.richTextBoxLen_Activity.Hide();

            this.ShowDialog();
        }

        private void Add_status_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        public void Clean_all_win()
        {
            this.RichTextBox_title.Clear();
            this.RichTextBox_Text.Clear();
            this.richTextBox_meeting_point.Clear();
            this.richTextBox_date_time.Clear();
            this.richTextBoxName_Activity.Clear();
            this.richTextBoxLen_Activity.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
