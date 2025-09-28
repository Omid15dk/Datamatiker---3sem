
namespace NotSoCoolShop.Userinterface {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonGetAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(60, 53);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(125, 27);
            this.textBoxTitle.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(60, 131);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(125, 27);
            this.textBoxPrice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Products";
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 20;
            this.listBoxProducts.Location = new System.Drawing.Point(318, 54);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(299, 144);
            this.listBoxProducts.TabIndex = 5;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.ListBoxProducts_SelectedIndexChanged);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(60, 223);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(125, 29);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "Insert product";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // buttonGetAll
            // 
            this.buttonGetAll.Location = new System.Drawing.Point(318, 223);
            this.buttonGetAll.Name = "buttonGetAll";
            this.buttonGetAll.Size = new System.Drawing.Size(136, 29);
            this.buttonGetAll.TabIndex = 7;
            this.buttonGetAll.Text = "Get all products";
            this.buttonGetAll.UseVisualStyleBackColor = true;
            this.buttonGetAll.Click += new System.EventHandler(this.ButtonGetAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 429);
            this.Controls.Add(this.buttonGetAll);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "Form1";
            this.Text = "Database Vertical";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonGetAll;
    }
}

