using Bibliotheksverleih.Data;

namespace Bibliotheksverleih.UI
{
    public partial class Form1 : Form
    {
        private readonly InsertDbData conn;

        public Form1()
        {
            InitializeComponent();

            conn = new InsertDbData();
        }

        private void btn_AddWriter_Click(object sender, EventArgs e)
        {
            conn.AddWriter(txtFirstName.Text, txtLastName.Text);

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        private void btn_DeleteWriter_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddGenres_Click(object sender, EventArgs e)
        {
            conn.AddGenres(txtGenres.Text);

            txtGenres.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            conn.AddBook();
        }

        private void btn_DeleteBook_Click(object sender, EventArgs e)
        {

        }
    }
}