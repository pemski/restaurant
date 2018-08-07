using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant;
using NUnit.Framework;

namespace Test_Restaurant
{
    [TestFixture]
    public class Test_Order
    {
        [Test]
        public void ShouldAddOneMeal()
        {
            Order order = new Order();
            order.Add(new Meal("meal", 1m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);
            Assert.True(order.OrderedMeals.Count() == 1);
        }


        [Test]
        public void ShouldAddMultipleMeals()
        {
            Order order = new Order();
            order.Add(new Meal("meal", 1m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);
            order.Add(new Meal("meal", 1m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 2);
            order.Add(new Meal("meal2", 5m, MealType.Beverage, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);
            Assert.True(order.OrderedMeals.Count() == 4);
        }


        [Test]
        public void ShouldRemoveOneMeal()
        {
            Order order = new Order();
            order.Add(new Meal("meal", 1m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);
            order.Remove(new Meal("meal", 1m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);

            Assert.True(order.OrderedMeals.Count() == 0);
        }


        [Test]
        public void ShouldRemoveMultipleMeals()
        {
            Order order = new Order();
            order.Add(new Meal("meal", 1m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);
            order.Add(new Meal("meal", 1m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 2);
            order.Add(new Meal("meal2", 5m, MealType.Beverage, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);

            //order.Remove(new Meal("meal", 1m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);
            order.Remove(new Meal("meal", 1m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 3);
            order.Remove(new Meal("meal2", 5m, MealType.Beverage, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);

            Assert.True(order.OrderedMeals.Count() == 0);
        }


        [Test]
        public void Test_ToString()
        {
            Order order = new Order();
            order.Add(new Meal("meal", 1m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);
            order.Add(new Meal("meal2", 5m, MealType.Beverage, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);
            order.Add(new Meal("meal2", 5m, MealType.Beverage, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);

            var meal = new Meal("meal3", 15.99m, MealType.MainCourse, new MainCourseAdditiveFactory(), new MeatAdditiveFactory(), new AdditiveHashSet());
            meal.SelectedAdditives.Add(new Additive("add31", 10m, "zł"));
            meal.SelectedAdditives.Add(new Additive("add32", 1111.01m, "zł"));
            order.Add(meal, 1);

            meal = new Meal("meal4", 20.0m, MealType.MainCourse, new MainCourseAdditiveFactory(), new MeatAdditiveFactory(), new AdditiveHashSet());
            meal.SelectedAdditives.Add(new Additive("add41", 10m, "zł"));
            meal.SelectedAdditives.Add(new Additive("add42", 0m, "eur"));
            order.Add(meal, 4);

            foreach (int i in Enumerable.Range(0, 2))
            {
                meal = new Meal("meal5", 25.05m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet());
                meal.SelectedAdditives.Add(new Additive("add51", 19.99m, "zł"));
                meal.SelectedAdditives.Add(new Additive("add52", 0m, "eur"));
                order.Add(meal, 1);
            }

            order.Comment = "comment1, please.";

            StringBuilder expected = new StringBuilder();
            expected.AppendLine("(x1) meal - 1.00 zł");
            expected.AppendLine("(x2) meal2 - 5.00 zł");
            expected.AppendLine("(x1) meal3 - 15.99 zł");
            expected.AppendLine("\t+ add31 - 10.00 zł");
            expected.AppendLine("\t+ add32 - 1,111.01 zł");
            expected.AppendLine("(x4) meal4 - 20.00 zł");
            expected.AppendLine("\t+ add41 - 10.00 zł");
            expected.AppendLine("\t+ add42 - 0.00 eur");
            expected.AppendLine("(x2) meal5 - 25.05 zł");
            expected.AppendLine("\t+ add51 - 19.99 zł");
            expected.AppendLine("\t+ add52 - 0.00 eur");
            expected.AppendFormat("Uwagi: {0}", "comment1, please.");

            Assert.AreEqual(expected.ToString(), order.ToString());
        }
    }
}
