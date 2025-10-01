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
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tBoxName = new TextBox();
            tBoxTimes = new TextBox();
            btnGreet = new Button();
            tBoxNickname = new TextBox();
            lblNickname = new Label();
            lblGreeting = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 187);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Times:";
            // 
            // tBoxName
            // 
            tBoxName.Location = new Point(175, 71);
            tBoxName.Margin = new Padding(4);
            tBoxName.Name = "tBoxName";
            tBoxName.Size = new Size(199, 31);
            tBoxName.TabIndex = 2;
            // 
            // tBoxTimes
            // 
            tBoxTimes.Location = new Point(175, 216);
            tBoxTimes.Margin = new Padding(4);
            tBoxTimes.Name = "tBoxTimes";
            tBoxTimes.Size = new Size(199, 31);
            tBoxTimes.TabIndex = 3;
            // 
            // btnGreet
            // 
            btnGreet.Location = new Point(175, 332);
            btnGreet.Margin = new Padding(4);
            btnGreet.Name = "btnGreet";
            btnGreet.Size = new Size(199, 36);
            btnGreet.TabIndex = 4;
            btnGreet.Text = "Get greeting";
            btnGreet.UseVisualStyleBackColor = true;
            btnGreet.Click += BtnGreet_Click;
            // 
            // tBoxNickname
            // 
            tBoxNickname.Location = new Point(175, 153);
            tBoxNickname.Name = "tBoxNickname";
            tBoxNickname.Size = new Size(199, 31);
            tBoxNickname.TabIndex = 6;
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Location = new Point(177, 119);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(90, 25);
            lblNickname.TabIndex = 7;
            lblNickname.Text = "Nickname";
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Location = new Point(175, 372);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(0, 25);
            lblGreeting.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(lblGreeting);
            Controls.Add(lblNickname);
            Controls.Add(tBoxNickname);
            Controls.Add(btnGreet);
            Controls.Add(tBoxTimes);
            Controls.Add(tBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
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
        private TextBox tBoxNickname;
        private Label lblNickname;
        private Label lblGreeting;
    }
}