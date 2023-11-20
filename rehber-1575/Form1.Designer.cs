namespace rehber_1575
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
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lbAdlar = new System.Windows.Forms.ListBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(13, 13);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(120, 20);
            this.txtAranan.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(146, 9);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 25);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lbAdlar
            // 
            this.lbAdlar.FormattingEnabled = true;
            this.lbAdlar.Items.AddRange(new object[] {
            "Raito",
            "Hilal de souza ",
            "Müco",
            "Raito",
            "Ravza ",
            "Yezna",
            "Mshel",
            "Q7",
            " Eda Balim",
            "Raito",
            "Raito",
            "Ayyüce",
            "Hilalin aneyi",
            "Eda Balim",
            "Hilal de souza",
            "Müco",
            "Rosier",
            "Q7",
            "Ayyüce",
            "Yezna",
            "Hilalin aneyi",
            "Müco",
            "Eda Balim"});
            this.lbAdlar.Location = new System.Drawing.Point(12, 49);
            this.lbAdlar.Name = "lbAdlar";
            this.lbAdlar.Size = new System.Drawing.Size(120, 251);
            this.lbAdlar.TabIndex = 2;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(13, 346);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(42, 13);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "sonuç :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 398);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lbAdlar);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAranan);
            this.Name = "Form1";
            this.Text = "REHBER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ListBox lbAdlar;
        private System.Windows.Forms.Label lblSonuc;
    }
}

