using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSOVAYA
{
    public partial class Form1 : Form
    {
        byte param1;
        byte param2;
        public Form1()
        {
            InitializeComponent();
        }
        public void Rim(int a)
        {
            string rim;
            int t = a;
            int ost;
            for (int i = 0; a>0; i++)
            {
                ost = a % 10;
                a = a / 10;
                rim = Rim_chisl(a);
            }
        }
        public string Rim_chisl(int a)
        {
            string str;
            if (a == 1)
            {
                str = "|";
            }
            else if (a == 2)
                str = "||";
            return str;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int i = Convert.ToInt32(textBox1.Text);
                string dv = Convert.ToString(i, 2);
                if (param1 == param2)
                {
                    MessageBox.Show("Ты выбрал одинаковые системы счисления");
                }
                else if (param1 == 1)  //2
                {
                    label2.Text = textBox1.Text;
                    if (param2 == 2)
                    {
                        label4.Text = Convert.ToString(i, 10);
                    }
                    else if (param2 == 3)
                    {
                        label4.Text = Convert.ToString(i, 16);
                    }
                    else if (param2 == 4)
                    {

                    }
                }
                else if (param1 == 2)   //10
                {
                    label2.Text = textBox1.Text;
                    if (param2 == 1)
                    {
                        label4.Text = Convert.ToString(i, 2);
                    }
                    else if (param2 == 3)
                    {
                        label4.Text = Convert.ToString(i, 16);
                    }
                    else if (param2 == 4)
                    {

                    }
                }
                else if (param1 == 3)   //16
                {

                    label2.Text = textBox1.Text;
                    if (param2 == 1)
                    {
                        label4.Text = Convert.ToString(i, 2);
                    }
                    else if (param2 == 2)
                    {
                        label4.Text = Convert.ToString(i, 10);
                    }
                    else if (param2 == 4)
                    {

                    }
                }
            }
            catch
            {
                MessageBox.Show("Введите число");
            }

        }

        

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            param1 = 1;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            param1 = 2;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            param1 = 3;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            param2 = 1;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            param2 = 2;
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            param2 = 3;
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            param2 = 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
