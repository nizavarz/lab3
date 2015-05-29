using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using lab3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateMenu()
        {
            Menu m = new Menu();
            Assert.IsNotNull(m);
        }

        [TestMethod]
        public void TestAddMeal()
        {
            Menu m = new Menu();
            List<Food> meal = new List<Food>();
            Food f = new Food();
            f.name = "Картофель";
            f.price = 10;
            

            Menu.AddMeal(meal, f);
            

            Assert.AreEqual(meal[0].name, "Картофель");
            Assert.AreEqual(meal[0].price, 10);
            
        }

        [TestMethod]
        public void TestDeleteMeal()
        {
            Menu m = new Menu();
            List<Food> meal = new List<Food>();
            Food f;

            for (int i = 0; i < 10; i++)
            {
                f = new Food();
                f.name = "Картофель" + i;
                f.price = 10 + i;
                Menu.AddMeal(meal, f);

            }

            string name = "Картофель5";          

            Menu.DeleteMeal(meal, name);

            for (int i = 0; i < meal.Count; i++)
            {
                Assert.AreNotEqual(meal[i].name, "Картофель5");
               

            }
            

        }
    }
}
