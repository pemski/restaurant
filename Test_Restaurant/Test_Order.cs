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

            order.Remove(new Meal("meal", 1m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);
            order.Remove(new Meal("meal", 1m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 2);
            order.Remove(new Meal("meal2", 5m, MealType.Beverage, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()), 1);

            Assert.True(order.OrderedMeals.Count() == 0);
        }
    }
}
