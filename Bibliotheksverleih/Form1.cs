using Bibliotheksverleih.Data;

namespace Bibliotheksverleih.UI
{
    public partial class Form1 : Form
    {
        private readonly InsertDbData insertCon;
        private readonly DeleteDbData deleteCon;

        public Form1()
        {
            InitializeComponent();

            insertCon = new InsertDbData();
            deleteCon = new DeleteDbData();
        }

        private void btn_AddWriter_Click(object sender, EventArgs e)
        {
            insertCon.AddWriter(txtFirstName.Text, txtLastName.Text);


            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        private void btn_DeleteWriter_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddGenres_Click(object sender, EventArgs e)
        {
            insertCon.AddGenres(txtGenres.Text);

            txtGenres.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            insertCon.AddBook();
        }

        private void btn_DeleteBook_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }
    }
}