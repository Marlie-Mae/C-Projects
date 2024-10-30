namespace ProductForm
{
    partial class Form5
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
            comboHistory = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtsearch = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboHistory
            // 
            comboHistory.FormattingEnabled = true;
            comboHistory.Items.AddRange(new object[] { "Product", "Available Products", "Stock IN", "Stock OUT" });
            comboHistory.Location = new Point(550, 27);
            comboHistory.Name = "comboHistory";
            comboHistory.Size = new Size(148, 23);
            comboHistory.TabIndex = 14;
            comboHistory.SelectedIndexChanged += comboHistory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 60);
            label1.Name = "label1";
            label1.Size = new Size(325, 42);
            label1.TabIndex = 13;
            label1.Text = "Product History";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 126);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 15;
            label2.Text = "Search";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(119, 118);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(203, 23);
            txtsearch.TabIndex = 16;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(618, 238);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 408);
            Controls.Add(dataGridView1);
            Controls.Add(txtsearch);
            Controls.Add(label2);
            Controls.Add(comboHistory);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboHistory;
        private Label label1;
        private Label label2;
        private TextBox txtsearch;
        private DataGridView dataGridView1;
    }
}