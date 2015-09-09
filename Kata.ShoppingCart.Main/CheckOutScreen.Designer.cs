namespace Kata.ShoppingCart.Main
{
    partial class CheckOutScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnItemA = new System.Windows.Forms.Button();
            this.btnItemB = new System.Windows.Forms.Button();
            this.btnItemC = new System.Windows.Forms.Button();
            this.btnItemD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvCart);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 537);
            this.panel1.TabIndex = 1;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Qty,
            this.Price});
            this.dgvCart.Location = new System.Drawing.Point(3, 38);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.Size = new System.Drawing.Size(314, 408);
            this.dgvCart.TabIndex = 2;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.MaxInputLength = 3;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 50;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "$0.00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(203, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "$0.00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "$0.00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SubTotal";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kata Checkout Challenge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnItemA
            // 
            this.btnItemA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemA.Location = new System.Drawing.Point(391, 122);
            this.btnItemA.Name = "btnItemA";
            this.btnItemA.Size = new System.Drawing.Size(128, 128);
            this.btnItemA.TabIndex = 2;
            this.btnItemA.Text = "A ( $50 / 3 for 150 )";
            this.btnItemA.UseVisualStyleBackColor = true;
            this.btnItemA.Click += new System.EventHandler(this.btnItemA_Click);
            // 
            // btnItemB
            // 
            this.btnItemB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnItemB.Location = new System.Drawing.Point(561, 122);
            this.btnItemB.Name = "btnItemB";
            this.btnItemB.Size = new System.Drawing.Size(128, 128);
            this.btnItemB.TabIndex = 3;
            this.btnItemB.Text = "B ( $30 / 2 for $45 )";
            this.btnItemB.UseVisualStyleBackColor = true;
            this.btnItemB.Click += new System.EventHandler(this.btnItemB_Click);
            // 
            // btnItemC
            // 
            this.btnItemC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnItemC.Location = new System.Drawing.Point(391, 285);
            this.btnItemC.Name = "btnItemC";
            this.btnItemC.Size = new System.Drawing.Size(128, 128);
            this.btnItemC.TabIndex = 4;
            this.btnItemC.Text = "C ( $20 )";
            this.btnItemC.UseVisualStyleBackColor = true;
            this.btnItemC.Click += new System.EventHandler(this.btnItemC_Click);
            // 
            // btnItemD
            // 
            this.btnItemD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnItemD.Location = new System.Drawing.Point(561, 285);
            this.btnItemD.Name = "btnItemD";
            this.btnItemD.Size = new System.Drawing.Size(128, 128);
            this.btnItemD.TabIndex = 5;
            this.btnItemD.Text = "D ( $15 )";
            this.btnItemD.UseVisualStyleBackColor = true;
            this.btnItemD.Click += new System.EventHandler(this.btnItemD_Click);
            // 
            // CheckOutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnItemD);
            this.Controls.Add(this.btnItemC);
            this.Controls.Add(this.btnItemB);
            this.Controls.Add(this.btnItemA);
            this.Controls.Add(this.panel1);
            this.Name = "CheckOutScreen";
            this.Text = "CheckOutScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnItemA;
        private System.Windows.Forms.Button btnItemB;
        private System.Windows.Forms.Button btnItemC;
        private System.Windows.Forms.Button btnItemD;
    }
}