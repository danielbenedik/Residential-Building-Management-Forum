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
    public partial class StartWin : Form
    {
        BigDataPro totalData;

        public StartWin()
        {
            InitializeComponent();
            totalData = BigDataPro.Load_from_file();
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13) // enter == 13
            {
               if (totalData.Connect_member(user_name.Text, password.Text))
                {
                    UserUI currentUser = new UserUI(totalData);
                    this.Close();
                    currentUser.ShowDialog();
                }
               else
                {
                    MessageBox.Show("Login failed: Check\n1.Do you have a User?\n2. The username or password is incorrect");
                }
            }
        }

        private void Sign_Up_Click(object sender, EventArgs e)
        {
            RegistrationForm newAccount = new RegistrationForm(totalData);
            newAccount.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //totalData.Save_to_file();
            this.Close();
        }
    }
}
