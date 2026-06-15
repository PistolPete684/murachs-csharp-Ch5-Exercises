namespace InvoiceTotal
{
    partial class frmInvoiceTotal
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
            txtSubtotal = new TextBox();
            label2 = new Label();
            txtDiscountPct = new TextBox();
            label3 = new Label();
            txtDiscountAmt = new TextBox();
            label4 = new Label();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            label5 = new Label();
            txtCustomerType = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 63);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 2;
            label1.Text = "&Subtotal:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(150, 59);
            txtSubtotal.Margin = new Padding(3, 4, 3, 4);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(114, 27);
            txtSubtotal.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 101);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 2;
            label2.Text = "Discount Percent:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountPct
            // 
            txtDiscountPct.Location = new Point(150, 97);
            txtDiscountPct.Margin = new Padding(3, 4, 3, 4);
            txtDiscountPct.Name = "txtDiscountPct";
            txtDiscountPct.ReadOnly = true;
            txtDiscountPct.Size = new Size(114, 27);
            txtDiscountPct.TabIndex = 3;
            txtDiscountPct.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 140);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 4;
            label3.Text = "Discount Amount:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountAmt
            // 
            txtDiscountAmt.Location = new Point(150, 136);
            txtDiscountAmt.Margin = new Padding(3, 4, 3, 4);
            txtDiscountAmt.Name = "txtDiscountAmt";
            txtDiscountAmt.ReadOnly = true;
            txtDiscountAmt.Size = new Size(114, 27);
            txtDiscountAmt.TabIndex = 5;
            txtDiscountAmt.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 179);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "Total:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(150, 175);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(114, 27);
            txtTotal.TabIndex = 7;
            txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(73, 228);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(86, 31);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(178, 228);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 24);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 0;
            label5.Text = "Customer Type:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCustomerType
            // 
            txtCustomerType.Location = new Point(150, 20);
            txtCustomerType.Margin = new Padding(3, 4, 3, 4);
            txtCustomerType.Name = "txtCustomerType";
            txtCustomerType.Size = new Size(114, 27);
            txtCustomerType.TabIndex = 1;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(290, 280);
            Controls.Add(txtCustomerType);
            Controls.Add(label5);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(txtDiscountAmt);
            Controls.Add(label3);
            Controls.Add(txtDiscountPct);
            Controls.Add(label2);
            Controls.Add(txtSubtotal);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInvoiceTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            Load += frmInvoiceTotal_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSubtotal;
        private Label label2;
        private TextBox txtDiscountPct;
        private Label label3;
        private TextBox txtDiscountAmt;
        private Label label4;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnExit;
        private Label label5;
        private TextBox txtCustomerType;
    }
}