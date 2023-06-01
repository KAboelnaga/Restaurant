using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_final_001
{
    public abstract class Tables
    {
        public static string[] arr1 = new string[10];
        public static int Remaining = 60;
    }
    public abstract class Item {
        public string name;
        public float price;
    }
    public class Main_dish : Item
    {
        public int number_of_side_dishes;
        public Main_dish() { }
        public Main_dish(string name, int price, int number_of_side_dishes) {
            this.name = name;
            this.price = price;
            this.number_of_side_dishes = number_of_side_dishes;
        }

    }
    public class Drink : Item
    {
        public bool hot;
        public Drink() { }
        public Drink(string name, int price, bool hot)
        {
            this.name = name;
            this.price = price;
            this.hot = hot;
        }
    }
    public class Desert : Item
    {
        public int serving_size;
        public Desert() { }
        public Desert(string name, int price, int serving_size)
        {
            this.name = name;
            this.price = price;
            this.serving_size = serving_size;
        }
    }



    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
