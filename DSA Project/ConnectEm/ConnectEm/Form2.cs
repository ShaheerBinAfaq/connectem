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
    public partial class Form2 : Form
    {
        Users a = new Users();
        Graph g = new Graph();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.name = textBox1.Text;
            a.emailAddress = textBox2.Text;
            a.password = textBox3.Text;
            a.age = Convert.ToInt16(textBox5.Text);
            a.cityName = textBox6.Text;
            a.phoneNumber = Convert.ToInt64(textBox7.Text);

            g.name = textBox1.Text;

            if (textBox3.Text != textBox4.Text)
                MessageBox.Show("Passwords Do Not Match!");

            Stream st = File.Open(a.name, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(st, a);
            st.Close();

            Stream stream = File.Open("G" + g.name, FileMode.Create);
            bf.Serialize(stream, g);
            stream.Close();
            this.Close();            
        }
    }
}
