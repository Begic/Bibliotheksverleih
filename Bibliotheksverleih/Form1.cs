using Bibliotheksverleih.Data;

namespace Bibliotheksverleih.UI
{
    public partial class Form1 : Form
    {
        private readonly Connection conn;

        public Form1()
        {
            InitializeComponent();

            conn = new Connection();
        }

        private void btn_AddWriter_Click(object sender, EventArgs e)
        {
            conn.AddWriter(txtFirstName.Text, txtLastName.Text);

            EmptyTextBoxes();
        }

        public void EmptyTextBoxes()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }
    }
}