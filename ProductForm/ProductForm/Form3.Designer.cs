namespace ProductForm
{
    partial class Form3
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
            btnprod = new Button();
            btnavail = new Button();
            btnhistory = new Button();
            txtsupplier = new TextBox();
            label6 = new Label();
            btnclear = new Button();
            btnadd = new Button();
            quantity = new NumericUpDown();
            comboUnit = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtpname = new TextBox();
            txtpid = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnnext = new Button();
            btnprev = new Button();
            ((System.ComponentModel.ISupportInitialize)quantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 60);
            label1.Name = "label1";
            label1.Size = new Size(188, 42);
            label1.TabIndex = 2;
            label1.Text = "Stock IN";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(498, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            //dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnprod
            // 
            btnprod.Location = new Point(573, 153);
            btnprod.Name = "btnprod";
            btnprod.Size = new Size(75, 23);
            btnprod.TabIndex = 16;
            btnprod.Text = "Products";
            btnprod.UseVisualStyleBackColor = true;
            btnprod.Click += btnprod_Click;
            // 
            // btnavail
            // 
            btnavail.Location = new Point(573, 200);
            btnavail.Name = "btnavail";
            btnavail.Size = new Size(75, 39);
            btnavail.TabIndex = 17;
            btnavail.Text = "Available Products";
            btnavail.UseVisualStyleBackColor = true;
            btnavail.Click += btnavail_Click;
            // 
            // btnhistory
            // 
            btnhistory.Location = new Point(573, 258);
            btnhistory.Name = "btnhistory";
            btnhistory.Size = new Size(75, 42);
            btnhistory.TabIndex = 18;
            btnhistory.Text = "Product History";
            btnhistory.UseVisualStyleBackColor = true;
            btnhistory.Click += btnhistory_Click;
            // 
            // txtsupplier
            // 
            txtsupplier.Location = new Point(226, 288);
            txtsupplier.Name = "txtsupplier";
            txtsupplier.Size = new Size(262, 23);
            txtsupplier.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 296);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 43;
            label6.Text = "Supplier:";
            // 
            // btnclear
            // 
            btnclear.Location = new Point(257, 353);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 23);
            btnclear.TabIndex = 42;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(144, 353);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 41;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // quantity
            // 
            quantity.Location = new Point(226, 212);
            quantity.Name = "quantity";
            quantity.Size = new Size(262, 23);
            quantity.TabIndex = 40;
            // 
            // comboUnit
            // 
            comboUnit.FormattingEnabled = true;
            comboUnit.Location = new Point(226, 247);
            comboUnit.Name = "comboUnit";
            comboUnit.Size = new Size(262, 23);
            comboUnit.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 255);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 38;
            label5.Text = "Unit:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 220);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 37;
            label4.Text = "Quantity:";
            // 
            // txtpname
            // 
            txtpname.Location = new Point(226, 175);
            txtpname.Name = "txtpname";
            txtpname.Size = new Size(262, 23);
            txtpname.TabIndex = 36;
            // 
            // txtpid
            // 
            txtpid.Location = new Point(226, 137);
            txtpid.Name = "txtpid";
            txtpid.Size = new Size(262, 23);
            txtpid.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 183);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 34;
            label3.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 145);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 33;
            label2.Text = "Product ID:";
            // 
            // btnnext
            // 
            btnnext.Location = new Point(544, 353);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(75, 23);
            btnnext.TabIndex = 46;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // btnprev
            // 
            btnprev.Location = new Point(429, 353);
            btnprev.Name = "btnprev";
            btnprev.Size = new Size(75, 23);
            btnprev.TabIndex = 45;
            btnprev.Text = "Previous";
            btnprev.UseVisualStyleBackColor = true;
            btnprev.Click += btnprev_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 408);
            Controls.Add(btnnext);
            Controls.Add(btnprev);
            Controls.Add(txtsupplier);
            Controls.Add(label6);
            Controls.Add(btnclear);
            Controls.Add(btnadd);
            Controls.Add(quantity);
            Controls.Add(comboUnit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtpname);
            Controls.Add(txtpid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnhistory);
            Controls.Add(btnavail);
            Controls.Add(btnprod);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button btnprod;
        private Button btnavail;
        private Button btnhistory;
        private TextBox txtsupplier;
        private Label label6;
        private Button btnclear;
        private Button btnadd;
        private NumericUpDown quantity;
        private ComboBox comboUnit;
        private Label label5;
        private Label label4;
        private TextBox txtpname;
        private TextBox txtpid;
        private Label label3;
        private Label label2;
        private Button btnnext;
        private Button btnprev;
    }
}