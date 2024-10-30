﻿namespace ProductForm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboHistory = new ComboBox();
            dataGridView1 = new DataGridView();
            btnsin = new Button();
            btnsout = new Button();
            btnclose = new Button();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(252, 205, 42);
            label1.Font = new Font("Bookman Old Style", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(82, 121, 40);
            label1.Location = new Point(172, 48);
            label1.Name = "label1";
            label1.Size = new Size(405, 47);
            label1.TabIndex = 1;
            label1.Text = "Available Products";
            // 
            // comboHistory
            // 
            comboHistory.Font = new Font("Verdana", 9F, FontStyle.Bold);
            comboHistory.ForeColor = Color.FromArgb(82, 121, 40);
            comboHistory.FormattingEnabled = true;
            comboHistory.Items.AddRange(new object[] { "Product", "Product History" });
            comboHistory.Location = new Point(606, 25);
            comboHistory.Name = "comboHistory";
            comboHistory.Size = new Size(148, 22);
            comboHistory.TabIndex = 12;
            comboHistory.SelectedIndexChanged += comboHistory_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(542, 248);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnsin
            // 
            btnsin.BackColor = Color.FromArgb(52, 121, 40);
            btnsin.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnsin.ForeColor = Color.FromArgb(244, 246, 255);
            btnsin.Location = new Point(634, 171);
            btnsin.Name = "btnsin";
            btnsin.Size = new Size(95, 49);
            btnsin.TabIndex = 14;
            btnsin.Text = "Stock IN";
            btnsin.UseVisualStyleBackColor = false;
            btnsin.Click += btnsin_Click;
            // 
            // btnsout
            // 
            btnsout.BackColor = Color.FromArgb(52, 121, 40);
            btnsout.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnsout.ForeColor = Color.FromArgb(244, 246, 255);
            btnsout.Location = new Point(634, 236);
            btnsout.Name = "btnsout";
            btnsout.Size = new Size(95, 49);
            btnsout.TabIndex = 15;
            btnsout.Text = "Stock OUT";
            btnsout.UseVisualStyleBackColor = false;
            btnsout.Click += btnsout_Click;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.FromArgb(52, 121, 40);
            btnclose.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnclose.ForeColor = Color.FromArgb(244, 246, 255);
            btnclose.Location = new Point(637, 360);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(92, 45);
            btnclose.TabIndex = 16;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 205, 42);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-12, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 120);
            panel1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(252, 205, 42);
            label2.Font = new Font("Bookman Old Style", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(52, 121, 40);
            label2.Location = new Point(243, 26);
            label2.Name = "label2";
            label2.Size = new Size(0, 75);
            label2.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 230);
            ClientSize = new Size(775, 435);
            Controls.Add(btnclose);
            Controls.Add(btnsout);
            Controls.Add(btnsin);
            Controls.Add(dataGridView1);
            Controls.Add(comboHistory);
            Controls.Add(panel1);
            Location = new Point(243, 26);
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox comboHistory;
        private DataGridView dataGridView1;
        private Button btnsin;
        private Button btnsout;
        private Button btnclose;
        private Panel panel1;
        private Label label2;
    }
}