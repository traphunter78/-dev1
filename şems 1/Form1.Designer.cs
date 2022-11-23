
namespace şems_1
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
            this.btnHesap = new System.Windows.Forms.Button();
            this.lxbx2 = new System.Windows.Forms.ListBox();
            this.lxbx1 = new System.Windows.Forms.ListBox();
            this.txbxİlk = new System.Windows.Forms.TextBox();
            this.txbxBit = new System.Windows.Forms.TextBox();
            this.txbx1Bol = new System.Windows.Forms.TextBox();
            this.txbx2Bol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(425, 360);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(75, 23);
            this.btnHesap.TabIndex = 0;
            this.btnHesap.Text = "hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.button1_Click);
            // 
            // lxbx2
            // 
            this.lxbx2.FormattingEnabled = true;
            this.lxbx2.Location = new System.Drawing.Point(590, 65);
            this.lxbx2.Name = "lxbx2";
            this.lxbx2.Size = new System.Drawing.Size(120, 264);
            this.lxbx2.TabIndex = 1;
            // 
            // lxbx1
            // 
            this.lxbx1.FormattingEnabled = true;
            this.lxbx1.Location = new System.Drawing.Point(425, 65);
            this.lxbx1.Name = "lxbx1";
            this.lxbx1.Size = new System.Drawing.Size(120, 264);
            this.lxbx1.TabIndex = 2;
            // 
            // txbxİlk
            // 
            this.txbxİlk.Location = new System.Drawing.Point(175, 65);
            this.txbxİlk.Name = "txbxİlk";
            this.txbxİlk.Size = new System.Drawing.Size(100, 20);
            this.txbxİlk.TabIndex = 3;
            // 
            // txbxBit
            // 
            this.txbxBit.Location = new System.Drawing.Point(175, 113);
            this.txbxBit.Name = "txbxBit";
            this.txbxBit.Size = new System.Drawing.Size(100, 20);
            this.txbxBit.TabIndex = 4;
            // 
            // txbx1Bol
            // 
            this.txbx1Bol.Location = new System.Drawing.Point(175, 215);
            this.txbx1Bol.Name = "txbx1Bol";
            this.txbx1Bol.Size = new System.Drawing.Size(100, 20);
            this.txbx1Bol.TabIndex = 5;
            // 
            // txbx2Bol
            // 
            this.txbx2Bol.Location = new System.Drawing.Point(175, 254);
            this.txbx2Bol.Name = "txbx2Bol";
            this.txbx2Bol.Size = new System.Drawing.Size(100, 20);
            this.txbx2Bol.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ilk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "bitiş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "1.böl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "2.böl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(817, 420);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx2Bol);
            this.Controls.Add(this.txbx1Bol);
            this.Controls.Add(this.txbxBit);
            this.Controls.Add(this.txbxİlk);
            this.Controls.Add(this.lxbx1);
            this.Controls.Add(this.lxbx2);
            this.Controls.Add(this.btnHesap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.ListBox lxbx2;
        private System.Windows.Forms.ListBox lxbx1;
        private System.Windows.Forms.TextBox txbxİlk;
        private System.Windows.Forms.TextBox txbxBit;
        private System.Windows.Forms.TextBox txbx1Bol;
        private System.Windows.Forms.TextBox txbx2Bol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

