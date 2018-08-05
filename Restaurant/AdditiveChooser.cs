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
    public partial class AdditiveChooser : UserControl
    {
        public Meal Meal { get; set; }
        private Dictionary<Additive, RadioButton> mandatoryAdditives;
        public IEnumerable<KeyValuePair<Additive, RadioButton>> MandatoryAdditives { get { foreach (var add in mandatoryAdditives) yield return add; } }
        private Dictionary<Additive, CheckBox> additives;
        public IEnumerable<KeyValuePair<Additive, CheckBox>> Additives { get { foreach (var add in additives) yield return add; } }


        /// <summary>
        /// Control for specifying additives for the Meal object (must be assigned via property). 
        /// </summary>
        public AdditiveChooser()
        {
            InitializeComponent();

            mandatoryAdditives = new Dictionary<Additive, RadioButton>();
            additives = new Dictionary<Additive, CheckBox>();

            this.VisibleChanged += AdditiveChooser_VisibleChanged;
        }


        private void AdditiveChooser_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            if (Meal == null)
                throw new ArgumentNullException("Meal", "AdditiveChooser.Load: must assign Meal property.");

            LoadMandatoryAdditives();
            LoadAdditives();
        }


        private void LoadMandatoryAdditives()
        {
            foreach (var additive in Meal.AvailableMandatoryAdditives)
            {
                var radio = new RadioButton();
                radio.Text = String.Format("{0} - {1} {2}", additive.Name, additive.Cost, additive.Currency);
                radio.Dock = DockStyle.Bottom;
                pMandatoryAddives.Controls.Add(radio);
                mandatoryAdditives.Add(additive, radio);
            }

            if (mandatoryAdditives.Count > 0)
                mandatoryAdditives.First().Value.Checked = true;
        }


        private void LoadAdditives()
        {
            foreach (var additive in Meal.AvailableAdditives)
            {
                var check = new CheckBox();
                check.Text = String.Format("{0} - {1} {2}", additive.Name, additive.Cost, additive.Currency);
                check.Dock = DockStyle.Bottom;
                pAdditives.Controls.Add(check);
                additives.Add(additive, check);
            }
        }


        private void pMain_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pMandatoryAddives.ClientRectangle,
                Color.Black, 0, ButtonBorderStyle.None,
                Color.Black, 0, ButtonBorderStyle.None,
                Color.Black, 0, ButtonBorderStyle.None,
                Color.Black, 1, ButtonBorderStyle.Solid);

            ControlPaint.DrawBorder(e.Graphics, pMain.ClientRectangle,
                Color.Black, 1, ButtonBorderStyle.Solid,
                Color.Black, 1, ButtonBorderStyle.Solid,
                Color.Black, 0, ButtonBorderStyle.None,
                Color.Black, 0, ButtonBorderStyle.None);
        }


        private void AdditiveChooser_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
                Reset();
        }


        private void Reset()
        {
            if (mandatoryAdditives.Count > 0)
                mandatoryAdditives.First().Value.Checked = true;

            foreach (var check in additives.Values)
                check.Checked = false;
        }
    }
}
