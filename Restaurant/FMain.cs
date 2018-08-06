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
        private const string Tab = "    ";


        public FMain()
        {
            InitializeComponent();

            menu = new Menu();
            client = new Client();

            client.Order.PropertyChanged += PrintOrder;
        }


        private void PrintOrder(object sender, PropertyChangedEventArgs e)
        {
            lCart.Text = client.Order.ToString().Replace("\t", Tab);
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
                    chooser.BaseMeal = meal.Clone() as Meal;
                    chooser.Dock = DockStyle.Top;
                    pMeals.Controls.Add(chooser);
                }
            }
        }
    }
}
