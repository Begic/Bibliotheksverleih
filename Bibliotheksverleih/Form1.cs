using Bibliotheksverleih.Data.DataBase;
using Bibliotheksverleih.Data.Models;

namespace Bibliotheksverleih.UI
{
    public partial class Form1 : Form
    {
        private readonly DbData dbData;
        private readonly InsertConnection insertCon;
        private readonly DeleteConnection deleteCon;

        public Form1()
        {
            InitializeComponent();

            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Bibliothek; Integrated Security=True";

            dbData = new DbData(connectionString);
            insertCon = new InsertConnection(connectionString);
            deleteCon = new DeleteConnection(connectionString);

            SetDataGridSettings();
            LoadAllDataForDataGrid();
        }

        private void SetDataGridSettings()
        {
            dataGridWriter.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadAllDataForDataGrid()
        {
            dataGridWriter.DataSource = dbData.GetAllWriters();
            dataGridGenres.DataSource = dbData.GetAllGenres();
            dataGridStock.DataSource = dbData.GetAllStocks();
        }

        private void btn_AddWriter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text))
            {
                insertCon.AddWriter(txtFirstName.Text, txtLastName.Text);

                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                LoadAllDataForDataGrid();
            }
        }

        private void btn_DeleteWriter_Click(object sender, EventArgs e)
        {
            if (dataGridWriter.SelectedRows.Count > 0)
            {
                var selectedRow = (Writer)dataGridWriter.SelectedRows[0].DataBoundItem;

                if (selectedRow != null)
                {
                    deleteCon.DeleteWriter(selectedRow);
                    LoadAllDataForDataGrid();
                }
            }
        }

        private void btn_AddGenres_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGenres.Text))
            {
                insertCon.AddGenres(txtGenres.Text);

                txtGenres.Text = string.Empty;
                LoadAllDataForDataGrid();
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
                LoadAllDataForDataGrid();
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