using System.Xml.Serialization;

namespace WinFormsAppStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        public void ClearForm()
        {
            lastnameTextBox.Text = null;
            firstnameTextBox.Text = null;
            rememberCheckBox.Checked = false;
        }

        private void SaveBottun_Click(object sender, EventArgs e)
        {
            string firstName = firstnameTextBox.Text;
            string lastName = firstnameTextBox.Text;
            string IsRememberText = rememberCheckBox.Checked ? "Remembered!" : "Not Remember";
            string result = $"User firstName: {firstName} / User LastName: {lastName}/ {IsRememberText}";
            listBoX.Items.Add(result);
            var items = firstName.ToArray();
            for (int i = 0; i < items.Length; i++)
            {
                speltBox.Items.Add(items[i]);
            }
            MessageBox.Show(result);
            ClearForm();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void speltBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}