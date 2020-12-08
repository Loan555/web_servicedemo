namespace ThuVien
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
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VND2USD = new System.Windows.Forms.Button();
            this.VND2EUR = new System.Windows.Forms.Button();
            this.USD2VND = new System.Windows.Forms.Button();
            this.EUR2VND = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(181, 97);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(352, 26);
            this.txtMoney.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiền quy đổi";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblKetQua.Location = new System.Drawing.Point(177, 226);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 20);
            this.lblKetQua.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kết quả";
            // 
            // VND2USD
            // 
            this.VND2USD.Location = new System.Drawing.Point(28, 155);
            this.VND2USD.Name = "VND2USD";
            this.VND2USD.Size = new System.Drawing.Size(114, 36);
            this.VND2USD.TabIndex = 5;
            this.VND2USD.Text = "VND2USD";
            this.VND2USD.UseVisualStyleBackColor = true;
            this.VND2USD.Click += new System.EventHandler(this.VND2USD_Click);
            // 
            // VND2EUR
            // 
            this.VND2EUR.Location = new System.Drawing.Point(148, 155);
            this.VND2EUR.Name = "VND2EUR";
            this.VND2EUR.Size = new System.Drawing.Size(114, 36);
            this.VND2EUR.TabIndex = 6;
            this.VND2EUR.Text = "VND2EUR";
            this.VND2EUR.UseVisualStyleBackColor = true;
            this.VND2EUR.Click += new System.EventHandler(this.VND2EUR_Click);
            // 
            // USD2VND
            // 
            this.USD2VND.Location = new System.Drawing.Point(284, 154);
            this.USD2VND.Name = "USD2VND";
            this.USD2VND.Size = new System.Drawing.Size(114, 36);
            this.USD2VND.TabIndex = 7;
            this.USD2VND.Text = "USD2VND";
            this.USD2VND.UseVisualStyleBackColor = true;
            this.USD2VND.Click += new System.EventHandler(this.USD2VND_Click);
            // 
            // EUR2VND
            // 
            this.EUR2VND.Location = new System.Drawing.Point(419, 155);
            this.EUR2VND.Name = "EUR2VND";
            this.EUR2VND.Size = new System.Drawing.Size(114, 36);
            this.EUR2VND.TabIndex = 8;
            this.EUR2VND.Text = "EUR2VND";
            this.EUR2VND.UseVisualStyleBackColor = true;
            this.EUR2VND.Click += new System.EventHandler(this.EUR2VND_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 306);
            this.Controls.Add(this.EUR2VND);
            this.Controls.Add(this.USD2VND);
            this.Controls.Add(this.VND2EUR);
            this.Controls.Add(this.VND2USD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoney);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VND2USD;
        private System.Windows.Forms.Button VND2EUR;
        private System.Windows.Forms.Button USD2VND;
        private System.Windows.Forms.Button EUR2VND;
    }
}

