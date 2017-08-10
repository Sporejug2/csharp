namespace WindowsFormsApp1
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
            this.btnLog = new System.Windows.Forms.Button();
            this.btnispis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.tb9 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb8 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(12, 12);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnispis
            // 
            this.btnispis.Location = new System.Drawing.Point(12, 64);
            this.btnispis.Name = "btnispis";
            this.btnispis.Size = new System.Drawing.Size(75, 23);
            this.btnispis.TabIndex = 1;
            this.btnispis.Text = "Ispis";
            this.btnispis.UseVisualStyleBackColor = true;
            this.btnispis.Click += new System.EventHandler(this.btnispis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "cause";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(169, 15);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 4;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(169, 47);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 5;
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(348, 19);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(221, 210);
            this.rtb.TabIndex = 6;
            this.rtb.Text = "";
            this.rtb.TextChanged += new System.EventHandler(this.rtb_TextChanged);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 281);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "Exit";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Unos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(169, 85);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(100, 20);
            this.tb4.TabIndex = 10;
            // 
            // tb6
            // 
            this.tb6.Location = new System.Drawing.Point(169, 159);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(100, 20);
            this.tb6.TabIndex = 11;
            this.tb6.TextChanged += new System.EventHandler(this.tb6_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "longitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ratingP";
            // 
            // tb7
            // 
            this.tb7.Location = new System.Drawing.Point(169, 189);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(100, 20);
            this.tb7.TabIndex = 17;
            // 
            // tb9
            // 
            this.tb9.Location = new System.Drawing.Point(169, 257);
            this.tb9.Name = "tb9";
            this.tb9.Size = new System.Drawing.Size(100, 20);
            this.tb9.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "RatingM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "ban";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "direction";
            // 
            // tb8
            // 
            this.tb8.Location = new System.Drawing.Point(169, 223);
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(100, 20);
            this.tb8.TabIndex = 22;
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(169, 128);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(100, 20);
            this.tb5.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "latitude";
            // 
            // tb10
            // 
            this.tb10.Location = new System.Drawing.Point(169, 284);
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(100, 20);
            this.tb10.TabIndex = 25;
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(109, 294);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(38, 13);
            this.UserID.TabIndex = 26;
            this.UserID.Text = "UserId";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 316);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.tb10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb9);
            this.Controls.Add(this.tb7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb6);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnispis);
            this.Controls.Add(this.btnLog);
            this.Name = "Form1";
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnispis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.TextBox tb9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb8;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.Label UserID;
    }
}

