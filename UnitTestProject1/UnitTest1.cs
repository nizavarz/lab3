﻿using System;
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

        [TestMethod]
        public void TestAddSmetaProduct()
        {
            Menu m = new Menu();
            Smeta s;
            Food f;
            List<Smeta> smeta1 = new List<Smeta>();

            s = new Smeta();
            f = new Food();
            f.name = "Картофель";
            f.price = 10;
            s.smetaProduct = f;
            s.count = 2;
            Menu.AddSmetaProduct(smeta1, s);

            Assert.AreEqual(smeta1[0].smetaProduct, f);
            Assert.AreEqual(smeta1[0].count, 2);


        }

        [TestMethod]
        public void TestDeleteSmetaProduct()
        {
            Menu m = new Menu();
            Smeta s;
            Food f;
            List<Smeta> smeta1 = new List<Smeta>();


            for (int i = 0; i < 10; i++)
            {
                s = new Smeta();
                f = new Food();
                f.name = "Картофель" + i;
                f.price = 10 + i;
                s.smetaProduct = f;
                s.count = i;
                Menu.AddSmetaProduct(smeta1, s);

            }
            
            string name = "Картофель5";

            Menu.DeleteSmetaProduct(smeta1, name);

            for (int i = 0; i < smeta1.Count; i++)
            {
                Assert.AreNotEqual(smeta1[i].smetaProduct.name, "Картофель5");
            }      
        }

        [TestMethod]
        public void TestCalculate()
        {
            Menu m = new Menu();
            Smeta s;
            Food f;
            List<Smeta> smeta1 = new List<Smeta>();


            for (int i = 0; i < 10; i++)
            {
                s = new Smeta();
                f = new Food();
                f.name = "Картофель" + i;
                f.price = 10 + i + 1;
                s.smetaProduct = f;
                s.count = i + 1;
                Menu.AddSmetaProduct(smeta1, s);

            }

            int res = Menu.Calculate(smeta1);
                  
            Assert.AreEqual(res, 935);
            
        }


    }
}
