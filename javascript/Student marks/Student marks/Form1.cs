using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Student_marks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        marks m=new marks();
        private void button1_Click(object sender, EventArgs e)
        {
            
            m.che=Convert.ToInt32(textBox3.Text);
            m.phy=Convert.ToInt32(textBox4.Text);
            m.maths= Convert.ToInt32(textBox5.Text);
            string tota = m.total();
            label6.Text = tota;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string p = m.percentage();
            label7.Text = "Percentage: " + p.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string g = m.grade();
            label8.Text = "Grade: " + g.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m.rollno=Convert.ToInt32(textBox1.Text);
            m.name = textBox2.Text;
            StringBuilder s = new StringBuilder();
            s.Append("Ronn No: " + m.rollno + "\n\n");
            s.Append("Name: " + m.name+"\n\n");
            s.Append("Chemistry Marks: " + m.che+"\n\n");
            s.Append("Physics Marks: " + m.phy+"\n\n");
            s.Append("Maths Marks: " + m.maths+"\n\n");
            label9.Text = s.ToString();
        }
    }
}
