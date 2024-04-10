using System;
using System.Windows.Forms;

namespace OOP2Belovol
{
    public partial class Form1 : Form
    {
        private PostalAddress postalAddress;

        public Form1()
        {
            InitializeComponent();
            postalAddress = new PostalAddress();
        }

        private void UpdateLabelResult()
        {
            labelResult.Text = postalAddress.ToString();
        }

        private void buttonSetAddress_Click(object sender, EventArgs e)
        {
            postalAddress.Street = textBoxStreet.Text;
            postalAddress.City = textBoxCity.Text;
            postalAddress.PostalCode = textBoxPostalCode.Text;
            postalAddress.Country = textBoxCountry.Text;

            UpdateLabelResult(); // Оновити лейбл після встановлення адреси
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxStreet.Clear();
            textBoxCity.Clear();
            textBoxPostalCode.Clear();
            textBoxCountry.Clear();
            postalAddress.ClearAddress();
            UpdateLabelResult(); // Оновити лейбл після очищення
        }

        private void buttonClearStreet_Click(object sender, EventArgs e)
        {
            postalAddress.ClearStreet();
            textBoxStreet.Clear();
            UpdateLabelResult(); // Оновити лейбл після очищення адреси
        }

        private void buttonClearCity_Click(object sender, EventArgs e)
        {
            postalAddress.ClearCity();
            textBoxCity.Clear();
            UpdateLabelResult(); // Оновити лейбл після очищення міста
        }

        private void buttonClearPostalCode_Click(object sender, EventArgs e)
        {
            postalAddress.ClearPostalCode();
            textBoxPostalCode.Clear();
            UpdateLabelResult(); // Оновити лейбл після очищення поштового індексу
        }

        private void buttonClearCountry_Click(object sender, EventArgs e)
        {
            postalAddress.ClearCountry();
            textBoxCountry.Clear();
            UpdateLabelResult(); // Оновити лейбл після очищення країни
        }
    }
}
