using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Man> ListMan = new List<Man>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "")
            {
                MessageBox.Show("заполните все данные");
            }
            else
            {
                Man M = new Man(textBox1.Text, textBox2.Text, dateTimePicker1.Value, Convert.ToInt32(textBox3.Text));
                ListMan.Add(M);
                if (Convert.ToInt32(textBox3.Text) >= 18)
                {
                    listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
                }
                else
                {
                    listBox2.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
                }
                textBox1.Clear();
                textBox2.Text = "";
                textBox3.Text = "";
            }
            label7.Text = ListMan.Count.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - dateTimePicker1.Value.Year;
            if (dateTimePicker1.Value > today)
            {
                age--;
            }
        }
    }
    class Man
    {
        string Surname;
        string Name;
        DateTime Birhday;
        int Age;
        public Man(string surname, string name, DateTime d, int age)
        {
            Surname = surname;
            Name = name;
            Birhday = d;
            Age = age;
        }
    }
}
