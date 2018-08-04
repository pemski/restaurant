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
    public class Test_MealCloning
    {
        private const string Name = "meal1";
        private const decimal Cost = 10m;
        private const string Currency = "zł";
        private readonly MealType Type = MealType.MainCourse;

        [Test]
        public void MealShouldBeCloned()
        {
            Meal meal = new Meal(Name, Cost, Currency, Type, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet());
            Meal clone = meal.Clone() as Meal;

            Assert.True(meal.Equals(clone));
        }


        [Test]
        public void MealShouldBeClonedWithAdditives()
        {
            Meal meal = new Meal(Name, Cost, Currency, Type, new MainCourseAdditiveFactory(), new MeatAdditiveFactory(), new AdditiveHashSet());
            meal.SelectedAdditives.Add(new Additive("add1", 10m, "zł"));
            meal.SelectedAdditives.Add(new Additive("add2", 1m, "zł"));
            Meal clone = meal.Clone() as Meal;

            Assert.True(meal.Equals(clone));
        }
    }
}
