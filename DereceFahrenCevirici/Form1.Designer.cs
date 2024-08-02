namespace DereceFahrenCevirici
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDerece = new System.Windows.Forms.TextBox();
            this.txbFahre = new System.Windows.Forms.TextBox();
            this.btnFahreDonustur = new System.Windows.Forms.Button();
            this.btnDereceDonustur = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.btnKelvindenDerece = new System.Windows.Forms.Button();
            this.txbKelvin = new System.Windows.Forms.TextBox();
            this.lbKelvin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Derece";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahre";
            // 
            // txbDerece
            // 
            this.txbDerece.Location = new System.Drawing.Point(33, 91);
            this.txbDerece.Name = "txbDerece";
            this.txbDerece.Size = new System.Drawing.Size(100, 20);
            this.txbDerece.TabIndex = 2;
            // 
            // txbFahre
            // 
            this.txbFahre.Location = new System.Drawing.Point(176, 91);
            this.txbFahre.Name = "txbFahre";
            this.txbFahre.Size = new System.Drawing.Size(100, 20);
            this.txbFahre.TabIndex = 3;
            // 
            // btnFahreDonustur
            // 
            this.btnFahreDonustur.Location = new System.Drawing.Point(49, 144);
            this.btnFahreDonustur.Name = "btnFahreDonustur";
            this.btnFahreDonustur.Size = new System.Drawing.Size(75, 48);
            this.btnFahreDonustur.TabIndex = 4;
            this.btnFahreDonustur.Text = "Fahre Donustur";
            this.btnFahreDonustur.UseVisualStyleBackColor = true;
            this.btnFahreDonustur.Click += new System.EventHandler(this.btnFahreDonustur_Click);
            // 
            // btnDereceDonustur
            // 
            this.btnDereceDonustur.Location = new System.Drawing.Point(186, 144);
            this.btnDereceDonustur.Name = "btnDereceDonustur";
            this.btnDereceDonustur.Size = new System.Drawing.Size(75, 48);
            this.btnDereceDonustur.TabIndex = 5;
            this.btnDereceDonustur.Text = "Dereceye Donustur";
            this.btnDereceDonustur.UseVisualStyleBackColor = true;
            this.btnDereceDonustur.Click += new System.EventHandler(this.btnDereceDonustur_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Location = new System.Drawing.Point(201, 293);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(38, 13);
            this.lbSonuc.TabIndex = 6;
            this.lbSonuc.Text = "Sonuc";
            // 
            // btnKelvindenDerece
            // 
            this.btnKelvindenDerece.Location = new System.Drawing.Point(311, 144);
            this.btnKelvindenDerece.Name = "btnKelvindenDerece";
            this.btnKelvindenDerece.Size = new System.Drawing.Size(75, 48);
            this.btnKelvindenDerece.TabIndex = 9;
            this.btnKelvindenDerece.Text = "Dereceye Donustur";
            this.btnKelvindenDerece.UseVisualStyleBackColor = true;
            this.btnKelvindenDerece.Click += new System.EventHandler(this.btnKelvindenDerece_Click);
            // 
            // txbKelvin
            // 
            this.txbKelvin.Location = new System.Drawing.Point(301, 91);
            this.txbKelvin.Name = "txbKelvin";
            this.txbKelvin.Size = new System.Drawing.Size(100, 20);
            this.txbKelvin.TabIndex = 8;
            // 
            // lbKelvin
            // 
            this.lbKelvin.AutoSize = true;
            this.lbKelvin.Location = new System.Drawing.Point(330, 59);
            this.lbKelvin.Name = "lbKelvin";
            this.lbKelvin.Size = new System.Drawing.Size(36, 13);
            this.lbKelvin.TabIndex = 7;
            this.lbKelvin.Text = "Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.btnKelvindenDerece);
            this.Controls.Add(this.txbKelvin);
            this.Controls.Add(this.lbKelvin);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.btnDereceDonustur);
            this.Controls.Add(this.btnFahreDonustur);
            this.Controls.Add(this.txbFahre);
            this.Controls.Add(this.txbDerece);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDerece;
        private System.Windows.Forms.TextBox txbFahre;
        private System.Windows.Forms.Button btnFahreDonustur;
        private System.Windows.Forms.Button btnDereceDonustur;
        private System.Windows.Forms.Label lbSonuc;
        private System.Windows.Forms.Button btnKelvindenDerece;
        private System.Windows.Forms.TextBox txbKelvin;
        private System.Windows.Forms.Label lbKelvin;
    }
}

