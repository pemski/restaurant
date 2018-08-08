using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        private readonly string HistoryDir = Path.Combine(Application.StartupPath, "order_history");
        private string HistoryPath { get => Path.Combine(HistoryDir, String.Format("history_{0}.xml", DateTime.Today.ToString("yyyyMMdd"))); }


        public FMain()
        {
            InitializeComponent();

            menu = new Menu();
            client = new Client("main client");

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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Błąd składania zamówienia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FinalizeOrder()
        {
            client.Order.Comment = eOrderComment.Text;

            using (FMail fmail = new FMail(client.Order))
            {
                fmail.ShowDialog();
                //added "true" to IF so that testing of history is more comfortable (no need of actually
                //writing credentials, etc.)
                if (true || fmail.DialogResult == DialogResult.OK)
                {
                    IHistoryManagement historyMngt = new HistoryXML(HistoryPath);
                    historyMngt.Save(new HistoryData { Client = client.Name, Date = DateTime.Now }, client.Order);
                    ResetOrder();
                }
            }
        }


        private void bHistory_Click(object sender, EventArgs e)
        {
            using (FHistory fHist = new FHistory(HistoryDir))
                fHist.ShowDialog();
        }


        private void bCancel_Click(object sender, EventArgs e)
        {
            ResetOrder();
        }


        private void ResetOrder()
        {
            client.Order.ResetOrder();
            eOrderComment.Text = client.Order.Comment;
        }
    }
}
