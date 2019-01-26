using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConnectEm
{
    public partial class Friends_List : Form
    {
        Graph g1;
        public string CurrentUserName;
        public Friends_List()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            ////g1 = new Graph(f1.GetUserName());
            //Stream stream = File.Open("G" + CurrentUserName , FileMode.Open);
            //BinaryFormatter bf = new BinaryFormatter();
            //g1 = (Graph)bf.Deserialize(stream);
            //listBox1.DataSource = g1.friends;
        }

        private void Friends_List_Load(object sender, EventArgs e)
        {
            try
            {
                Stream stream = File.Open("G" + CurrentUserName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                g1 = (Graph)bf.Deserialize(stream);
                listBox1.DataSource = g1.friends;
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //public void ShowFriends(Users a)
        //{
        //    Form1 f1 = new Form1();
        //    g1 = new Graph(f1.GetUserName());
        //}
        
        

    }
}
