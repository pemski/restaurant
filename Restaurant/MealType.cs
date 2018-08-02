﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public sealed class MealType
    {
        private string description;


        private MealType(string description)
        {
            this.description = description;
        }


        public static readonly MealType Pizza = new MealType("Pizza");
        public static readonly MealType MainCourse = new MealType("Dania główne");
        public static readonly MealType Soup = new MealType("Zupy");
        public static readonly MealType Beverage = new MealType("Napoje");


        public override string ToString()
        {
            return this.description;
        }
    }
}
