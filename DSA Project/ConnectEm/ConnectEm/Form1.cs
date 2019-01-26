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
    public partial class Form1 : Form
    {
        public string PUserName
        {
            get { return UserNameText.Text; }
        }
        //Users a;
       public Users u;
        Graph g;
        public Form1()
        {
            InitializeComponent();
            //Users admin = new Users("Admin", "", 0, "admin@connectem.com", "12345678", 0);
            //Stream st = File.Open("Admin", FileMode.Create);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(st, admin);
            //st.Close();
            //Stream stream = File.Open("Admin", FileMode.Open);
            //BinaryFormatter bf = new BinaryFormatter();
            //a = (Users)bf.Deserialize(stream);
            //stream.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                u=DeserialiseUser();
                //Friends_List fl = new Friends_List();
                //AddFriend af = new AddFriend();
                //af.abcd = UserNameText.Text;
                //af.Show();
                //af.CurrentUser = u;
                //af.CurrentUserName = PUserName;

                if (u.password == textBox2.Text)
                {
                    Home h = new Home();
                    h.CurrentUserName = UserNameText.Text;
                    h.Show();
                }
                else
                    MessageBox.Show("Incorrect Password!");
                Form1 f1 = new Form1();
                f1.Close();
            
            
        }
                public string GetUserName()
        {
            return UserNameText.Text;
        }
        public Users DeserialiseUser()
                {
                    try
                    {
                        Stream stream = File.Open(UserNameText.Text, FileMode.Open);
                        BinaryFormatter bf = new BinaryFormatter();
                        u = (Users)bf.Deserialize(stream);
                        stream.Close();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Such User name does not exist");
                    }
                    return u;
                }
           
            
        

        private void button2_Click(object sender, EventArgs e)
        {            
            Form2 f2 = new Form2();
            f2.Show();
        }
        
        public Graph GetGraph()
        {
            try
            {
                Stream stream1 = File.Open("G" + UserNameText.Text, FileMode.Open);
                BinaryFormatter bf1 = new BinaryFormatter();
                g = (Graph)bf1.Deserialize(stream1);
                stream1.Close();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("occuring in GEtGraph" + exception);
            }
            return g;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
