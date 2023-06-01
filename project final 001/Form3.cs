using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_final_001
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string s = textBox1.Text + " " + textBox2.Text;
            for (int i = 0; i < 60 - Tables.Remaining; i++)
            {

                if (s == Tables.arr1[i])
                    listBox1.Items.Add(Tables.arr1[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                listBox1.Items.Add(textBox1.Text + " " + textBox2.Text);
                Tables.arr1[60 - Tables.Remaining] = textBox1.Text + " " + textBox2.Text;
                Tables.Remaining--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 60 - Tables.Remaining; i++)
            {

                if (listBox1.SelectedItem.ToString() == Tables.arr1[i]) {
                    for (int j = i + 1; j < 60 - Tables.Remaining; j++)
                    {
                        Tables.arr1[j-1] = Tables.arr1[j];
                    }
                    Tables.Remaining++;
                    break;

                }

            }
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
