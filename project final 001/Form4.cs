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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            Main[0] = new Main_dish("Grilled Chicken", 120, 2);
            listBox1.Items.Add(Main[0].name);
            Main[1] = new Main_dish("Steak", 180, 1);
            listBox1.Items.Add(Main[1].name);

            Main[2] = new Main_dish("Fillet Fish", 210, 1);
            listBox1.Items.Add(Main[2].name);


            Drinks[0] = new Drink("Latte", 60, true);
            listBox2.Items.Add(Drinks[0].name);

            Drinks[1] = new Drink("Coffee", 20, true);
            listBox2.Items.Add(Drinks[1].name);

            Drinks[2] = new Drink("Smoothie", 50, false);
            listBox2.Items.Add(Drinks[2].name);

            Drinks[3] = new Drink("Water", 15, false);
            listBox2.Items.Add(Drinks[3].name);


            Deserts[0] = new Desert("Cupcakes", 30, 1);
            listBox3.Items.Add(Deserts[0].name);

            Deserts[1] = new Desert("Oreo Madness", 80, 3);
            listBox3.Items.Add(Deserts[1].name);

            Deserts[2] = new Desert("Banana Split", 50, 2);
            listBox3.Items.Add(Deserts[2].name);
        }
        public Main_dish[] Main = new Main_dish[3];
        public Drink[] Drinks = new Drink[4];
        public Desert[] Deserts = new Desert[3];

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Price";
            label3.Text = "";
            label4.Text = "";
            if(comboBox1.SelectedIndex == 0)
            {

                listBox1.Visible = true;
                listBox2.Visible = false;
                listBox3.Visible = false;
                label2.Text = "Number of Side Dishes:";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Visible = false;
                listBox2.Visible = true;
                listBox3.Visible = false;
                label2.Text = "";
            }
            else
            {
                listBox1.Visible = false;
                listBox2.Visible = false;
                listBox3.Visible = true;
                label2.Text = "Number of Servings:";
            }

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label3.Text = Main[listBox1.SelectedIndex].price.ToString();
            label4.Text = Main[listBox1.SelectedIndex].number_of_side_dishes.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = Drinks[listBox2.SelectedIndex].price.ToString();
            if (Drinks[listBox2.SelectedIndex].hot)
            {
                label2.Text = "Hot";
            }
            else label2.Text = "Cold";
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = Deserts[listBox3.SelectedIndex].price.ToString();
            label4.Text = Deserts[listBox3.SelectedIndex].serving_size.ToString();
        }
    }
}
