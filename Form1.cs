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

        private void button1_Click(object sender, EventArgs e)
        {
            if (param1 == param2)
            {
                MessageBox.Show("Ты выбрал одинаковые системы счисления");
            }
            else if (param1 == 1)  //2
            {
                int i = Convert.ToInt32(textBox1.Text);
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
                int i = Convert.ToInt32(textBox1.Text);
                label2.Text = textBox1 + "";
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
    }
}
