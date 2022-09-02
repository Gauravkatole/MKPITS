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

namespace ARRAY_PRACTICE
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
            ar.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            MessageBox.Show("Capacity" + ar.Capacity);
            MessageBox.Show("Count" + ar.Count);
            foreach(object a in ar)
            {
                s.Append("Numbers: " + a + "\n");

            }
            label1.Text= s.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder a = new StringBuilder();
            ar.Remove(2);
            foreach(object b in ar)
            {
                a.Append(b+"\n");
            }
            label3.Text= a.ToString(); 
        }
    }
}
