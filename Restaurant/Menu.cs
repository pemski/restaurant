using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Menu
    {
        public ILookup<MealType, Meal> Meals { get; }


        public Menu()
        {
            List<Meal> meals = new List<Meal>
            {
                new Meal("Margheritta", 20m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()),
                new Meal("Vegetariana", 22m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()),
                new Meal("Tosca", 25m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()),
                new Meal("Venecia", 25m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()),

                new Meal("Schabowy z frytkami/ryżem/ziemniakami", 30m, MealType.MainCourse, new MainCourseAdditiveFactory(), new MeatAdditiveFactory(), new AdditiveHashSet()),
                new Meal("Ryba z frytkami", 28m, MealType.MainCourse, new MainCourseAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()),
                new Meal("Placek po węgiersku", 27m, MealType.MainCourse, new MainCourseAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()),

                new Meal("Pomidorowa", 12m, MealType.Soup, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()),
                new Meal("Rosół", 10m, MealType.Soup, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()),

                new Meal("Kawa", 5m, MealType.Beverage, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()),
                new Meal("Herbata", 5m, MealType.Beverage, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet()),
                new Meal("Cola", 5m, MealType.Beverage, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet())
            };

            Meals = CreateMeals().ToLookup<Meal, MealType>(r => r.Type);
        }


        private IEnumerable<Meal> CreateMeals()
        {
            yield return new Meal("Margheritta", 20m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet());
            yield return new Meal("Vegetariana", 22m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet());
            yield return new Meal("Tosca", 25m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet());
            yield return new Meal("Venecia", 25m, MealType.Pizza, new PizzaAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet());

            yield return new Meal("Schabowy z frytkami/ryżem/ziemniakami", 30m, MealType.MainCourse, new MainCourseAdditiveFactory(), new MeatAdditiveFactory(), new AdditiveHashSet());
            yield return new Meal("Ryba z frytkami", 28m, MealType.MainCourse, new MainCourseAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet());
            yield return new Meal("Placek po węgiersku", 27m, MealType.MainCourse, new MainCourseAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet());

            yield return new Meal("Pomidorowa", 12m, MealType.Soup, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet());
            yield return new Meal("Rosół", 10m, MealType.Soup, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet());

            yield return new Meal("Kawa", 5m, MealType.Beverage, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet());
            yield return new Meal("Herbata", 5m, MealType.Beverage, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet());
            yield return new Meal("Cola", 5m, MealType.Beverage, new NullAdditiveFactory(), new NullAdditiveFactory(), new AdditiveHashSet());
        }
    }
}