﻿namespace Bibliotheksverleih.UI
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
            txtSearch = new TextBox();
            panel5 = new Panel();
            dataGridOverview = new DataGridView();
            tabPage1 = new TabPage();
            btn_NewWriter = new Button();
            panel2 = new Panel();
            dataGridWriter = new DataGridView();
            label8 = new Label();
            btn_DeleteWriter = new Button();
            btn_SaveWriter = new Button();
            label2 = new Label();
            label1 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            tapPage2 = new TabPage();
            btn_NewGenres = new Button();
            panel3 = new Panel();
            dataGridGenres = new DataGridView();
            btn_DeleteGen = new Button();
            btn_SaveGenres = new Button();
            label4 = new Label();
            txtGenres = new TextBox();
            tabPage5 = new TabPage();
            btn_NewStock = new Button();
            label12 = new Label();
            txtPanel = new TextBox();
            label11 = new Label();
            txtShelve = new TextBox();
            label10 = new Label();
            txtLevel = new TextBox();
            btn_DeleteStock = new Button();
            btn_SaveStock = new Button();
            panel6 = new Panel();
            dataGridStock = new DataGridView();
            tabPage3 = new TabPage();
            label15 = new Label();
            label16 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btn_NewBook = new Button();
            panel4 = new Panel();
            dataGridBook = new DataGridView();
            btn_DeleteBook = new Button();
            label3 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            btn_SaveBook = new Button();
            label5 = new Label();
            label6 = new Label();
            txtTitel = new TextBox();
            txtISBN = new TextBox();
            panel1.SuspendLayout();
            btn_DeleteGenres.SuspendLayout();
            tabPage4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOverview).BeginInit();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridWriter).BeginInit();
            tapPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridGenres).BeginInit();
            tabPage5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStock).BeginInit();
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
            panel1.Size = new Size(842, 716);
            panel1.TabIndex = 1;
            // 
            // btn_DeleteGenres
            // 
            btn_DeleteGenres.Controls.Add(tabPage4);
            btn_DeleteGenres.Controls.Add(tabPage1);
            btn_DeleteGenres.Controls.Add(tapPage2);
            btn_DeleteGenres.Controls.Add(tabPage5);
            btn_DeleteGenres.Controls.Add(tabPage3);
            btn_DeleteGenres.Dock = DockStyle.Fill;
            btn_DeleteGenres.Location = new Point(0, 0);
            btn_DeleteGenres.Name = "btn_DeleteGenres";
            btn_DeleteGenres.SelectedIndex = 0;
            btn_DeleteGenres.Size = new Size(842, 716);
            btn_DeleteGenres.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btn_Search);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(txtSearch);
            tabPage4.Controls.Add(panel5);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(834, 683);
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
            // txtSearch
            // 
            txtSearch.Location = new Point(65, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(635, 27);
            txtSearch.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridOverview);
            panel5.Location = new Point(0, 48);
            panel5.Name = "panel5";
            panel5.Size = new Size(834, 635);
            panel5.TabIndex = 0;
            // 
            // dataGridOverview
            // 
            dataGridOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOverview.Dock = DockStyle.Fill;
            dataGridOverview.Location = new Point(0, 0);
            dataGridOverview.Name = "dataGridOverview";
            dataGridOverview.RowHeadersWidth = 51;
            dataGridOverview.RowTemplate.Height = 29;
            dataGridOverview.Size = new Size(834, 635);
            dataGridOverview.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_NewWriter);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btn_DeleteWriter);
            tabPage1.Controls.Add(btn_SaveWriter);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtLastName);
            tabPage1.Controls.Add(txtFirstName);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(834, 683);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Autoren";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_NewWriter
            // 
            btn_NewWriter.Location = new Point(8, 648);
            btn_NewWriter.Name = "btn_NewWriter";
            btn_NewWriter.Size = new Size(270, 29);
            btn_NewWriter.TabIndex = 9;
            btn_NewWriter.Text = "Neuer Eintrag";
            btn_NewWriter.UseVisualStyleBackColor = true;
            btn_NewWriter.Click += btn_NewWriter_Click;
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
            dataGridWriter.SelectionChanged += dataGridWriter_SelectionChanged;
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
            btn_DeleteWriter.Location = new Point(558, 648);
            btn_DeleteWriter.Name = "btn_DeleteWriter";
            btn_DeleteWriter.Size = new Size(270, 29);
            btn_DeleteWriter.TabIndex = 5;
            btn_DeleteWriter.Text = "Löschen";
            btn_DeleteWriter.UseVisualStyleBackColor = true;
            btn_DeleteWriter.Click += btn_DeleteWriter_Click;
            // 
            // btn_SaveWriter
            // 
            btn_SaveWriter.Location = new Point(282, 648);
            btn_SaveWriter.Name = "btn_SaveWriter";
            btn_SaveWriter.Size = new Size(270, 29);
            btn_SaveWriter.TabIndex = 4;
            btn_SaveWriter.Text = "Speichern";
            btn_SaveWriter.UseVisualStyleBackColor = true;
            btn_SaveWriter.Click += btn_SaveWriter_Click;
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
            tapPage2.Controls.Add(btn_NewGenres);
            tapPage2.Controls.Add(panel3);
            tapPage2.Controls.Add(btn_DeleteGen);
            tapPage2.Controls.Add(btn_SaveGenres);
            tapPage2.Controls.Add(label4);
            tapPage2.Controls.Add(txtGenres);
            tapPage2.Location = new Point(4, 29);
            tapPage2.Name = "tapPage2";
            tapPage2.Padding = new Padding(3);
            tapPage2.Size = new Size(834, 683);
            tapPage2.TabIndex = 1;
            tapPage2.Text = "Genre";
            tapPage2.UseVisualStyleBackColor = true;
            // 
            // btn_NewGenres
            // 
            btn_NewGenres.Location = new Point(8, 648);
            btn_NewGenres.Name = "btn_NewGenres";
            btn_NewGenres.Size = new Size(270, 29);
            btn_NewGenres.TabIndex = 11;
            btn_NewGenres.Text = "Neuer Eintrag";
            btn_NewGenres.UseVisualStyleBackColor = true;
            btn_NewGenres.Click += btn_NewGenres_Click;
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
            dataGridGenres.SelectionChanged += dataGridGenres_SelectionChanged;
            // 
            // btn_DeleteGen
            // 
            btn_DeleteGen.Location = new Point(556, 648);
            btn_DeleteGen.Name = "btn_DeleteGen";
            btn_DeleteGen.Size = new Size(270, 29);
            btn_DeleteGen.TabIndex = 9;
            btn_DeleteGen.Text = "Löschen";
            btn_DeleteGen.UseVisualStyleBackColor = true;
            btn_DeleteGen.Click += btn_DeleteGenres_Click;
            // 
            // btn_SaveGenres
            // 
            btn_SaveGenres.Location = new Point(282, 648);
            btn_SaveGenres.Name = "btn_SaveGenres";
            btn_SaveGenres.Size = new Size(270, 29);
            btn_SaveGenres.TabIndex = 8;
            btn_SaveGenres.Text = "Speichern";
            btn_SaveGenres.UseVisualStyleBackColor = true;
            btn_SaveGenres.Click += btn_SaveGenres_Click;
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
            // tabPage5
            // 
            tabPage5.Controls.Add(btn_NewStock);
            tabPage5.Controls.Add(label12);
            tabPage5.Controls.Add(txtPanel);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(txtShelve);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(txtLevel);
            tabPage5.Controls.Add(btn_DeleteStock);
            tabPage5.Controls.Add(btn_SaveStock);
            tabPage5.Controls.Add(panel6);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(834, 683);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Stock";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_NewStock
            // 
            btn_NewStock.Location = new Point(8, 648);
            btn_NewStock.Name = "btn_NewStock";
            btn_NewStock.Size = new Size(270, 29);
            btn_NewStock.TabIndex = 23;
            btn_NewStock.Text = "Neuer Eintrag";
            btn_NewStock.UseVisualStyleBackColor = true;
            btn_NewStock.Click += btn_NewStock_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 486);
            label12.Name = "label12";
            label12.Size = new Size(52, 20);
            label12.TabIndex = 22;
            label12.Text = "Paneel";
            // 
            // txtPanel
            // 
            txtPanel.Location = new Point(8, 509);
            txtPanel.Name = "txtPanel";
            txtPanel.Size = new Size(400, 27);
            txtPanel.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(426, 433);
            label11.Name = "label11";
            label11.Size = new Size(47, 20);
            label11.TabIndex = 20;
            label11.Text = "Regal";
            // 
            // txtShelve
            // 
            txtShelve.Location = new Point(426, 456);
            txtShelve.Name = "txtShelve";
            txtShelve.Size = new Size(400, 27);
            txtShelve.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 433);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 18;
            label10.Text = "Ebene";
            // 
            // txtLevel
            // 
            txtLevel.Location = new Point(8, 456);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(400, 27);
            txtLevel.TabIndex = 17;
            // 
            // btn_DeleteStock
            // 
            btn_DeleteStock.Location = new Point(556, 648);
            btn_DeleteStock.Name = "btn_DeleteStock";
            btn_DeleteStock.Size = new Size(270, 29);
            btn_DeleteStock.TabIndex = 16;
            btn_DeleteStock.Text = "Löschen";
            btn_DeleteStock.UseVisualStyleBackColor = true;
            btn_DeleteStock.Click += btn_DeleteStock_Click;
            // 
            // btn_SaveStock
            // 
            btn_SaveStock.Location = new Point(282, 648);
            btn_SaveStock.Name = "btn_SaveStock";
            btn_SaveStock.Size = new Size(270, 29);
            btn_SaveStock.TabIndex = 15;
            btn_SaveStock.Text = "Speichern";
            btn_SaveStock.UseVisualStyleBackColor = true;
            btn_SaveStock.Click += btn_SaveStock_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(dataGridStock);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(834, 430);
            panel6.TabIndex = 0;
            // 
            // dataGridStock
            // 
            dataGridStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStock.Dock = DockStyle.Fill;
            dataGridStock.Location = new Point(0, 0);
            dataGridStock.Name = "dataGridStock";
            dataGridStock.RowHeadersWidth = 51;
            dataGridStock.RowTemplate.Height = 29;
            dataGridStock.Size = new Size(834, 430);
            dataGridStock.TabIndex = 0;
            dataGridStock.SelectionChanged += dataGridStock_SelectionChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(btn_NewBook);
            tabPage3.Controls.Add(panel4);
            tabPage3.Controls.Add(btn_DeleteBook);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(btn_SaveBook);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(txtTitel);
            tabPage3.Controls.Add(txtISBN);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(834, 683);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Bücher";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(426, 592);
            label15.Name = "label15";
            label15.Size = new Size(58, 20);
            label15.TabIndex = 32;
            label15.Text = "StockId";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(8, 592);
            label16.Name = "label16";
            label16.Size = new Size(46, 20);
            label16.TabIndex = 31;
            label16.Text = "BYear";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(426, 615);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(400, 27);
            textBox5.TabIndex = 30;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(8, 615);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(400, 27);
            textBox6.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(426, 539);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 28;
            label13.Text = "StockId";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 539);
            label14.Name = "label14";
            label14.Size = new Size(46, 20);
            label14.TabIndex = 27;
            label14.Text = "BYear";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(426, 562);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(400, 27);
            textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(8, 562);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(400, 27);
            textBox3.TabIndex = 25;
            // 
            // btn_NewBook
            // 
            btn_NewBook.Location = new Point(8, 648);
            btn_NewBook.Name = "btn_NewBook";
            btn_NewBook.Size = new Size(270, 29);
            btn_NewBook.TabIndex = 24;
            btn_NewBook.Text = "Neuer Eintrag";
            btn_NewBook.UseVisualStyleBackColor = true;
            btn_NewBook.Click += btn_NewBook_Click;
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
            dataGridBook.SelectionChanged += dataGridBook_SelectionChanged;
            // 
            // btn_DeleteBook
            // 
            btn_DeleteBook.Location = new Point(556, 648);
            btn_DeleteBook.Name = "btn_DeleteBook";
            btn_DeleteBook.Size = new Size(270, 29);
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
            // btn_SaveBook
            // 
            btn_SaveBook.Location = new Point(282, 648);
            btn_SaveBook.Name = "btn_SaveBook";
            btn_SaveBook.Size = new Size(270, 29);
            btn_SaveBook.TabIndex = 9;
            btn_SaveBook.Text = "Speichern";
            btn_SaveBook.UseVisualStyleBackColor = true;
            btn_SaveBook.Click += btn_AddBook_Click;
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
            ClientSize = new Size(842, 716);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bibliotheksverleih ";
            panel1.ResumeLayout(false);
            btn_DeleteGenres.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridOverview).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridWriter).EndInit();
            tapPage2.ResumeLayout(false);
            tapPage2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridGenres).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridStock).EndInit();
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
        private Button btn_SaveWriter;
        private Button btn_DeleteWriter;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox txtGenres;
        private Button btn_SaveGenres;
        private Button btn_SaveBook;
        private Label label5;
        private Label label6;
        private TextBox txtTitel;
        private TextBox txtISBN;
        private Label label7;
        private TextBox textBox4;
        private TabPage tabPage4;
        private Button btn_DeleteGen;
        private Button btn_DeleteBook;
        private Label label8;
        private Panel panel2;
        private DataGridView dataGridWriter;
        private Panel panel3;
        private DataGridView dataGridGenres;
        private Panel panel4;
        private DataGridView dataGridBook;
        private Panel panel5;
        private DataGridView dataGridOverview;
        private Button btn_Search;
        private Label label9;
        private TextBox txtSearch;
        private TabPage tabPage5;
        private Panel panel6;
        private DataGridView dataGridStock;
        private Button btn_DeleteStock;
        private Button btn_SaveStock;
        private TextBox txtLevel;
        private Label label10;
        private Label label12;
        private TextBox txtPanel;
        private Label label11;
        private TextBox txtShelve;
        private Button btn_NewWriter;
        private Button btn_NewGenres;
        private Button btn_NewStock;
        private Button btn_NewBook;
        private Label label13;
        private Label label14;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label15;
        private Label label16;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}