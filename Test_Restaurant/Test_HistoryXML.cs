using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant;
using NUnit.Framework;
using System.IO;

namespace Test_Restaurant
{
    /// <summary>
    /// Quick, ugly "test"
    /// </summary>
    [TestFixture]
    public class Test_HistoryXML
    {
        private string filePath = @"F:\programming\projects\c#\Restaurant\history_files\historyTest.xml";

        [Test]
        public void Test_SaveHistory()
        {
            Order order = new Order();
            order.Add(new Meal("meal1", 1.10m, MealType.MainCourse, new MainCourseAdditiveFactory(),
                new MeatAdditiveFactory(), new AdditiveHashSet()), 1);
            order.Add(new Meal("meal2", 5m, MealType.MainCourse, new MainCourseAdditiveFactory(),
                new MeatAdditiveFactory(), new AdditiveHashSet()), 2);

            Meal meal = new Meal("meal3", 1500.05m, MealType.MainCourse, new MainCourseAdditiveFactory(),
                new MeatAdditiveFactory(), new AdditiveHashSet());
            meal.SelectedAdditives.Add(new Additive("add31", 10.55m));
            meal.SelectedAdditives.Add(new Additive("add32", 0m));
            order.Add(meal, 3);

            IHistoryManagement historyMngt = new HistoryXML(filePath);
            historyMngt.Save(new HistoryData { Client = "client", Date = DateTime.Now }, order);
        }
    }
}
