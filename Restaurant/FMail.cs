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
    public partial class FMail : Form
    {
        private MailUtil mailUtil;
        public Order OrderToSend { get; }


        public FMail(Order order)
        {
            if (order == null)
                throw new ArgumentNullException("order", "FMail");

            InitializeComponent();
            this.mailUtil = new MailUtil();
            this.OrderToSend = order;
        }


        private void bSend_Click(object sender, EventArgs e)
        {
            try
            {
                /*wysyłając z gmail'a, należy w ustawieniach konta zezwolić na logowanie
                  z mniej bezpiecznych aplikacji*/
                mailUtil.SendMail(eSender.Text, ePassword.Text, eReceiver.Text, eSmtp.Text,
                    (int)ePort.Value, rbSSLOn.Checked, OrderToSend);

                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Wysłano zamówienie.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Błąd wysyłki zamówienia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
