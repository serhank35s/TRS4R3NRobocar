
namespace WindowsFormsApp1
{
    partial class araba_kontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(araba_kontrol));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bluetooth_ac = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dur = new System.Windows.Forms.Button();
            this.sag_asagi_capraz = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.sol_asagi_capraz = new System.Windows.Forms.Button();
            this.saga = new System.Windows.Forms.Button();
            this.sola = new System.Windows.Forms.Button();
            this.sag_capraz = new System.Windows.Forms.Button();
            this.ileri = new System.Windows.Forms.Button();
            this.sol_capraz = new System.Windows.Forms.Button();
            this.hiz_cubugu = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bluetooth_kapa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiz_cubugu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bluetooth_ac);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağlantı Ayarları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(151, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "KAPALI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bağlantı Durumu :";
            // 
            // bluetooth_ac
            // 
            this.bluetooth_ac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bluetooth_ac.ForeColor = System.Drawing.Color.Red;
            this.bluetooth_ac.Location = new System.Drawing.Point(0, 39);
            this.bluetooth_ac.Name = "bluetooth_ac";
            this.bluetooth_ac.Size = new System.Drawing.Size(210, 23);
            this.bluetooth_ac.TabIndex = 1;
            this.bluetooth_ac.TabStop = false;
            this.bluetooth_ac.Text = "RoboCar\'a Bağlan";
            this.bluetooth_ac.UseVisualStyleBackColor = true;
            this.bluetooth_ac.Click += new System.EventHandler(this.bluetooth_ac_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dur);
            this.groupBox2.Controls.Add(this.sag_asagi_capraz);
            this.groupBox2.Controls.Add(this.geri);
            this.groupBox2.Controls.Add(this.sol_asagi_capraz);
            this.groupBox2.Controls.Add(this.saga);
            this.groupBox2.Controls.Add(this.sola);
            this.groupBox2.Controls.Add(this.sag_capraz);
            this.groupBox2.Controls.Add(this.ileri);
            this.groupBox2.Controls.Add(this.sol_capraz);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontrol Mekanizması";
            // 
            // dur
            // 
            this.dur.BackColor = System.Drawing.Color.Red;
            this.dur.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold);
            this.dur.ForeColor = System.Drawing.Color.Black;
            this.dur.Location = new System.Drawing.Point(82, 87);
            this.dur.Name = "dur";
            this.dur.Size = new System.Drawing.Size(56, 46);
            this.dur.TabIndex = 9;
            this.dur.TabStop = false;
            this.dur.Text = "STOP";
            this.dur.UseVisualStyleBackColor = false;
            // 
            // sag_asagi_capraz
            // 
            this.sag_asagi_capraz.BackColor = System.Drawing.Color.Red;
            this.sag_asagi_capraz.ForeColor = System.Drawing.Color.Black;
            this.sag_asagi_capraz.Location = new System.Drawing.Point(154, 138);
            this.sag_asagi_capraz.Name = "sag_asagi_capraz";
            this.sag_asagi_capraz.Size = new System.Drawing.Size(56, 46);
            this.sag_asagi_capraz.TabIndex = 8;
            this.sag_asagi_capraz.TabStop = false;
            this.sag_asagi_capraz.Text = " ↘";
            this.sag_asagi_capraz.UseVisualStyleBackColor = false;
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.Red;
            this.geri.ForeColor = System.Drawing.Color.Black;
            this.geri.Location = new System.Drawing.Point(82, 138);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(56, 46);
            this.geri.TabIndex = 7;
            this.geri.TabStop = false;
            this.geri.Text = "↓";
            this.geri.UseVisualStyleBackColor = false;
            // 
            // sol_asagi_capraz
            // 
            this.sol_asagi_capraz.BackColor = System.Drawing.Color.Red;
            this.sol_asagi_capraz.ForeColor = System.Drawing.Color.Black;
            this.sol_asagi_capraz.Location = new System.Drawing.Point(11, 138);
            this.sol_asagi_capraz.Name = "sol_asagi_capraz";
            this.sol_asagi_capraz.Size = new System.Drawing.Size(56, 46);
            this.sol_asagi_capraz.TabIndex = 6;
            this.sol_asagi_capraz.TabStop = false;
            this.sol_asagi_capraz.Text = "↙  ";
            this.sol_asagi_capraz.UseVisualStyleBackColor = false;
            // 
            // saga
            // 
            this.saga.BackColor = System.Drawing.Color.Red;
            this.saga.ForeColor = System.Drawing.Color.Black;
            this.saga.Location = new System.Drawing.Point(154, 86);
            this.saga.Name = "saga";
            this.saga.Size = new System.Drawing.Size(56, 46);
            this.saga.TabIndex = 5;
            this.saga.TabStop = false;
            this.saga.Text = "→";
            this.saga.UseVisualStyleBackColor = false;
            // 
            // sola
            // 
            this.sola.BackColor = System.Drawing.Color.Red;
            this.sola.ForeColor = System.Drawing.Color.Black;
            this.sola.Location = new System.Drawing.Point(11, 87);
            this.sola.Name = "sola";
            this.sola.Size = new System.Drawing.Size(56, 46);
            this.sola.TabIndex = 3;
            this.sola.TabStop = false;
            this.sola.Text = "←";
            this.sola.UseVisualStyleBackColor = false;
            // 
            // sag_capraz
            // 
            this.sag_capraz.BackColor = System.Drawing.Color.Red;
            this.sag_capraz.ForeColor = System.Drawing.Color.Black;
            this.sag_capraz.Location = new System.Drawing.Point(154, 35);
            this.sag_capraz.Name = "sag_capraz";
            this.sag_capraz.Size = new System.Drawing.Size(56, 46);
            this.sag_capraz.TabIndex = 2;
            this.sag_capraz.TabStop = false;
            this.sag_capraz.Text = "↗ ";
            this.sag_capraz.UseVisualStyleBackColor = false;
            // 
            // ileri
            // 
            this.ileri.BackColor = System.Drawing.Color.Red;
            this.ileri.ForeColor = System.Drawing.Color.Black;
            this.ileri.Location = new System.Drawing.Point(82, 35);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(56, 46);
            this.ileri.TabIndex = 1;
            this.ileri.TabStop = false;
            this.ileri.Text = "↑ ";
            this.ileri.UseVisualStyleBackColor = false;
            // 
            // sol_capraz
            // 
            this.sol_capraz.BackColor = System.Drawing.Color.Red;
            this.sol_capraz.ForeColor = System.Drawing.Color.Black;
            this.sol_capraz.Location = new System.Drawing.Point(11, 35);
            this.sol_capraz.Name = "sol_capraz";
            this.sol_capraz.Size = new System.Drawing.Size(56, 46);
            this.sol_capraz.TabIndex = 0;
            this.sol_capraz.TabStop = false;
            this.sol_capraz.Text = "↖";
            this.sol_capraz.UseVisualStyleBackColor = false;
            // 
            // hiz_cubugu
            // 
            this.hiz_cubugu.Location = new System.Drawing.Point(6, 55);
            this.hiz_cubugu.Maximum = 5;
            this.hiz_cubugu.Minimum = 1;
            this.hiz_cubugu.Name = "hiz_cubugu";
            this.hiz_cubugu.Size = new System.Drawing.Size(252, 45);
            this.hiz_cubugu.TabIndex = 10;
            this.hiz_cubugu.Value = 1;
            this.hiz_cubugu.Scroll += new System.EventHandler(this.hiz_cubugu_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.bluetooth_kapa);
            this.groupBox3.Controls.Add(this.hiz_cubugu);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(241, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 344);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hız Göstergesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "© Programmed By Serhan Kırca ©";
            // 
            // bluetooth_kapa
            // 
            this.bluetooth_kapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bluetooth_kapa.ForeColor = System.Drawing.Color.Red;
            this.bluetooth_kapa.Location = new System.Drawing.Point(23, 189);
            this.bluetooth_kapa.Name = "bluetooth_kapa";
            this.bluetooth_kapa.Size = new System.Drawing.Size(210, 23);
            this.bluetooth_kapa.TabIndex = 11;
            this.bluetooth_kapa.TabStop = false;
            this.bluetooth_kapa.Text = "RoboCar\'ın Bağlantısını Kes";
            this.bluetooth_kapa.UseVisualStyleBackColor = true;
            this.bluetooth_kapa.Click += new System.EventHandler(this.bluetooth_kapa_Click);
            // 
            // araba_kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(517, 369);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "araba_kontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRS4R3N RoboCar Masaüstü Yazılımı";
            this.Load += new System.EventHandler(this.araba_kontrol_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.araba_kontrol_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.araba_kontrol_KeyUp_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hiz_cubugu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bluetooth_ac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dur;
        private System.Windows.Forms.Button sag_asagi_capraz;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button sol_asagi_capraz;
        private System.Windows.Forms.Button saga;
        private System.Windows.Forms.Button sola;
        private System.Windows.Forms.Button sag_capraz;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Button sol_capraz;
        private System.Windows.Forms.TrackBar hiz_cubugu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bluetooth_kapa;
    }
}