using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace arraylist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
        student s = new student(Convert.ToInt32(textBox1.Text),textBox2.Text);
        student s1 = new student(Convert.ToInt32(textBox3.Text),textBox4.Text);

            ar.Add(s);
            ar.Add(s1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder a = new StringBuilder();
            foreach(student q in ar)
            {
                a.Append("Roll No: " + q.roll + "  " + " Name: " + q.name + "\n");
            }
            label5.Text= a.ToString();
        }
    }
}
