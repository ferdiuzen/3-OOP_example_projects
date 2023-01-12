namespace ProductProject
{
    partial class Form1
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(80, 35);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(623, 181);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // unitPrice
            // 
            this.unitPrice.AutoSize = true;
            this.unitPrice.Location = new System.Drawing.Point(25, 66);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(54, 13);
            this.unitPrice.TabIndex = 2;
            this.unitPrice.Text = "Ürün Fiyaı";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(25, 99);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(59, 13);
            this.lblStockAmount.TabIndex = 3;
            this.lblStockAmount.Text = "Stok Adedi";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(90, 28);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(149, 20);
            this.tbxName.TabIndex = 4;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(90, 63);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(149, 20);
            this.tbxUnitPrice.TabIndex = 5;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(90, 96);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(149, 20);
            this.tbxStockAmount.TabIndex = 6;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.tbxStockAmount);
            this.gbxAdd.Controls.Add(this.label1);
            this.gbxAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxAdd.Controls.Add(this.unitPrice);
            this.gbxAdd.Controls.Add(this.lblStockAmount);
            this.gbxAdd.Location = new System.Drawing.Point(80, 265);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(331, 182);
            this.gbxAdd.TabIndex = 7;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Ürün Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 25);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.label2);
            this.gbxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.label3);
            this.gbxUpdate.Controls.Add(this.label4);
            this.gbxUpdate.Location = new System.Drawing.Point(442, 265);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(331, 182);
            this.gbxUpdate.TabIndex = 8;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Ürün Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(181, 151);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 25);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(90, 28);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(149, 20);
            this.tbxNameUpdate.TabIndex = 4;
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(90, 96);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(149, 20);
            this.tbxStockAmountUpdate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı";
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(90, 63);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(149, 20);
            this.tbxUnitPriceUpdate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Fiyaı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Adedi";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(710, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 469);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label unitPrice;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
    }
}

