using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class MealChooser : UserControl
    {
        private Meal baseMeal;
        public Meal BaseMeal
        {
            get { return baseMeal; }
            set
            {
                baseMeal = value;
                ResetOrderedMeal();
            }
        }


        private Meal orderedMeal;
        public Meal OrderedMeal
        {
            get { return orderedMeal; }
            private set
            {
                orderedMeal = value ?? throw new ArgumentNullException("MealChooser.OrderedMeal: cannot assign null to the property.");
                additiveChooser.Meal = value;
                lName.Text = value.Name;
                lCost.Text = String.Format("{0} {1}", value.Cost, value.Currency);
            }
        }
        public Client Client { get; set; }
        private AdditiveChooser additiveChooser;


        /// <summary>
        /// Control for adding a specified meal for a client. A client must be assigned to Client property.
        /// BaseMeal is a default-state meal of the chooser and must be assigned. OrderedMeal is
        /// a meal with additives that the client orders.
        /// </summary>
        public MealChooser()
        {
            InitializeComponent();

            additiveChooser = new AdditiveChooser();
            additiveChooser.VisibleChanged += AdditiveChooser_VisibleChanged;
        }


        private void AdditiveChooser_VisibleChanged(object sender, EventArgs e)
        {
            SetExpandSymbol();
        }


        private void MealChooser_Load(object sender, EventArgs e)
        {
            pAdditives.Controls.Add(additiveChooser);
            additiveChooser.Dock = DockStyle.Fill;
            additiveChooser.Visible = false;
        }


        private void bExpandAdditives_Click(object sender, EventArgs e)
        {
            additiveChooser.Visible = !additiveChooser.Visible;
        }


        private void SetExpandSymbol()
        {
            bExpandAdditives.Text = additiveChooser.Visible ? "^" : "v"; //wish for sth more aesthetic
        }


        private void bAdd_Click(object sender, EventArgs e)
        {
            AddAdditivesToOrderedMeal();
            PlaceOrder();

            additiveChooser.Visible = false;
            ResetQuantity();
            ResetOrderedMeal();
        }


        private void AddAdditivesToOrderedMeal()
        {
            foreach (var additive in additiveChooser.MandatoryAdditives.Where(k => k.Value.Checked == true))
                OrderedMeal.SelectedAdditives.Add(additive.Key);

            foreach (var additive in additiveChooser.Additives.Where(k => k.Value.Checked == true))
                OrderedMeal.SelectedAdditives.Add(additive.Key);
        }


        private void PlaceOrder()
        {
            this.Client.Order.Add(OrderedMeal, (int)eQuantity.Value);
        }


        private void ResetQuantity()
        {
            eQuantity.Value = 1;
        }


        private void ResetOrderedMeal()
        {
            OrderedMeal = BaseMeal.Clone() as Meal;
        }
    }
}
