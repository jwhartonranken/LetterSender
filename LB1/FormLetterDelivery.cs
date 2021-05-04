using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class FormLetterDelivery : Form
    {
        const int TOTALELEMENTS = 10;

        List<Letter> letter = new List<Letter>(TOTALELEMENTS);
        List<CertifiedLetter> certifiedLetter = new List<CertifiedLetter>(TOTALELEMENTS);
        string[] sentLetters = new string[TOTALELEMENTS];
        int numElements = 0;

        public FormLetterDelivery()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            bool keepGoing = ValidateRecipient();

            if (keepGoing)
            {
                keepGoing = ValidateDate();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = ValidateTrackingNumber();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                InstantiateACertifiedLetter();
            }
            else
            {
                InstantiateANonCertifiedLetter();
            }

            DisplayArrayContents();
        }

        private void InstantiateACertifiedLetter()
        {
            if (numElements < TOTALELEMENTS)
            {
                CertifiedLetter cl = new CertifiedLetter(
                                    textBoxRecipient.Text,
                                    Convert.ToDateTime(textBoxSentDate.Text),
                                    textBoxTrackingNumber.Text);
                certifiedLetter.Add(cl);
                textBoxLetterHistory.Text += cl.ToString() + "\r\n";
                sentLetters = textBoxLetterHistory.Text.Split('\n');
                labelAdditionalFee.Visible = true;
                numElements++;
            }
            else
            {
                MessageBox.Show("Can't Add Any More Elements. List is already Full!",
                                "TOO MANY ELEMENTS",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void InstantiateANonCertifiedLetter()
        {
            if (numElements < TOTALELEMENTS)
            {
                Letter l = new Letter(
                                        textBoxRecipient.Text,
                                        Convert.ToDateTime(textBoxSentDate.Text));
                letter.Add(l);

                labelAdditionalFee.Visible = false;

                textBoxLetterHistory.Text += l.ToString() + "\r\n";
                sentLetters = textBoxLetterHistory.Text.Split('\n');
                numElements++;
            }
        }

        private bool ValidateRecipient()
        {
            if (textBoxRecipient.Text == "")
            {
                MessageBox.Show("Recipient Name Cannot Be Empty.",
                                "EMPTY NAME ENTERED",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                textBoxRecipient.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateDate()
        {
            try
            {
                DateTime.Parse(textBoxSentDate.Text.Trim());
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Invalidly Constructed Date Format" + e.Message,
                                "ILLEGAL DATE INPUT",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                textBoxSentDate.Text = "";
                textBoxSentDate.Focus();
                return false;
            }
        }

        private bool ValidateTrackingNumber()
        {
            if (textBoxTrackingNumber.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRecipient.Text = "";
            textBoxSentDate.Text = "";
            textBoxTrackingNumber.Text = "";
            labelAdditionalFee.Visible = false;
            textBoxRecipient.Focus();
        }

        private void FormLetterDelivery_Load(object sender, EventArgs e)
        {
            Letter l1 = new Letter("Mom", Convert.ToDateTime("03/23/2021"));
            textBoxLetterHistory.Text += l1 + "\r\n";
            sentLetters[0] = textBoxLetterHistory.Text;
            numElements++;

            Letter l2 = new Letter("Dad", Convert.ToDateTime("03/23/2021"));
            textBoxLetterHistory.Text += l2 + "\r\n";
            sentLetters[1] = textBoxLetterHistory.Text;
            numElements++;

            CertifiedLetter cl1 = new CertifiedLetter(
                                    "Spectrum",
                                    Convert.ToDateTime("3/24/2021"),
                                    "123");
            textBoxLetterHistory.Text += cl1 + "\r\n";
            sentLetters[2] = textBoxLetterHistory.Text;
            numElements++;

            CertifiedLetter cl2 = new CertifiedLetter(
                                    "Netflix",
                                    Convert.ToDateTime("3/24/2021"),
                                    "456");
            textBoxLetterHistory.Text += cl2 + "\r\n";
            sentLetters[3] = textBoxLetterHistory.Text;
            numElements++;

            DisplayArrayContents();
        }

        private void DisplayArrayContents()
        {
            string str = "";
            int len = sentLetters.Length - 1;
            for (int lcv = 0; lcv <= len; ++lcv)
            {
                str += "sentLetters[" + lcv.ToString() + "]: " +
                        sentLetters[lcv] + "\r\n";
            }

            MessageBox.Show("Contents of Array SentLetters:\n" + str,
                            "Array Contents",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
