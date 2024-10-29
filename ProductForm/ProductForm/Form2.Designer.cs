namespace ProductForm
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 60);
            label1.Name = "label1";
            label1.Size = new Size(383, 42);
            label1.TabIndex = 1;
            label1.Text = "Available Products";
            // 
            // comboHistory
            // 
            comboHistory.FormattingEnabled = true;
            comboHistory.Items.AddRange(new object[] { "Product", "Stock IN", "Stock OUT", "Product History" });
            comboHistory.Location = new Point(550, 27);
            comboHistory.Name = "comboHistory";
            comboHistory.Size = new Size(148, 23);
            comboHistory.TabIndex = 12;
            comboHistory.SelectedIndexChanged += comboHistory_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(525, 248);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnsin
            // 
            btnsin.Location = new Point(604, 189);
            btnsin.Name = "btnsin";
            btnsin.Size = new Size(75, 23);
            btnsin.TabIndex = 14;
            btnsin.Text = "Stock IN";
            btnsin.UseVisualStyleBackColor = true;
            btnsin.Click += btnsin_Click;
            // 
            // btnsout
            // 
            btnsout.Location = new Point(604, 237);
            btnsout.Name = "btnsout";
            btnsout.Size = new Size(75, 23);
            btnsout.TabIndex = 15;
            btnsout.Text = "Stock OUT";
            btnsout.UseVisualStyleBackColor = true;
            btnsout.Click += btnsout_Click;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(604, 352);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(75, 23);
            btnclose.TabIndex = 16;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 408);
            Controls.Add(btnclose);
            Controls.Add(btnsout);
            Controls.Add(btnsin);
            Controls.Add(dataGridView1);
            Controls.Add(comboHistory);
            Controls.Add(label1);
            Location = new Point(550, 34);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboHistory;
        private DataGridView dataGridView1;
        private Button btnsin;
        private Button btnsout;
        private Button btnclose;
    }
}