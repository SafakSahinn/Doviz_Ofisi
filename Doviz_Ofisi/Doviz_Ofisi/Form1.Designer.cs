
namespace Doviz_Ofisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LblDolarAlis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDolarSatis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblEuroAlis = new System.Windows.Forms.Label();
            this.LblEuroSatis = new System.Windows.Forms.Label();
            this.BtnDolarAl = new System.Windows.Forms.Button();
            this.TxtKur = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnDolarSat = new System.Windows.Forms.Button();
            this.BtnEuroSat = new System.Windows.Forms.Button();
            this.BtnEuroAl = new System.Windows.Forms.Button();
            this.BtnSatişYap = new System.Windows.Forms.Button();
            this.BtnSatisYap2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // LblDolarAlis
            // 
            this.LblDolarAlis.AutoSize = true;
            this.LblDolarAlis.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDolarAlis.ForeColor = System.Drawing.Color.White;
            this.LblDolarAlis.Location = new System.Drawing.Point(146, 18);
            this.LblDolarAlis.Name = "LblDolarAlis";
            this.LblDolarAlis.Size = new System.Drawing.Size(25, 25);
            this.LblDolarAlis.TabIndex = 1;
            this.LblDolarAlis.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dolar Satış:";
            // 
            // LblDolarSatis
            // 
            this.LblDolarSatis.AutoSize = true;
            this.LblDolarSatis.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDolarSatis.ForeColor = System.Drawing.Color.White;
            this.LblDolarSatis.Location = new System.Drawing.Point(146, 64);
            this.LblDolarSatis.Name = "LblDolarSatis";
            this.LblDolarSatis.Size = new System.Drawing.Size(25, 25);
            this.LblDolarSatis.TabIndex = 3;
            this.LblDolarSatis.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Euro Alış:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Euro Satış:";
            // 
            // LblEuroAlis
            // 
            this.LblEuroAlis.AutoSize = true;
            this.LblEuroAlis.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEuroAlis.ForeColor = System.Drawing.Color.White;
            this.LblEuroAlis.Location = new System.Drawing.Point(146, 156);
            this.LblEuroAlis.Name = "LblEuroAlis";
            this.LblEuroAlis.Size = new System.Drawing.Size(25, 25);
            this.LblEuroAlis.TabIndex = 6;
            this.LblEuroAlis.Text = "0";
            // 
            // LblEuroSatis
            // 
            this.LblEuroSatis.AutoSize = true;
            this.LblEuroSatis.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEuroSatis.ForeColor = System.Drawing.Color.White;
            this.LblEuroSatis.Location = new System.Drawing.Point(146, 202);
            this.LblEuroSatis.Name = "LblEuroSatis";
            this.LblEuroSatis.Size = new System.Drawing.Size(25, 25);
            this.LblEuroSatis.TabIndex = 7;
            this.LblEuroSatis.Text = "0";
            // 
            // BtnDolarAl
            // 
            this.BtnDolarAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDolarAl.Location = new System.Drawing.Point(249, 12);
            this.BtnDolarAl.Name = "BtnDolarAl";
            this.BtnDolarAl.Size = new System.Drawing.Size(40, 40);
            this.BtnDolarAl.TabIndex = 8;
            this.BtnDolarAl.Text = "...";
            this.BtnDolarAl.UseVisualStyleBackColor = true;
            this.BtnDolarAl.Click += new System.EventHandler(this.BtnDolarAl_Click);
            // 
            // TxtKur
            // 
            this.TxtKur.Location = new System.Drawing.Point(96, 25);
            this.TxtKur.Name = "TxtKur";
            this.TxtKur.Size = new System.Drawing.Size(167, 26);
            this.TxtKur.TabIndex = 9;
            this.TxtKur.TextChanged += new System.EventHandler(this.TxtKur_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnSatisYap2);
            this.groupBox1.Controls.Add(this.BtnSatişYap);
            this.groupBox1.Controls.Add(this.TxtKalan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtMiktar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtKur);
            this.groupBox1.Location = new System.Drawing.Point(356, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 207);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Kur:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Miktar:";
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(96, 57);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(167, 26);
            this.TxtMiktar.TabIndex = 13;
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(96, 89);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(167, 26);
            this.TxtTutar.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tutar:";
            // 
            // TxtKalan
            // 
            this.TxtKalan.Location = new System.Drawing.Point(96, 121);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(167, 26);
            this.TxtKalan.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Kalan:";
            // 
            // BtnDolarSat
            // 
            this.BtnDolarSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDolarSat.Location = new System.Drawing.Point(249, 58);
            this.BtnDolarSat.Name = "BtnDolarSat";
            this.BtnDolarSat.Size = new System.Drawing.Size(40, 40);
            this.BtnDolarSat.TabIndex = 11;
            this.BtnDolarSat.Text = "...";
            this.BtnDolarSat.UseVisualStyleBackColor = true;
            this.BtnDolarSat.Click += new System.EventHandler(this.BtnDolarSat_Click);
            // 
            // BtnEuroSat
            // 
            this.BtnEuroSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEuroSat.Location = new System.Drawing.Point(249, 196);
            this.BtnEuroSat.Name = "BtnEuroSat";
            this.BtnEuroSat.Size = new System.Drawing.Size(40, 40);
            this.BtnEuroSat.TabIndex = 12;
            this.BtnEuroSat.Text = "...";
            this.BtnEuroSat.UseVisualStyleBackColor = true;
            this.BtnEuroSat.Click += new System.EventHandler(this.BtnEuroSat_Click);
            // 
            // BtnEuroAl
            // 
            this.BtnEuroAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEuroAl.Location = new System.Drawing.Point(249, 150);
            this.BtnEuroAl.Name = "BtnEuroAl";
            this.BtnEuroAl.Size = new System.Drawing.Size(40, 40);
            this.BtnEuroAl.TabIndex = 13;
            this.BtnEuroAl.Text = "...";
            this.BtnEuroAl.UseVisualStyleBackColor = true;
            this.BtnEuroAl.Click += new System.EventHandler(this.BtnEuroAl_Click);
            // 
            // BtnSatişYap
            // 
            this.BtnSatişYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSatişYap.Location = new System.Drawing.Point(16, 153);
            this.BtnSatişYap.Name = "BtnSatişYap";
            this.BtnSatişYap.Size = new System.Drawing.Size(118, 40);
            this.BtnSatişYap.TabIndex = 14;
            this.BtnSatişYap.Text = "İŞLEM 1";
            this.BtnSatişYap.UseVisualStyleBackColor = true;
            this.BtnSatişYap.Click += new System.EventHandler(this.BtnSatişYap_Click);
            // 
            // BtnSatisYap2
            // 
            this.BtnSatisYap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSatisYap2.Location = new System.Drawing.Point(145, 153);
            this.BtnSatisYap2.Name = "BtnSatisYap2";
            this.BtnSatisYap2.Size = new System.Drawing.Size(118, 40);
            this.BtnSatisYap2.TabIndex = 18;
            this.BtnSatisYap2.Text = "İŞLEM 2";
            this.BtnSatisYap2.UseVisualStyleBackColor = true;
            this.BtnSatisYap2.Click += new System.EventHandler(this.BtnSatisYap2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(759, 444);
            this.Controls.Add(this.BtnEuroAl);
            this.Controls.Add(this.BtnEuroSat);
            this.Controls.Add(this.BtnDolarSat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDolarAl);
            this.Controls.Add(this.LblEuroSatis);
            this.Controls.Add(this.LblEuroAlis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblDolarSatis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblDolarAlis);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DÖVİZ BÜROSU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDolarAlis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblDolarSatis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblEuroAlis;
        private System.Windows.Forms.Label LblEuroSatis;
        private System.Windows.Forms.Button BtnDolarAl;
        private System.Windows.Forms.TextBox TxtKur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSatişYap;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnDolarSat;
        private System.Windows.Forms.Button BtnEuroSat;
        private System.Windows.Forms.Button BtnEuroAl;
        private System.Windows.Forms.Button BtnSatisYap2;
    }
}

