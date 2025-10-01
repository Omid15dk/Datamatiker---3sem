namespace WinConsumeWebApi {
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
            label1 = new Label();
            label2 = new Label();
            tBoxName = new TextBox();
            tBoxTimes = new TextBox();
            btnGreet = new Button();
            lblGreeting = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 59);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 64);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Times:";
            // 
            // tBoxName
            // 
            tBoxName.Location = new Point(140, 57);
            tBoxName.Name = "tBoxName";
            tBoxName.Size = new Size(196, 27);
            tBoxName.TabIndex = 2;
            // 
            // tBoxTimes
            // 
            tBoxTimes.Location = new Point(496, 66);
            tBoxTimes.Name = "tBoxTimes";
            tBoxTimes.Size = new Size(92, 27);
            tBoxTimes.TabIndex = 3;
            // 
            // btnGreet
            // 
            btnGreet.Location = new Point(150, 127);
            btnGreet.Name = "btnGreet";
            btnGreet.Size = new Size(159, 29);
            btnGreet.TabIndex = 4;
            btnGreet.Text = "Get greeting";
            btnGreet.UseVisualStyleBackColor = true;
            btnGreet.Click += BtnGreet_Click;
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Location = new Point(149, 175);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(15, 20);
            lblGreeting.TabIndex = 5;
            lblGreeting.Text = "..";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGreeting);
            Controls.Add(btnGreet);
            Controls.Add(tBoxTimes);
            Controls.Add(tBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "REST Service Consumer";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tBoxName;
        private TextBox tBoxTimes;
        private Button btnGreet;
        private Label lblGreeting;
    }
}