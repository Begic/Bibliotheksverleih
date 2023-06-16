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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_AddWriter = new Button();
            label2 = new Label();
            label1 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            tapPage2 = new TabPage();
            tabPage3 = new TabPage();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 623);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tapPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(842, 623);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
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
            // btn_AddWriter
            // 
            btn_AddWriter.Location = new Point(670, 33);
            btn_AddWriter.Name = "btn_AddWriter";
            btn_AddWriter.Size = new Size(156, 29);
            btn_AddWriter.TabIndex = 4;
            btn_AddWriter.Text = "Hinzufügen";
            btn_AddWriter.UseVisualStyleBackColor = true;
            btn_AddWriter.Click += btn_AddWriter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 10);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "Nachname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 2;
            label1.Text = "Vorname";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(346, 33);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(318, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(8, 33);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(318, 27);
            txtFirstName.TabIndex = 0;
            // 
            // tapPage2
            // 
            tapPage2.Location = new Point(4, 29);
            tapPage2.Name = "tapPage2";
            tapPage2.Padding = new Padding(3);
            tapPage2.Size = new Size(834, 590);
            tapPage2.TabIndex = 1;
            tapPage2.Text = "Genres";
            tapPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(834, 590);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Bücher";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 623);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Bibliotheksverleih ";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tapPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label1;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btn_AddWriter;
    }
}