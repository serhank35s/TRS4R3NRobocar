using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class baslangic_ekrani : Form
    {
        public baslangic_ekrani()
        {
            InitializeComponent();
        }
        private static int i = 0;
        private void baslangic_ekrani_Load(object sender, EventArgs e)
        {
            zamanlayici.Start();
        }

        private void zamanlayici_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = "%" + i;
            progressBar1.Value = i;
            switch (i)
            {
                case 10:
                    {
                        progressBar1.ForeColor = Color.Red;
                        break;
                    }
                case 20:
                    {
                        progressBar1.ForeColor = Color.Yellow;
                        break;
                    }
                case 30:
                    {
                        progressBar1.ForeColor = Color.Green;
                        break;
                    }
                case 40:
                    {
                        progressBar1.ForeColor = Color.Orange;
                        break;
                    }
                case 50:
                    {
                        progressBar1.ForeColor = Color.Blue;
                        break;
                    }
                case 60:
                    {
                        progressBar1.ForeColor = Color.Brown;
                        break;
                    }
                case 70:
                    {
                        progressBar1.ForeColor = Color.Black;
                        break;
                    }
                case 80:
                    {
                        progressBar1.ForeColor = Color.Pink;
                        break;
                    }
                case 90:
                    {
                        progressBar1.ForeColor = Color.Purple;
                        break;
                    }
                case 100:
                    {
                        progressBar1.ForeColor = Color.Violet;
                        break;
                    }
            }
            if (i == 100)
            {
                zamanlayici.Stop();
                araba_kontrol a = new araba_kontrol();
                a.Show();
                Hide();
            }
        }
    }
}
