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
using System.Net.Mail;

namespace ProMTA_WindowsForms
{ 
    public partial class RegistrationForm : Form
    {
        BigDataPro totalData;

        public RegistrationForm(BigDataPro _totalData)
        {
            InitializeComponent();
            totalData = _totalData;
        }

        private void Create_account_Click(object sender, EventArgs e)
        {
        DateTime memberDateBirth;
            
            try
            {
                if((maleCheckBox.Checked == true && femaleCheckBox.Checked == true) || (maleCheckBox.Checked == false && femaleCheckBox.Checked == false))
                {
                    throw new System.InvalidOperationException("You should choose a gender properly");
                }
                else
                {
                    if (Is_valid_email(Emailadd.Text))
                    {
                        if(Passwordd.Text == passwordCon.Text)
                        {
                            if (DateTime.TryParse(DateBirth.Text, out memberDateBirth))
                            {
                                Member newMember = new Member(user_name.Text, memberDateBirth, maleCheckBox.Checked, new System.Net.Mail.MailAddress(Emailadd.Text), Passwordd.Text);
                                this.Close();
                                totalData.Add_new_user(newMember);

                            }
                            else
                            {
                                throw new System.InvalidOperationException("your Date Birth is not invalid");
                            }

                        
                        }
                        else
                        {
                            throw new System.InvalidOperationException("your password not matching ");
                        }
                    }
                    else
                    {
                        throw new System.InvalidOperationException("Email Address is not invalid");
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private bool Is_valid_email(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email); // to improw to return also a email
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
