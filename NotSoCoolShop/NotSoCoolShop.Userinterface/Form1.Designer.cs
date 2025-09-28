
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
        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            lblTitle = new Label();
            lblPrice = new Label();
            lblProducts = new Label();
            listBoxProducts = new ListBox();
            buttonInsert = new Button();
            buttonGetAll = new Button();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(52, 40);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(110, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(52, 98);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(110, 23);
            txtPrice.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(52, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(29, 15);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(52, 81);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(278, 22);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(54, 15);
            lblProducts.TabIndex = 4;
            lblProducts.Text = "Products";
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 15;
            listBoxProducts.Location = new Point(278, 40);
            listBoxProducts.Margin = new Padding(3, 2, 3, 2);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(262, 109);
            listBoxProducts.TabIndex = 5;
            listBoxProducts.SelectedIndexChanged += ListBoxProducts_SelectedIndexChanged;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(53, 189);
            buttonInsert.Margin = new Padding(3, 2, 3, 2);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(109, 22);
            buttonInsert.TabIndex = 6;
            buttonInsert.Text = "Insert product";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += ButtonInsert_Click;
            // 
            // buttonGetAll
            // 
            buttonGetAll.Location = new Point(278, 167);
            buttonGetAll.Margin = new Padding(3, 2, 3, 2);
            buttonGetAll.Name = "buttonGetAll";
            buttonGetAll.Size = new Size(119, 22);
            buttonGetAll.TabIndex = 7;
            buttonGetAll.Text = "Get all products";
            buttonGetAll.UseVisualStyleBackColor = true;
            buttonGetAll.Click += ButtonGetAll_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(52, 147);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(110, 23);
            txtQuantity.TabIndex = 8;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(52, 129);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(49, 15);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quanity";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 322);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(buttonGetAll);
            Controls.Add(buttonInsert);
            Controls.Add(listBoxProducts);
            Controls.Add(lblProducts);
            Controls.Add(lblPrice);
            Controls.Add(lblTitle);
            Controls.Add(txtPrice);
            Controls.Add(txtTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Database Vertical";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonGetAll;
        private TextBox txtQuantity;
        private Label lblQuantity;
    }
}

