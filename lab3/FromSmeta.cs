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
    public partial class FromSmeta : Form
    {

        List<Food> meal;
        List<Food> drink;
        List<Smeta> smeta;

        public FromSmeta()
        {
            InitializeComponent();

            for (int x = 0; x < 3; x++)
            {
                DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn Column1 = new DataGridViewTextBoxColumn();
                dataGridView1.Columns.Add(Column);
            }
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].Width = 220;
            dataGridView1.Columns[1].Width = 86;
            dataGridView1.Columns[2].Width = 86;
            dataGridView1.Columns[0].HeaderText = "Наименование";
            dataGridView1.Columns[1].HeaderText = "Цена";
            dataGridView1.Columns[2].HeaderText = "Количество";


            meal = new List<Food>();
            drink = new List<Food>();
            smeta = new List<Smeta>();
            StreamReader sr = new StreamReader("outputMeal.txt");

            Food f;
            while (!sr.EndOfStream)
            {
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
            Food f2; ;
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

            if(comboBox1.Text != ""){
                string name = comboBox1.Text;
                int num = meal.FindIndex(m => m.name == name);
                Smeta s = new Smeta();
                s.smetaProduct = meal[num];
                s.count = Convert.ToInt32(numericUpDown1.Value);
                smeta.Add(s);

                dataGridView1.Rows.Add(meal[num].name, meal[num].price, numericUpDown1.Value);

                comboBox1.Text = "";
                numericUpDown1.Value = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                string name = comboBox2.Text;
                int num = drink.FindIndex(m => m.name == name);

                Smeta s = new Smeta();
                s.smetaProduct = drink[num];
                s.count = Convert.ToInt32(numericUpDown2.Value);
                smeta.Add(s);

                comboBox2.Text = "";
                dataGridView1.Rows.Add(drink[num].name, drink[num].price, numericUpDown2.Value);
                numericUpDown2.Value = 2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int res = 0;
            for (int i = 0; i < smeta.Count; i++)
            {
                res += smeta[i].smetaProduct.price * smeta[i].count;
            }
            label2.Text = res.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null) {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                smeta.RemoveAt(dataGridView1.CurrentRow.Index);
            
            }
        }
    }
}
