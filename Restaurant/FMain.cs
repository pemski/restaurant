using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            client.Order.PropertyChanged += UpdateOrder;
        }


        private void UpdateOrder(object sender, PropertyChangedEventArgs e)
        {
            PrintOrder();
        }

        private void PrintOrder()
        {
            lCart.Text = client.Order.ToString().Replace("\t", Tab);

            if (client.Order.OrderedMeals.Count() == 0)
            {
                decimal zeroCost = 0m;
                lSummary.Text = String.Format("Razem: {0} zł", zeroCost.PrintCost());
            }
            else
            {
                decimal sumCost = client.Order.OrderedMeals.Sum(r => r.Cost) + client.Order.OrderedMeals.SelectMany(r => r.SelectedAdditives.Additives).Sum(r => r.Cost);
                string currency = client.Order.OrderedMeals.First().Currency;
                lSummary.Text = String.Format("Razem: {0} {1}", sumCost.PrintCost(), currency);
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            ShowMeals();
            PrintOrder();
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


        private void bOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (client.Order.OrderedMeals.Count() > 0)
                    FinalizeOrder();
                else
                    MessageBox.Show("Nic nie dodano do zamówienia!", "Puste zamówienie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Błąd składania zamówienia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FinalizeOrder()
        {
            using (FMail fmail = new FMail(client.Order))
            {
                fmail.ShowDialog();
                if (fmail.DialogResult == DialogResult.OK)
                    client.Order.ResetOrder();
            }
        }
    }
}
