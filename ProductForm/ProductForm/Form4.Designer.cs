namespace ProductForm
{
    partial class Form4
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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            txtpid1 = new TextBox();
            label3 = new Label();
            txtpname1 = new TextBox();
            label4 = new Label();
            comboUnit1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            quantity1 = new NumericUpDown();
            txtcustomer = new TextBox();
            btnprod1 = new Button();
            btnavail1 = new Button();
            btnhistory1 = new Button();
            btnadd1 = new Button();
            btnclear1 = new Button();
            btnprev1 = new Button();
            btnnext1 = new Button();
            ((System.ComponentModel.ISupportInitialize)quantity1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold);
            label1.Location = new Point(257, 60);
            label1.Name = "label1";
            label1.Size = new Size(221, 42);
            label1.TabIndex = 0;
            label1.Text = "Stock OUT";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(498, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 145);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Product ID:";
            // 
            // txtpid1
            // 
            txtpid1.Location = new Point(226, 137);
            txtpid1.Name = "txtpid1";
            txtpid1.Size = new Size(262, 23);
            txtpid1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 183);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 4;
            label3.Text = "Product Name:";
            // 
            // txtpname1
            // 
            txtpname1.Location = new Point(226, 175);
            txtpname1.Name = "txtpname1";
            txtpname1.Size = new Size(262, 23);
            txtpname1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 220);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Quantity:";
            // 
            // comboUnit1
            // 
            comboUnit1.FormattingEnabled = true;
            comboUnit1.Location = new Point(226, 247);
            comboUnit1.Name = "comboUnit1";
            comboUnit1.Size = new Size(262, 23);
            comboUnit1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 255);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 8;
            label5.Text = "Unit:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 294);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 9;
            label6.Text = "Customer:";
            // 
            // quantity1
            // 
            quantity1.Location = new Point(226, 212);
            quantity1.Name = "quantity1";
            quantity1.Size = new Size(262, 23);
            quantity1.TabIndex = 10;
            // 
            // txtcustomer
            // 
            txtcustomer.Location = new Point(226, 288);
            txtcustomer.Name = "txtcustomer";
            txtcustomer.Size = new Size(262, 23);
            txtcustomer.TabIndex = 11;
            // 
            // btnprod1
            // 
            btnprod1.Location = new Point(572, 153);
            btnprod1.Name = "btnprod1";
            btnprod1.Size = new Size(75, 23);
            btnprod1.TabIndex = 12;
            btnprod1.Text = "Product";
            btnprod1.UseVisualStyleBackColor = true;
            btnprod1.Click += btnprod1_Click;
            // 
            // btnavail1
            // 
            btnavail1.Location = new Point(572, 202);
            btnavail1.Name = "btnavail1";
            btnavail1.Size = new Size(75, 39);
            btnavail1.TabIndex = 13;
            btnavail1.Text = "Available Products";
            btnavail1.UseVisualStyleBackColor = true;
            btnavail1.Click += btnavail1_Click;
            // 
            // btnhistory1
            // 
            btnhistory1.Location = new Point(572, 269);
            btnhistory1.Name = "btnhistory1";
            btnhistory1.Size = new Size(75, 40);
            btnhistory1.TabIndex = 14;
            btnhistory1.Text = "Product History";
            btnhistory1.UseVisualStyleBackColor = true;
            btnhistory1.Click += btnhistory1_Click;
            // 
            // btnadd1
            // 
            btnadd1.Location = new Point(140, 350);
            btnadd1.Name = "btnadd1";
            btnadd1.Size = new Size(75, 23);
            btnadd1.TabIndex = 15;
            btnadd1.Text = "Add";
            btnadd1.UseVisualStyleBackColor = true;
            btnadd1.Click += btnadd1_Click;
            // 
            // btnclear1
            // 
            btnclear1.Location = new Point(247, 350);
            btnclear1.Name = "btnclear1";
            btnclear1.Size = new Size(75, 23);
            btnclear1.TabIndex = 16;
            btnclear1.Text = "Clear";
            btnclear1.UseVisualStyleBackColor = true;
            btnclear1.Click += btnclear1_Click;
            // 
            // btnprev1
            // 
            btnprev1.Location = new Point(424, 350);
            btnprev1.Name = "btnprev1";
            btnprev1.Size = new Size(75, 23);
            btnprev1.TabIndex = 17;
            btnprev1.Text = "Previous";
            btnprev1.UseVisualStyleBackColor = true;
            btnprev1.Click += btnprev1_Click;
            // 
            // btnnext1
            // 
            btnnext1.Location = new Point(533, 350);
            btnnext1.Name = "btnnext1";
            btnnext1.Size = new Size(75, 23);
            btnnext1.TabIndex = 18;
            btnnext1.Text = "Next";
            btnnext1.UseVisualStyleBackColor = true;
            btnnext1.Click += btnnext1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 435);
            Controls.Add(btnnext1);
            Controls.Add(btnprev1);
            Controls.Add(btnclear1);
            Controls.Add(btnadd1);
            Controls.Add(btnhistory1);
            Controls.Add(btnavail1);
            Controls.Add(btnprod1);
            Controls.Add(txtcustomer);
            Controls.Add(quantity1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboUnit1);
            Controls.Add(label4);
            Controls.Add(txtpname1);
            Controls.Add(label3);
            Controls.Add(txtpid1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)quantity1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox txtpid1;
        private Label label3;
        private TextBox txtpname1;
        private Label label4;
        private ComboBox comboUnit1;
        private Label label5;
        private Label label6;
        private NumericUpDown quantity1;
        private TextBox txtcustomer;
        private Button btnprod1;
        private Button btnavail1;
        private Button btnhistory1;
        private Button btnadd1;
        private Button btnclear1;
        private Button btnprev1;
        private Button btnnext1;
    }
}