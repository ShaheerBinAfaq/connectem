using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectEm
{
    public partial class Home : Form
    {
        public string CurrentUserName;
        
        public Home()
        {
            InitializeComponent();            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Friends_List fl = new Friends_List();
            fl.CurrentUserName = CurrentUserName;
            fl.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + CurrentUserName + "!";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddFriend af = new AddFriend();
            af.CurrentUserName = CurrentUserName;
            af.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RemoveFriend rf = new RemoveFriend();
            rf.CurrentUserName = CurrentUserName;
            rf.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textMessage tm = new textMessage();
            tm.CurrentUserName = CurrentUserName;
            tm.Show();
        }
    }
}
