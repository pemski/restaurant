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
                meal = value ?? throw new ArgumentNullException("MealChooser.Meal: cannot assign null to the property.");
                additiveChooser.Meal = value;
                lName.Text = value.Name;
                lCost.Text = String.Format("{0} {1}", value.Cost, value.Currency);
            }
        }
        public Client Client { get; set; }
        private AdditiveChooser additiveChooser;


        /// <summary>
        /// Control for adding a specified meal for a client. A meal and a client must be specified via 
        /// properties Meal, Client.
        /// </summary>
        public MealChooser()
        {
            InitializeComponent();

            additiveChooser = new AdditiveChooser();
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
            bExpandAdditives.Text = additiveChooser.Visible ? "^" : "v"; //wish for sth more aesthetic
        }


        private void bAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
