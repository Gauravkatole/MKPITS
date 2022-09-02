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

namespace arraylist_using_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar = new ArrayList();
        student[] stud = new student[3];
       int i=0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (i <= 3)
            {
                i++;
                stud[i - 1] = new student(int.Parse(textBox1.Text), textBox2.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                textBox2.Focus();
                ar.Add(stud[i - 1]);
            }
            if (i == 3)
            {   MessageBox.Show("# item added oin arrayt");
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(student q in ar)
            {
                sb.Append("Roll No: " + q.roll+"  "+"Name: "+q.name+"\n");
            }
            label2.Text=sb.ToString();
        }
    }
}
