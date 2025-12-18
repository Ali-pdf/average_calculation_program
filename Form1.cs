using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            double not1, not2, not3, ort;
            not1 = double.Parse(textBox1.Text);
            not2 = double.Parse(textBox2.Text);
            not3 = double.Parse(textBox3.Text);
            ort = (not1 + not2 + not3) / 3;
            textBox4.Text = ort.ToString();

        }
    }
    
}
