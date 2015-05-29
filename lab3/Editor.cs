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
    public partial class Editor : Form
    {

        List<Food> meal;
        List<Food> drink;
        public Editor()
        {

            InitializeComponent();

            meal = new List<Food>();
            drink = new List<Food>();
            StreamReader sr = new StreamReader("outputMeal.txt");

            Food f;
            while (!sr.EndOfStream){
                f = new Food();
                f.name = sr.ReadLine();
                f.price = Convert.ToInt32(sr.ReadLine());
                meal.Add(f);
            }
            sr.Close();

            comboBox1.Items.Clear();
            comboBox1.Text = "";            
            for (int i = 0; i < meal.Count; i++)
            {
                comboBox1.Items.Add(meal[i].name);
            }

            StreamReader sr2 = new StreamReader("outputDrink.txt");
            Food f2;;
            drink.Clear();
            while (!sr2.EndOfStream)
            {
                f2 = new Food();
                f2.name = sr2.ReadLine();
                f2.price = Convert.ToInt32(sr2.ReadLine());
                drink.Add(f2);
            }
            sr2.Close();

            comboBox2.Items.Clear();
            comboBox2.Text = "";
            for (int i = 0; i < drink.Count; i++)
            {
                comboBox2.Items.Add(drink[i].name);
            }
            
        }

        private void addMeal_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != ""){
                Food f = new Food();
                f.name = textBox1.Text;
                f.price = Convert.ToInt32(numericUpDown1.Value);
                meal.Add(f);
            }

            comboBox1.Items.Clear();
            comboBox1.Text = "";
            for (int i = 0; i < meal.Count; i++) {
                comboBox1.Items.Add(meal[i].name);
                
            }

            textBox1.Text = "";
            numericUpDown1.Value = 0;
        }

        private void deleteMeat_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                string name = comboBox1.Text;
                meal.RemoveAt(meal.FindIndex(m => m.name == name));

                comboBox1.Items.Clear();
                comboBox1.Text = "";
                for (int i = 0; i < meal.Count; i++)
                {
                    comboBox1.Items.Add(meal[i].name);
                }
            }
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e)
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
        }

        private void addDrink_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Food f = new Food();
                f.name = textBox2.Text;
                f.price = Convert.ToInt32(numericUpDown2.Value);
                drink.Add(f);
            }

            comboBox2.Items.Clear();
            comboBox2.Text = "";
            for (int i = 0; i < drink.Count; i++)
            {
                comboBox2.Items.Add(drink[i].name);

            }

            textBox2.Text = "";
            numericUpDown2.Value = 0;
        }

        private void deleteDrink_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                string name = comboBox2.Text;
                drink.RemoveAt(drink.FindIndex(m => m.name == name));

                comboBox2.Items.Clear();
                comboBox2.Text = "";
                for (int i = 0; i < drink.Count; i++)
                {
                    comboBox2.Items.Add(drink[i].name);
                }
            }
        }
                
    }
}
