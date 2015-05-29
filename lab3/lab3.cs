using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab3
{
    public partial class Menu : Form
    {
        List<Food> meal;
        List<Food> drink;
        List<Smeta> smeta;

        public Menu()
        {
            meal = new List<Food>();
            drink = new List<Food>();
            smeta = new List<Smeta>();
            read();
            InitializeComponent();
        }

        public static void AddMeal(List<Food> m, Food food){            
            m.Add(food);
        }

        public static void DeleteMeal(List<Food> menu, string name)
        {
            menu.RemoveAt(menu.FindIndex(m => m.name == name));           
        }

        public static void AddSmetaProduct(List<Smeta> smeta, Smeta s)
        {
            smeta.Add(s);          
        }

        public static void DeleteSmetaProduct(List<Smeta> smeta, string name)
        {            
            smeta.RemoveAt(smeta.FindIndex(m => m.smetaProduct.name == name));
        }

        public static int Calculate(List<Smeta> smeta)
        {
            int res = 0;
            for (int i = 0; i < smeta.Count; i++)
            {
                res += smeta[i].smetaProduct.price * smeta[i].count;
            }
            return res;
        }

        public void read(){
            StreamReader sr = new StreamReader("outputMeal.txt");
            Food f;
            meal.Clear();
            while (!sr.EndOfStream)
            {
                f = new Food();
                f.name = sr.ReadLine();
                f.price = Convert.ToInt32(sr.ReadLine());
                meal.Add(f);
            }
            sr.Close();

            StreamReader sr2 = new StreamReader("outputDrink.txt");
            Food f2;
            drink.Clear();
            while (!sr2.EndOfStream)
            {
                f2 = new Food();
                f2.name = sr2.ReadLine();
                f2.price = Convert.ToInt32(sr2.ReadLine());
                drink.Add(f2);
            }
            sr2.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {           
            
            StreamWriter sw = new StreamWriter("outputMeal.txt");
            for (int i = 0; i < meal.Count; i++)
            {
                sw.WriteLine(meal[i].name);
                sw.WriteLine(meal[i].price);
            }
            sw.Close();

            StreamWriter sw2 = new StreamWriter("outputDrink.txt");
            for (int i = 0; i < drink.Count; i++)
            {
                sw2.WriteLine(drink[i].name);
                sw2.WriteLine(drink[i].price);
            }
            sw2.Close();

            Editor edit = new Editor();
            edit.Owner = this;
            edit.ShowDialog();

            read();  
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter("outputMeal.txt");
            for (int i = 0; i < meal.Count; i++)
            {
                sw.WriteLine(meal[i].name);
                sw.WriteLine(meal[i].price);
            }
            sw.Close();

            StreamWriter sw2 = new StreamWriter("outputDrink.txt");
            for (int i = 0; i < drink.Count; i++)
            {
                sw2.WriteLine(drink[i].name);
                sw2.WriteLine(drink[i].price);
            }
            sw2.Close();

            FromSmeta sm = new FromSmeta();
            sm.Owner = this;
            sm.ShowDialog();
            
        }

    }
}
