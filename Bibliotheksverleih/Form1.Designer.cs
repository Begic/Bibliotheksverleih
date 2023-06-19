namespace Bibliotheksverleih.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_DeleteGenres = new TabControl();
            tabPage4 = new TabPage();
            btn_Search = new Button();
            label9 = new Label();
            textBox2 = new TextBox();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            dataGridWriter = new DataGridView();
            label8 = new Label();
            btn_DeleteWriter = new Button();
            btn_AddWriter = new Button();
            label2 = new Label();
            label1 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            tapPage2 = new TabPage();
            panel3 = new Panel();
            dataGridGenres = new DataGridView();
            button1 = new Button();
            btn_AddGenres = new Button();
            label4 = new Label();
            txtGenres = new TextBox();
            tabPage3 = new TabPage();
            panel4 = new Panel();
            dataGridBook = new DataGridView();
            btn_DeleteBook = new Button();
            label3 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            btn_AddBook = new Button();
            label5 = new Label();
            label6 = new Label();
            txtTitel = new TextBox();
            txtISBN = new TextBox();
            panel1.SuspendLayout();
            btn_DeleteGenres.SuspendLayout();
            tabPage4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridWriter).BeginInit();
            tapPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridGenres).BeginInit();
            tabPage3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBook).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_DeleteGenres);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 623);
            panel1.TabIndex = 1;
            // 
            // btn_DeleteGenres
            // 
            btn_DeleteGenres.Controls.Add(tabPage4);
            btn_DeleteGenres.Controls.Add(tabPage1);
            btn_DeleteGenres.Controls.Add(tapPage2);
            btn_DeleteGenres.Controls.Add(tabPage3);
            btn_DeleteGenres.Dock = DockStyle.Fill;
            btn_DeleteGenres.Location = new Point(0, 0);
            btn_DeleteGenres.Name = "btn_DeleteGenres";
            btn_DeleteGenres.SelectedIndex = 0;
            btn_DeleteGenres.Size = new Size(842, 623);
            btn_DeleteGenres.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btn_Search);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(textBox2);
            tabPage4.Controls.Add(panel5);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(834, 590);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Übersicht";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(706, 13);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(120, 29);
            btn_Search.TabIndex = 3;
            btn_Search.Text = "Suchen";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 17);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 2;
            label9.Text = "Suche:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(635, 27);
            textBox2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(0, 48);
            panel5.Name = "panel5";
            panel5.Size = new Size(834, 542);
            panel5.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(834, 542);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btn_DeleteWriter);
            tabPage1.Controls.Add(btn_AddWriter);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtLastName);
            tabPage1.Controls.Add(txtFirstName);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(834, 590);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Autoren";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridWriter);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 430);
            panel2.TabIndex = 8;
            // 
            // dataGridWriter
            // 
            dataGridWriter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridWriter.Dock = DockStyle.Fill;
            dataGridWriter.Location = new Point(0, 0);
            dataGridWriter.Name = "dataGridWriter";
            dataGridWriter.RowHeadersWidth = 51;
            dataGridWriter.RowTemplate.Height = 29;
            dataGridWriter.Size = new Size(834, 430);
            dataGridWriter.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 433);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 7;
            label8.Text = "Nachname";
            // 
            // btn_DeleteWriter
            // 
            btn_DeleteWriter.Location = new Point(426, 553);
            btn_DeleteWriter.Name = "btn_DeleteWriter";
            btn_DeleteWriter.Size = new Size(400, 29);
            btn_DeleteWriter.TabIndex = 5;
            btn_DeleteWriter.Text = "Löschen";
            btn_DeleteWriter.UseVisualStyleBackColor = true;
            btn_DeleteWriter.Click += btn_DeleteWriter_Click;
            // 
            // btn_AddWriter
            // 
            btn_AddWriter.Location = new Point(8, 553);
            btn_AddWriter.Name = "btn_AddWriter";
            btn_AddWriter.Size = new Size(400, 29);
            btn_AddWriter.TabIndex = 4;
            btn_AddWriter.Text = "Hinzufügen/Bearbeiten";
            btn_AddWriter.UseVisualStyleBackColor = true;
            btn_AddWriter.Click += btn_AddWriter_Click;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 433);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 2;
            label1.Text = "Vorname";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(426, 456);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(400, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(8, 456);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(400, 27);
            txtFirstName.TabIndex = 0;
            // 
            // tapPage2
            // 
            tapPage2.Controls.Add(panel3);
            tapPage2.Controls.Add(button1);
            tapPage2.Controls.Add(btn_AddGenres);
            tapPage2.Controls.Add(label4);
            tapPage2.Controls.Add(txtGenres);
            tapPage2.Location = new Point(4, 29);
            tapPage2.Name = "tapPage2";
            tapPage2.Padding = new Padding(3);
            tapPage2.Size = new Size(834, 590);
            tapPage2.TabIndex = 1;
            tapPage2.Text = "Genres";
            tapPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridGenres);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(834, 430);
            panel3.TabIndex = 10;
            // 
            // dataGridGenres
            // 
            dataGridGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGenres.Dock = DockStyle.Fill;
            dataGridGenres.Location = new Point(0, 0);
            dataGridGenres.Name = "dataGridGenres";
            dataGridGenres.RowHeadersWidth = 51;
            dataGridGenres.RowTemplate.Height = 29;
            dataGridGenres.Size = new Size(834, 430);
            dataGridGenres.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(426, 553);
            button1.Name = "button1";
            button1.Size = new Size(400, 29);
            button1.TabIndex = 9;
            button1.Text = "Löschen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_AddGenres
            // 
            btn_AddGenres.Location = new Point(8, 553);
            btn_AddGenres.Name = "btn_AddGenres";
            btn_AddGenres.Size = new Size(400, 29);
            btn_AddGenres.TabIndex = 8;
            btn_AddGenres.Text = "Hinzufügen/Bearbeiten";
            btn_AddGenres.UseVisualStyleBackColor = true;
            btn_AddGenres.Click += btn_AddGenres_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 433);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 7;
            label4.Text = "Art";
            // 
            // txtGenres
            // 
            txtGenres.Location = new Point(8, 456);
            txtGenres.Name = "txtGenres";
            txtGenres.Size = new Size(400, 27);
            txtGenres.TabIndex = 5;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel4);
            tabPage3.Controls.Add(btn_DeleteBook);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(btn_AddBook);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(txtTitel);
            tabPage3.Controls.Add(txtISBN);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(834, 590);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Bücher";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridBook);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(834, 430);
            panel4.TabIndex = 15;
            // 
            // dataGridBook
            // 
            dataGridBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBook.Dock = DockStyle.Fill;
            dataGridBook.Location = new Point(0, 0);
            dataGridBook.Name = "dataGridBook";
            dataGridBook.RowHeadersWidth = 51;
            dataGridBook.RowTemplate.Height = 29;
            dataGridBook.Size = new Size(834, 430);
            dataGridBook.TabIndex = 1;
            // 
            // btn_DeleteBook
            // 
            btn_DeleteBook.Location = new Point(426, 553);
            btn_DeleteBook.Name = "btn_DeleteBook";
            btn_DeleteBook.Size = new Size(400, 29);
            btn_DeleteBook.TabIndex = 14;
            btn_DeleteBook.Text = "Löschen";
            btn_DeleteBook.UseVisualStyleBackColor = true;
            btn_DeleteBook.Click += btn_DeleteBook_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 486);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 13;
            label3.Text = "StockId";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 486);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 12;
            label7.Text = "BYear";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(426, 509);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(8, 509);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(400, 27);
            textBox4.TabIndex = 10;
            // 
            // btn_AddBook
            // 
            btn_AddBook.Location = new Point(8, 553);
            btn_AddBook.Name = "btn_AddBook";
            btn_AddBook.Size = new Size(400, 29);
            btn_AddBook.TabIndex = 9;
            btn_AddBook.Text = "Hinzufügen/Bearbeiten";
            btn_AddBook.UseVisualStyleBackColor = true;
            btn_AddBook.Click += btn_AddBook_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 433);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 8;
            label5.Text = "Titel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 433);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 7;
            label6.Text = "ISBN";
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(426, 456);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(400, 27);
            txtTitel.TabIndex = 6;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(8, 456);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(400, 27);
            txtISBN.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 623);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bibliotheksverleih ";
            panel1.ResumeLayout(false);
            btn_DeleteGenres.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridWriter).EndInit();
            tapPage2.ResumeLayout(false);
            tapPage2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridGenres).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridBook).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TabControl btn_DeleteGenres;
        private TabPage tabPage1;
        private TabPage tapPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label1;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btn_AddWriter;
        private Button btn_DeleteWriter;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox txtGenres;
        private Button btn_AddGenres;
        private Button btn_AddBook;
        private Label label5;
        private Label label6;
        private TextBox txtTitel;
        private TextBox txtISBN;
        private Label label7;
        private TextBox textBox4;
        private TabPage tabPage4;
        private Button button1;
        private Button btn_DeleteBook;
        private Label label8;
        private Panel panel2;
        private DataGridView dataGridWriter;
        private Panel panel3;
        private DataGridView dataGridGenres;
        private Panel panel4;
        private DataGridView dataGridBook;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Button btn_Search;
        private Label label9;
        private TextBox textBox2;
    }
}