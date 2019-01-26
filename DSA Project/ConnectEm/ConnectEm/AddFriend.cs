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
    public partial class AddFriend : Form
    {               
        Graph g;
        Graph f;
        public string CurrentUserName;

        public AddFriend()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "G" + textBox1.Text;
                Stream stream = File.Open(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                f = (Graph)bf.Deserialize(stream);
                stream.Close();

                string gpath = "G" + CurrentUserName;
                Stream stream1 = File.Open(gpath, FileMode.Open);
                g = (Graph)bf.Deserialize(stream1);
                
                if (g.FriendOrNot(f))
                {
                    MessageBox.Show("Friend is already in the List");
                    this.Close();                    
                }
                g.AddFriend(f);
                stream1.Close();
                
                Stream stream2 = File.Open(gpath, FileMode.Create);
                bf.Serialize(stream2, g);
                stream2.Close();

                Stream stream3 = File.Open(path,FileMode.Create);
                bf.Serialize(stream3, f);
                stream3.Close();

                this.Close();
            }
            catch(Exception e1)
            {
                MessageBox.Show(Convert.ToString(e1));
                //MessageBox.Show("Such Username does not exist.");
            }
        }
    }
}
