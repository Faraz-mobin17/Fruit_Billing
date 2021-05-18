using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faraz_Mobeen_Fruit_Billing_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name_of_the_fruits = textBox1.Text;
            string lowerstr1 = name_of_the_fruits.ToLower();
            int kg = Convert.ToInt32(textBox2.Text);
            int val = 0;
            if (name_of_the_fruits == lowerstr1)
            {
                 val = kg * 15;
                textBox3.Text = Convert.ToString(val);
            } else if (name_of_the_fruits == lowerstr1)
            {
                val = kg * 10;
                textBox3.Text = Convert.ToString(val);
            } else if (name_of_the_fruits == lowerstr1)
            {
                val = kg * 20;
                textBox3.Text = Convert.ToString(val);
            } else if (name_of_the_fruits == lowerstr1)
            {
                val = kg * 30;
                textBox3.Text = Convert.ToString(val);
            } else
            {
                textBox3.Text = "invalid value";
            }

        }
    }
}
