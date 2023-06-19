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
            tabPage1 = new TabPage();
            btn_DeleteWriter = new Button();
            btn_AddWriter = new Button();
            label2 = new Label();
            label1 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            tapPage2 = new TabPage();
            button1 = new Button();
            btn_AddGenres = new Button();
            label4 = new Label();
            txtGenres = new TextBox();
            tabPage3 = new TabPage();
            btn_DeleteBook = new Button();
            label3 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            btn_AddBook = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            btn_DeleteGenres.SuspendLayout();
            tabPage1.SuspendLayout();
            tapPage2.SuspendLayout();
            tabPage3.SuspendLayout();
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
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(834, 590);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Übersicht";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
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
            label4.Location = new Point(54, 398);
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
            tabPage3.Controls.Add(btn_DeleteBook);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(btn_AddBook);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(834, 590);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Bücher";
            tabPage3.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            textBox2.Location = new Point(426, 456);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(400, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(8, 456);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(400, 27);
            textBox3.TabIndex = 5;
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
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tapPage2.ResumeLayout(false);
            tapPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
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
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private TabPage tabPage4;
        private Button button1;
        private Button btn_DeleteBook;
    }
}