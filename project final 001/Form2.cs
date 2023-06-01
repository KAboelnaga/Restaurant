using project_final_001;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            for (int i = 0; i < 60 - Tables.Remaining; i++)
            {
                listBox1.Items.Add(Tables.arr1[i]);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int remaining = Tables.Remaining;
            label2.Text = remaining.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label5.Text = "Please insert client name and number.";
            }
            else
            {
                listBox1.Items.Add(textBox1.Text + " " + textBox2.Text);
                for (int i = 0; i < 60 - Tables.Remaining; i++)
                {
                    Tables.arr1[i] = listBox1.Items[i].ToString();
                }
                Tables.Remaining--;
                label5.Text = "";
                label5.Text = "Please insert client name and number.";
            }
            label2.Text = Tables.Remaining.ToString();
            Tables.arr1[60 - Tables.Remaining] = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            Tables.Remaining = 60 - listBox1.Items.Count;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Tables.arr1[i] = listBox1.Items[i].ToString();
            }
            label2.Text = Tables.Remaining.ToString();
            label5.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
