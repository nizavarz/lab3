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

        public static List<Food> AddMeal(Food food){
            List<Food> m = new List<Food>();
            m.Add(food);
            return m;
        }
    }
}
