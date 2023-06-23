using Bibliotheksverleih.Data.DataBase;
using Bibliotheksverleih.Data.Models;

namespace Bibliotheksverleih.UI
{
    public partial class Form1 : Form
    {
        private readonly DbData dbData;
        private readonly InsertConnection insertCon;
        private readonly DeleteConnection deleteCon;

        public int? writerId;
        public int? genreId;
        public int? stockId;

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

        private void btn_NewWriter_Click(object sender, EventArgs e)
        {
            writerId = null;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        private void btn_SaveWriter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text))
            {
                insertCon.AddWriter(new Writer
                {
                    Id = writerId,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                });

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

        private void dataGridWriter_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridWriter.SelectedRows.Count > 0)
            {
                var selectedRow = (Writer)dataGridWriter.SelectedRows[0].DataBoundItem;

                if (selectedRow != null)
                {
                    writerId = selectedRow.Id;
                    txtFirstName.Text = selectedRow.FirstName;
                    txtLastName.Text = selectedRow.LastName;
                }
            }
        }





        private void btn_NewGenres_Click(object sender, EventArgs e)
        {
            genreId = null;
            txtGenres.Text = string.Empty;
        }

        private void btn_SaveGenres_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGenres.Text))
            {
                insertCon.AddGenres(new Genre
                {
                    Id = genreId,
                    GenreName = txtGenres.Text,
                });

                txtGenres.Text = string.Empty;
                LoadAllDataForDataGrid();
            }
        }

        private void btn_DeleteGenres_Click(object? sender, EventArgs e)
        {
            if (dataGridGenres.SelectedRows.Count > 0)
            {
                var selectedRow = (Genre)dataGridGenres.SelectedRows[0].DataBoundItem;

                if (selectedRow != null)
                {
                    deleteCon.DeleteGenre(selectedRow);
                    LoadAllDataForDataGrid();
                }
            }
        }

        private void dataGridGenres_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridGenres.SelectedRows.Count > 0)
            {
                var selectedRow = (Genre)dataGridGenres.SelectedRows[0].DataBoundItem;

                if (selectedRow != null)
                {
                    genreId = selectedRow.Id;
                    txtGenres.Text = selectedRow.GenreName;
                }
            }
        }





        private void btn_NewBook_Click(object sender, EventArgs e)
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
            deleteCon.DeleteBook();
        }

        private void dataGridBook_SelectionChanged(object sender, EventArgs e)
        {
            //TODO
        }





        private void btn_NewStock_Click(object sender, EventArgs e)
        {
            stockId = null;
            txtLevel.Text = string.Empty;
            txtShelve.Text = string.Empty;
            txtPanel.Text = string.Empty;
        }

        private void btn_SaveStock_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLevel.Text) && !string.IsNullOrEmpty(txtShelve.Text) && !string.IsNullOrEmpty(txtLevel.Text))
            {
                insertCon.AddStock(new Stock
                {
                    Id = stockId,
                    Level = Convert.ToInt32(txtLevel.Text),
                    Panel = Convert.ToInt32(txtPanel.Text),
                    Shelve = Convert.ToInt32(txtShelve.Text)
                });

                txtLevel.Text = string.Empty;
                txtShelve.Text = string.Empty;
                txtPanel.Text = string.Empty;
                LoadAllDataForDataGrid();
            }
        }

        private void btn_DeleteStock_Click(object sender, EventArgs e)
        {
            if (dataGridStock.SelectedRows.Count > 0)
            {
                var selectedRow = (Stock)dataGridStock.SelectedRows[0].DataBoundItem;

                if (selectedRow != null)
                {
                    deleteCon.DeleteStock(selectedRow);
                    LoadAllDataForDataGrid();
                }
            }
        }

        private void dataGridStock_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridStock.SelectedRows.Count > 0)
            {
                var selectedRow = (Stock)dataGridStock.SelectedRows[0].DataBoundItem;

                if (selectedRow != null)
                {
                    stockId = selectedRow.Id;
                    txtLevel.Text = selectedRow.Level.ToString();
                    txtShelve.Text = selectedRow.Shelve.ToString();
                    txtPanel.Text = selectedRow.Panel.ToString();
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}