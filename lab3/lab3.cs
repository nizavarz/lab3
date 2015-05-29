using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Menu : Form
    {
        List<Food> meal;
        List<Food> drink;

        public Menu()
        {
            meal = new List<Food>();
            drink = new List<Food>();           
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
            smeta.RemoveAt(5);
        }


    }
}
