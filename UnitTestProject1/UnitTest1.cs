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
            

            meal = Menu.AddMeal(f);
            

            Assert.AreEqual(meal[0].name, "Картофель");
            Assert.AreEqual(meal[0].price, 10);
            
        }
    }
}
