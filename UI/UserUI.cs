using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProMtaBrain;

namespace ProMTA_WindowsForms
{
    public partial class UserUI : Form
    {
        BigDataPro totalData;
        Expression expressionUI;
        ProMtaBrain.eBranch currentTypeOfDataOnWIN = ProMtaBrain.eBranch.user; // -1 = user else is the branchs

        public UserUI(BigDataPro _totalData)
        {
            InitializeComponent();
            totalData = _totalData;
            Convert_private_user_data();
            expressionUI = new Expression();
        }

        private void Convert_private_user_data()
        {
            this.label_front_show.Text = "My Data:";
           
            this.richTextBox_details.Text = "Name: " + totalData.CurrentMember.Name +
                      "\nDate of birth: " + totalData.CurrentMember.DateOfBirth.ToShortDateString() +
                      "\nEmail: " + totalData.CurrentMember.MailAddress.ToString();
        }

        private void Blog_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            string details = currentButton.Tag as string;
            currentTypeOfDataOnWIN = (ProMtaBrain.eBranch)int.Parse(details);

            Branch current_branch = totalData.ProMtaBranch[(int)currentTypeOfDataOnWIN];

            this.label_front_show.Text = current_branch.Name;
            this.richTextBox_details.Text = current_branch.UsefulInformation;

            Update_status_and_event();



        }

        private void Update_status_and_event()
        {
            DataStatusEventFriends temp;

            StatusTextBox.Clear();
            EventTextBox2.Clear();

            if (currentTypeOfDataOnWIN != ProMtaBrain.eBranch.user)
            {
                temp = totalData.ProMtaBranch[(int)currentTypeOfDataOnWIN].MyData;
            }
            else
            {
                temp = totalData.CurrentMember.MyData;
            }

            temp.Reverse_all_lists();

            foreach (Status _status in temp.StatusList) // status
            {
                Update_Status_to_textBox(_status, this.StatusTextBox);
                this.StatusTextBox.SelectedText = Environment.NewLine;

            }

            foreach (Event _event in temp.EventList) // events
            {
                Update_Status_to_textBox(_event, this.EventTextBox2);
                Update_Event_to_textBox(_event, this.EventTextBox2);

                if (_event is SportEvent)  // if is sportEvent
                {
                    Update_EventSport_to_textBox((ProMtaBrain.SportEvent)_event, this.EventTextBox2);
                }

                this.EventTextBox2.SelectedText = Environment.NewLine;
            }

            temp.Reverse_all_lists();
        }

        private void Update_EventSport_to_textBox(ProMtaBrain.SportEvent takeFromDetails, RichTextBox toUpdate)
        {
            Set_font("Activity Name: ", takeFromDetails.NameOfTheActivity, toUpdate);
            Set_font("Length Activity (KM): ", takeFromDetails.LengthOfThePath.ToString(), toUpdate);
        }

        private void Update_Event_to_textBox(ProMtaBrain.Event takeFromDetails, RichTextBox toUpdate)
        {

            Set_font("Meeting Point: ", takeFromDetails.MeetingPoint, toUpdate);
            Set_font("Meeting Time: ", takeFromDetails.MemeetingTime.ToString(), toUpdate);
        }

        private void Update_Status_to_textBox(ProMtaBrain.Expression takeFromDetails, RichTextBox toUpdate )
        {
            toUpdate.SelectionColor = Color.WhiteSmoke;
            toUpdate.SelectionFont = new Font("Cooper Black", 14, FontStyle.Underline);
            toUpdate.SelectedText = takeFromDetails.NameOfBranch + Environment.NewLine;

            Set_font("Title: ", takeFromDetails.Title, toUpdate);
            Set_font("Post Time: ", takeFromDetails.Time.ToString(), toUpdate);
            Set_font("Comment: ", takeFromDetails.Content, toUpdate);
        }

        private void Set_font(string title, string sentence, RichTextBox toSet)
        {
            toSet.SelectionColor = Color.DarkBlue;
            toSet.SelectionFont = new Font("Cooper Black", 13, FontStyle.Underline);
            toSet.SelectedText = title;

            toSet.SelectionColor = Color.Black;
            toSet.SelectionFont = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            toSet.SelectedText = sentence + Environment.NewLine;
        }

        private void Convert_blog_data(int indexBranch)
        {
        }

        private void Exit_user_UI_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //totalData.Save_to_file();
            this.Close();
        }

        private void My_data_Click(object sender, EventArgs e)
        {
            currentTypeOfDataOnWIN = ProMtaBrain.eBranch.user;
            Convert_private_user_data();
            Update_status_and_event();
        }

        private void Add_status_button_Click(object sender, EventArgs e)
        {

            expressionUI.Get_Status_data_from_user((int)currentTypeOfDataOnWIN);
            Status newStatus = new Status(currentTypeOfDataOnWIN.ToString(), expressionUI.RichTextBox_title.Text, expressionUI.RichTextBox_Text.Text ,DateTime.Now);
            if(expressionUI.DialogResult == DialogResult.OK)
            {
                if (currentTypeOfDataOnWIN != ProMtaBrain.eBranch.user)
                {
                    totalData.ProMtaBranch[(int)currentTypeOfDataOnWIN].MyData.Add_to_statusList(newStatus);
                }
                totalData.CurrentMember.MyData.Add_to_statusList(newStatus);
            }
            expressionUI.Clean_all_win();
        }

        private void Event_button_Click(object sender, EventArgs e)
        {
            Event newEvent = null;

        tryAginToGetCurrecProperty: // in this point we check if the dateTime event AND len sport
            expressionUI.Get_event_data_from_user((int)currentTypeOfDataOnWIN);

            if (expressionUI.DialogResult != DialogResult.Cancel)
            {
                try
                {
                    if (DateTime.TryParse(expressionUI.RichTextBox_date_time.Text, out DateTime garbageDateTime))
                    {
                        if (ProMtaBrain.eBranch.SportBlog == currentTypeOfDataOnWIN)
                        {
                            if (int.TryParse(expressionUI.RichTextBoxLen_Activity.Text, out int garbage))
                            {
                                newEvent = new SportEvent(currentTypeOfDataOnWIN.ToString(), expressionUI.RichTextBox_title.Text, expressionUI.RichTextBox_Text.Text, DateTime.Now, expressionUI.RichTextBox_meeting_point.Text, DateTime.Parse(expressionUI.RichTextBox_date_time.Text), expressionUI.RichTextBoxName_Activity.Text, int.Parse(expressionUI.RichTextBoxLen_Activity.Text));
                            }
                            else
                            {
                                expressionUI.DialogResult = DialogResult.No;
                                throw new System.InvalidOperationException("You must give proper activity length");
                            }
                        }
                        else
                        {
                            newEvent = new Event(currentTypeOfDataOnWIN.ToString(), expressionUI.RichTextBox_title.Text, expressionUI.RichTextBox_Text.Text, DateTime.Now, expressionUI.RichTextBox_meeting_point.Text, DateTime.Parse(expressionUI.RichTextBox_date_time.Text));
                        }

                        if (currentTypeOfDataOnWIN != ProMtaBrain.eBranch.user)
                        {
                            totalData.ProMtaBranch[(int)currentTypeOfDataOnWIN].MyData.Add_to_eventList(newEvent);
                        }
                    }
                    else
                    {
                        expressionUI.DialogResult = DialogResult.No;
                        throw new System.InvalidOperationException("your Date is not invalid");
                    }
                    totalData.CurrentMember.MyData.Add_to_eventList(newEvent);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                    goto tryAginToGetCurrecProperty;
                }
            }
            expressionUI.Clean_all_win();
        }
    }
}
