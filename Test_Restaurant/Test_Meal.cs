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
    public class Test_Meal
    {
        private Meal meal;

        [SetUp]
        public void Prepare()
        {
            meal = CreateMeal();
        }


        private Meal CreateMeal()
        {
            return new Meal("name1", 1m, "currency1", MealType.MainCourse, new MainCourseAdditiveFactory(),
                new MeatAdditiveFactory(), new AdditiveHashSet());
        }


        [Test]
        public void Test_ToString_NoAdditives()
        {
            string expected = "name1 - 1.00 currency1";
            Assert.AreEqual(expected, meal.ToString());
        }


        [Test]
        public void Test_ToString_WithAdditives()
        {
            meal.SelectedAdditives.Add(new Additive("add1", 1m, "zł"));
            meal.SelectedAdditives.Add(new Additive("add2", 0.5m, "zł"));
            meal.SelectedAdditives.Add(new Additive("add3", 0.01m, "eur"));
            meal.SelectedAdditives.Add(new Additive("add4", 1562m, "zł"));
            meal.SelectedAdditives.Add(new Additive("add5", 0m, "zł"));

            StringBuilder expected = new StringBuilder();
            expected.AppendLine("name1 - 1.00 currency1");
            expected.AppendLine("\t+ add1 - 1.00 zł");
            expected.AppendLine("\t+ add2 - 0.50 zł");
            expected.AppendLine("\t+ add3 - 0.01 eur");
            expected.AppendLine("\t+ add4 - 1,562.00 zł");
            expected.Append("\t+ add5 - 0.00 zł");

            Assert.AreEqual(expected.ToString(), meal.ToString());
        }
    }
}
