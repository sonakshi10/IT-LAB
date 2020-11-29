using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double salary;
            double.TryParse(textBox1.Text, out salary);

            string level = comboBox1.Text;
            double bonus;
            if(level == "Level 1")
            {
                bonus = salary * 0.01;
            }
            else if(level == "Level 2" || level == "Level 3" || level == "Level 4")
            {
                bonus = salary * 0.09;
            }
            else if (level == "Level 5" || level == "Level 6" || level == "Level 7")
            {
                bonus = salary * 0.07;
            }
            else
            {
                bonus = salary * 0.05;
            }
            textBox2.Text = bonus.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double salary;
            double.TryParse(textBox1.Text, out salary);

            string level = comboBox1.Text;
            double bonus;
            if(comboBox1.SelectedItem != null)
            {
                if (level == "Level 1")
                {
                    bonus = salary * 0.01;
                }
                else if (level == "Level 2" || level == "Level 3" || level == "Level 4")
                {
                    bonus = salary * 0.09;
                }
                else if (level == "Level 5" || level == "Level 6" || level == "Level 7")
                {
                    bonus = salary * 0.07;
                }
                else
                {
                    bonus = salary * 0.05;
                }
                textBox2.Text = bonus.ToString();
            }
        }
    }
}
