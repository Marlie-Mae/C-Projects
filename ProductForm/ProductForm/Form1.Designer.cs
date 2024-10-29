namespace ProductForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtpid = new TextBox();
            txtpname = new TextBox();
            txtpdesc = new TextBox();
            btnadd = new Button();
            btnupdate = new Button();
            btndelete = new Button();
            btclear = new Button();
            comboHistory = new ComboBox();
            btnprev = new Button();
            btnnext = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 60);
            label1.Name = "label1";
            label1.Size = new Size(171, 42);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 169);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Product ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 207);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "Product Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 242);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 3;
            label4.Text = "Product Description:";
            // 
            // txtpid
            // 
            txtpid.Location = new Point(235, 161);
            txtpid.Name = "txtpid";
            txtpid.Size = new Size(262, 23);
            txtpid.TabIndex = 4;
            // 
            // txtpname
            // 
            txtpname.Location = new Point(235, 199);
            txtpname.Name = "txtpname";
            txtpname.Size = new Size(262, 23);
            txtpname.TabIndex = 5;
            // 
            // txtpdesc
            // 
            txtpdesc.Location = new Point(235, 234);
            txtpdesc.Name = "txtpdesc";
            txtpdesc.Size = new Size(262, 23);
            txtpdesc.TabIndex = 6;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(583, 130);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 7;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(583, 174);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(75, 23);
            btnupdate.TabIndex = 8;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(583, 221);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 9;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btclear
            // 
            btclear.Location = new Point(583, 268);
            btclear.Name = "btclear";
            btclear.Size = new Size(75, 23);
            btclear.TabIndex = 10;
            btclear.Text = "Clear";
            btclear.UseVisualStyleBackColor = true;
            btclear.Click += btnclear_Click;
            // 
            // comboHistory
            // 
            comboHistory.FormattingEnabled = true;
            comboHistory.Items.AddRange(new object[] { "Available Products", "Stock IN", "Stock OUT", "Product History" });
            comboHistory.Location = new Point(550, 27);
            comboHistory.Name = "comboHistory";
            comboHistory.Size = new Size(148, 23);
            comboHistory.TabIndex = 11;
            comboHistory.SelectedIndexChanged += comboHistory_SelectedIndexChanged;
            // 
            // btnprev
            // 
            btnprev.Location = new Point(218, 349);
            btnprev.Name = "btnprev";
            btnprev.Size = new Size(75, 23);
            btnprev.TabIndex = 12;
            btnprev.Text = "Previous";
            btnprev.UseVisualStyleBackColor = true;
            btnprev.Click += btnprev_Click;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(432, 349);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(75, 23);
            btnnext.TabIndex = 13;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(583, 309);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 23);
            btnexit.TabIndex = 14;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 408);
            Controls.Add(btnexit);
            Controls.Add(btnnext);
            Controls.Add(btnprev);
            Controls.Add(comboHistory);
            Controls.Add(btclear);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnadd);
            Controls.Add(txtpdesc);
            Controls.Add(txtpname);
            Controls.Add(txtpid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtpid;
        private TextBox txtpname;
        private TextBox txtpdesc;
        private Button btnadd;
        private Button btnupdate;
        private Button btndelete;
        private Button btclear;
        private ComboBox comboHistory;
        private Button btnprev;
        private Button btnnext;
        private Button btnexit;
    }
}
