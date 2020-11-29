using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            if (name == "Maruti")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Swift");
                listBox1.Items.Add("Alto");
                listBox1.Items.Add("Dzire");
                listBox1.Items.Add("Eeco");
                listBox1.Items.Add("Baleno");
            }
            else if (name == "Honda")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("City");
                listBox1.Items.Add("Civic");
                listBox1.Items.Add("Jazz");
                listBox1.Items.Add("Amaze");
                listBox1.Items.Add("CR-V");
            }
            else if (name == "Chevrolet")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Spark");
                listBox1.Items.Add("Beat");
                listBox1.Items.Add("Enjoy");
                listBox1.Items.Add("Tavera");
                listBox1.Items.Add("Cruze");
            }
            else if (name == "Ford")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Mustang");
                listBox1.Items.Add("Aspire");
                listBox1.Items.Add("Endeavour");
                listBox1.Items.Add("Figo");
                listBox1.Items.Add("EcoSport");
            }
            else if (name == "Toyota")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Yaris");
                listBox1.Items.Add("Camry");
                listBox1.Items.Add("Fortuner");
                listBox1.Items.Add("Glanza");
                listBox1.Items.Add("Crysta");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please Select Name");
            }
            else if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please Select Color");
            }
            else if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please Select at least one Model");
            }
            else
                MessageBox.Show("Thank you for purchasing!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            listBox1.Items.Clear();
            textBox1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = listBox1.SelectedItems.Count;
            if(count == 0)
            {
                textBox1.Text = "0";
            }
            else if (count == 1)
            {
                textBox1.Text = "500000";
            }
            else if (count == 2)
            {
                textBox1.Text = "850000";
            }
            else if (count == 3)
            {
                textBox1.Text = "1040082";
            }
            else if (count == 4)
            {
                textBox1.Text = "2050000";
            }
            else 
            {
                textBox1.Text = "3600000";
            }
        }
    }
}
