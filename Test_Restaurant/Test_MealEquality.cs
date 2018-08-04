using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Restaurant;

namespace Test_Restaurant
{
    /// <summary>
    /// Tests should be ran separately - do not "Run all". To be corrected.
    /// </summary>
    [TestFixture]
    public class Test_MealEquality
    {
        private static object[] IdenticalMealsSource = new object[]
        {
            new object[]
            {
                new Meal("meal", 1m, MealType.MainCourse, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()),
                new Meal("meal", 1m, MealType.MainCourse, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet())
            },
            new object[]
            {
                new Meal("meal", 1m, MealType.MainCourse, new MainCourseAdditiveFactory(), new MeatAdditiveFactory(), new AdditiveHashSet()),
                new Meal("meal", 1m, MealType.MainCourse, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet())
            },
            new object[]
            {
                new Meal("meal", 1m, MealType.MainCourse, new MainCourseAdditiveFactory(), new MeatAdditiveFactory(), new AdditiveHashSet()),
                new Meal("meal", 1m, MealType.MainCourse, new MainCourseAdditiveFactory(), new MeatAdditiveFactory(), new AdditiveHashSet())
            }
        };

        [Test, TestCaseSource("IdenticalMealsSource")]
        public void MealsShouldBeIdentical(Meal meal1, Meal meal2)
        {
            AddSelectedAdditives(meal1);
            AddSelectedAdditives(meal2);

            Assert.True(meal1.Equals(meal2));
        }


        private void AddSelectedAdditives(Meal meal)
        {
            meal.SelectedAdditives.Add(new Additive("add1", 1m, "zł"));
            meal.SelectedAdditives.Add(new Additive("add2", 5m, "zł"));
            meal.SelectedAdditives.Add(new Additive("add3", 5.5m, "eur"));
            meal.SelectedAdditives.Add(new Additive("add1", 1m, "zł"));
        }


        private void AddAlternativeSelectedAdditives(Meal meal)
        {
            meal.SelectedAdditives.Add(new Additive("add1", 10m, "zł"));
            meal.SelectedAdditives.Add(new Additive("add2", 5m, "eur"));
            meal.SelectedAdditives.Add(new Additive("add3", 5m, "eur"));
            meal.SelectedAdditives.Add(new Additive("add1", 1m, "zł"));
        }


        private static object[] DifferentMealsSource = new object[]
        {
            new object[]
            {
                new Meal("meal", 1m, MealType.MainCourse, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()),
                new Meal("other meal", 1m, MealType.MainCourse, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet())
            },
            new object[]
            {
                new Meal("meal", 1.01m, MealType.MainCourse, new MainCourseAdditiveFactory(), new MeatAdditiveFactory(), new AdditiveHashSet()),
                new Meal("meal", 1m, MealType.MainCourse, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet())
            },
            new object[]
            {
                new Meal("meal", 1m, MealType.MainCourse, new MainCourseAdditiveFactory(), new MeatAdditiveFactory(), new AdditiveHashSet()),
                new Meal("meal", 1m, MealType.Soup, new NullAdditiveFactory(), new MeatAdditiveFactory(), new AdditiveHashSet())
            },
            new object[]
            {
                new Meal("meal", 1m, "eur", MealType.Soup, new MainCourseAdditiveFactory(), new MeatAdditiveFactory(), new AdditiveHashSet()),
                new Meal("meal", 1m, "zł", MealType.Soup, new MainCourseAdditiveFactory(), new MeatAdditiveFactory(), new AdditiveHashSet())
            }
        };

        [Test, TestCaseSource("DifferentMealsSource")]
        public void MealsShouldBeDifferent(Meal meal1, Meal meal2)
        {
            AddSelectedAdditives(meal1);
            AddSelectedAdditives(meal2);

            Assert.False(meal1.Equals(meal2));
        }


        [Test, TestCaseSource("IdenticalMealsSource")]
        public void MealsShouldBeDifferentBySelectedAdditives(Meal meal1, Meal meal2)
        {
            AddSelectedAdditives(meal1);
            AddAlternativeSelectedAdditives(meal2);

            Assert.False(meal1.Equals(meal2));
        }


        [Test, TestCaseSource("IdenticalMealsSource")]
        public void MealsShouldBeDifferentBySelectedAdditivesLenght(Meal meal1, Meal meal2)
        {
            meal1.SelectedAdditives.Add(new Additive("add1", 1m));
            meal1.SelectedAdditives.Add(new Additive("add2", 5m));

            meal2.SelectedAdditives.Add(new Additive("add1", 1m));

            Assert.False(meal1.Equals(meal2));
        }
    }
}
