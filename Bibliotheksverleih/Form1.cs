using Bibliotheksverleih.Data;
using Microsoft.IdentityModel.Tokens;

namespace Bibliotheksverleih.UI
{
    public partial class Form1 : Form
    {
        private readonly InsertConnection insertCon;
        private readonly DeleteConnection deleteCon;

        public Form1()
        {
            InitializeComponent();

            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Bibliothek; Integrated Security=True";

            insertCon = new InsertConnection(connectionString);
            deleteCon = new DeleteConnection(connectionString);
        }

        private void btn_AddWriter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text))
            {
                insertCon.AddWriter(txtFirstName.Text, txtLastName.Text);

                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
            }
        }

        private void btn_DeleteWriter_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btn_AddGenres_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGenres.Text))
            {
                insertCon.AddGenres(txtGenres.Text);

                txtGenres.Text = string.Empty;
            }
        }

        private void btn_DeleteGenres_Click(object? sender, EventArgs e)
        {
            //TODO
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            //TODO Last
            if (true)
            {
                insertCon.AddBook();
            }
        }

        private void btn_DeleteBook_Click(object sender, EventArgs e)
        {
            //TODO
        }


        private void btn_AddStock_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLevel.Text) && !string.IsNullOrEmpty(txtShelve.Text) && !string.IsNullOrEmpty(txtLevel.Text))
            {
                insertCon.AddStock(txtLevel.Text, txtShelve.Text, txtPanel.Text);

                txtLevel.Text = string.Empty;
                txtShelve.Text = string.Empty;
                txtPanel.Text = string.Empty;
            }
        }

        private void btn_DeleteStock_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}