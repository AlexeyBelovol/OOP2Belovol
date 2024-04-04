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
            string street = textBoxStreet.Text;
            string city = textBoxCity.Text;
            string postalCode = textBoxPostalCode.Text;
            string country = textBoxCountry.Text;

            postalAddress.SetAddress(street, city, postalCode, country);
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
