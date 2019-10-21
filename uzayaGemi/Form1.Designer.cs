namespace uzayaGemi
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
            this.alinanlar = new System.Windows.Forms.ListBox();
            this.topKilo = new System.Windows.Forms.Label();
            this.topDeger = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alinanlar
            // 
            this.alinanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alinanlar.FormattingEnabled = true;
            this.alinanlar.ItemHeight = 24;
            this.alinanlar.Location = new System.Drawing.Point(12, 60);
            this.alinanlar.Name = "alinanlar";
            this.alinanlar.Size = new System.Drawing.Size(389, 364);
            this.alinanlar.TabIndex = 0;
            // 
            // topKilo
            // 
            this.topKilo.AutoSize = true;
            this.topKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topKilo.Location = new System.Drawing.Point(426, 147);
            this.topKilo.Name = "topKilo";
            this.topKilo.Size = new System.Drawing.Size(131, 25);
            this.topKilo.TabIndex = 1;
            this.topKilo.Text = "Toplam Kilo:";
            // 
            // topDeger
            // 
            this.topDeger.AutoSize = true;
            this.topDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topDeger.Location = new System.Drawing.Point(426, 238);
            this.topDeger.Name = "topDeger";
            this.topDeger.Size = new System.Drawing.Size(153, 25);
            this.topDeger.TabIndex = 2;
            this.topDeger.Text = "Toplam Deger:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alınan Eşyalar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topDeger);
            this.Controls.Add(this.topKilo);
            this.Controls.Add(this.alinanlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox alinanlar;
        private System.Windows.Forms.Label topKilo;
        private System.Windows.Forms.Label topDeger;
        private System.Windows.Forms.Label label1;
    }
}

