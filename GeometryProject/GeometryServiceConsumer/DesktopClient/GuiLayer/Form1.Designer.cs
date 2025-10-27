
namespace DesktopClient {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSorting = new System.Windows.Forms.ComboBox();
            this.lblProcessGet = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.btnGetLines = new System.Windows.Forms.Button();
            this.textBoxLineId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProcessPost = new System.Windows.Forms.Label();
            this.btnSaveLine = new System.Windows.Forms.Button();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbSorting);
            this.groupBox1.Controls.Add(this.lblProcessGet);
            this.groupBox1.Controls.Add(this.listBoxResult);
            this.groupBox1.Controls.Add(this.btnGetLines);
            this.groupBox1.Controls.Add(this.textBoxLineId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Lines";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sorting:";
            // 
            // cbSorting
            // 
            this.cbSorting.FormattingEnabled = true;
            this.cbSorting.Location = new System.Drawing.Point(93, 72);
            this.cbSorting.Name = "cbSorting";
            this.cbSorting.Size = new System.Drawing.Size(89, 28);
            this.cbSorting.TabIndex = 5;
            // 
            // lblProcessGet
            // 
            this.lblProcessGet.AutoSize = true;
            this.lblProcessGet.Location = new System.Drawing.Point(31, 432);
            this.lblProcessGet.Name = "lblProcessGet";
            this.lblProcessGet.Size = new System.Drawing.Size(15, 20);
            this.lblProcessGet.TabIndex = 4;
            this.lblProcessGet.Text = "..";
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Location = new System.Drawing.Point(31, 128);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(264, 304);
            this.listBoxResult.TabIndex = 3;
            // 
            // btnGetLines
            // 
            this.btnGetLines.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGetLines.Location = new System.Drawing.Point(201, 30);
            this.btnGetLines.Name = "btnGetLines";
            this.btnGetLines.Size = new System.Drawing.Size(94, 29);
            this.btnGetLines.TabIndex = 2;
            this.btnGetLines.Text = "GET";
            this.btnGetLines.UseVisualStyleBackColor = false;
            this.btnGetLines.Click += new System.EventHandler(this.BtnGetLines_Click);
            // 
            // textBoxLineId
            // 
            this.textBoxLineId.Location = new System.Drawing.Point(93, 33);
            this.textBoxLineId.Name = "textBoxLineId";
            this.textBoxLineId.Size = new System.Drawing.Size(89, 27);
            this.textBoxLineId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Line id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxY2);
            this.groupBox2.Controls.Add(this.textBoxX2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblProcessPost);
            this.groupBox2.Controls.Add(this.btnSaveLine);
            this.groupBox2.Controls.Add(this.textBoxY1);
            this.groupBox2.Controls.Add(this.textBoxX1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(407, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save Line";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(258, 172);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(60, 27);
            this.textBoxY2.TabIndex = 8;
            this.textBoxY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(118, 171);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(60, 27);
            this.textBoxX2.TabIndex = 7;
            this.textBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Y2 value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "X2 value";
            // 
            // lblProcessPost
            // 
            this.lblProcessPost.AutoSize = true;
            this.lblProcessPost.Location = new System.Drawing.Point(20, 290);
            this.lblProcessPost.Name = "lblProcessPost";
            this.lblProcessPost.Size = new System.Drawing.Size(15, 20);
            this.lblProcessPost.TabIndex = 4;
            this.lblProcessPost.Text = "..";
            // 
            // btnSaveLine
            // 
            this.btnSaveLine.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveLine.Location = new System.Drawing.Point(20, 248);
            this.btnSaveLine.Name = "btnSaveLine";
            this.btnSaveLine.Size = new System.Drawing.Size(94, 29);
            this.btnSaveLine.TabIndex = 3;
            this.btnSaveLine.Text = "POST";
            this.btnSaveLine.UseVisualStyleBackColor = false;
            this.btnSaveLine.Click += new System.EventHandler(this.BtnSaveLine_Click);
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(258, 67);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(60, 27);
            this.textBoxY1.TabIndex = 2;
            this.textBoxY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(118, 66);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(60, 27);
            this.textBoxX1.TabIndex = 2;
            this.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y1 value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "X1 value";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(20, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 78);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Point 1";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(20, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 78);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Point 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Desktop Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProcessGet;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button btnGetLines;
        private System.Windows.Forms.TextBox textBoxLineId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblProcessPost;
        private System.Windows.Forms.Button btnSaveLine;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSorting;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

