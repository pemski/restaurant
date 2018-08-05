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
        private Meal meal;
        public Meal Meal
        {
            get { return meal; }
            set
            {
                meal = value;
                AddsChooser.Meal = value;
                lName.Text = value.Name;
                lCost.Text = String.Format("{0} {1}", value.Cost, value.Currency);
            }
        }
        public Client Client { get; set; }
        private AdditiveChooser AddsChooser;


        /// <summary>
        /// Control for adding a specified meal for a client. A meal and a client must be specified via 
        /// properties Meal, Client.
        /// </summary>
        public MealChooser()
        {
            InitializeComponent();

            AddsChooser = new AdditiveChooser();
        }


        private void bAdd_Click(object sender, EventArgs e)
        {
            pAdditives.Controls.Add(AddsChooser);
            AddsChooser.Dock = DockStyle.Fill;
            AddsChooser.Show();
        }
    }
}
