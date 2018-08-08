using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Restaurant
{
    public partial class FMail : Form
    {
        private MailUtil mailUtil;
        public Order OrderToSend { get; }
        private string mailConfigPath;


        public FMail(Order order)
        {
            if (order == null)
                throw new ArgumentNullException("order", "FMail");

            InitializeComponent();
            this.mailConfigPath = Path.Combine(Application.StartupPath, "mail-config.xml");
            this.mailUtil = new MailUtil();
            this.OrderToSend = order;
        }


        private void FMail_Load(object sender, EventArgs e)
        {
            LoadMailConfig();
        }


        private void LoadMailConfig()
        {
            MailInfo info = mailUtil.DeserializeMailInfo(mailConfigPath);
            eSender.Text = info.Sender;
            eReceiver.Text = info.Receiver;
            eSmtp.Text = info.Smtp;
            ePort.Value = info.Port;
            if (info.SSL)
                rbSSLOn.Checked = true;
            else
                rbSSLOff.Checked = true;
        }


        private void bSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailInfo info = new MailInfo
                {
                    Sender = eSender.Text,
                    Password = ePassword.Text,
                    Receiver = eReceiver.Text,
                    Smtp = eSmtp.Text,
                    Port = (int)ePort.Value,
                    SSL = rbSSLOn.Checked
                };
                mailUtil.SerializeMailInfo(info, mailConfigPath);

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
