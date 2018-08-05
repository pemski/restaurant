using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FMain : Form
    {
        private Menu menu;
        private Client client;


        public FMain()
        {
            InitializeComponent();

            menu = new Menu();
            client = new Client();
        }


        private void FMain_Load(object sender, EventArgs e)
        {
            ShowMeals();
        }


        private void ShowMeals()
        {
            foreach (var mealGroup in menu.Meals.Reverse())
            {
                foreach (var meal in mealGroup.Reverse())
                {
                    var chooser = new MealChooser();
                    chooser.Client = this.client;
                    chooser.Meal = meal.Clone() as Meal;
                    chooser.Dock = DockStyle.Top;
                    pMeals.Controls.Add(chooser);
                }
            }
        }
    }
}
