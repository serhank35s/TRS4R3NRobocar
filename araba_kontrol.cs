using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class araba_kontrol : Form
    {
        public araba_kontrol()
        {
            InitializeComponent();
        }
        string[] portlar = SerialPort.GetPortNames();
        SerialPort port = new SerialPort("COM9", 9600, Parity.None, 8, StopBits.One);
        private void bluetooth_ac_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                    MessageBox.Show("RoboCar İle Bağantı Kuruldu..!", "BAĞLANTI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label2.Text = "AÇIK";
                    label2.ForeColor = Color.Green;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("RoboCar Kapsama Alanı Dışında..!", "OLAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void araba_kontrol_Load(object sender, EventArgs e)
        {
            if (label2.Text == "KAPALI")
            {
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.ForeColor = Color.Green;
            }    
        }
        private void hiz_cubugu_Scroll(object sender, EventArgs e)
        {
            try
            {
                if (port.IsOpen)
                {
                   switch(hiz_cubugu.Value)
                    {
                        case 1:
                            {
                                port.Write("a");
                                break;
                            }
                        case 2:
                            {
                                port.Write("b");
                                break;
                            }
                        case 3:
                            {
                                port.Write("c");
                                break;
                            }
                        case 4:
                            {
                                port.Write("e");
                                break;
                            }
                        case 5:
                            {
                                port.Write("f");
                                break;
                            }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void bluetooth_kapa_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Close();
                label2.Text = "KAPALI";
                label2.ForeColor = Color.Red;
            }

        }

        private void araba_kontrol_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "W":
                    {
                        if (port.IsOpen)
                        {
                        port.Write("W");
                        }
                        ileri.BackColor = Color.Green;
                        ileri.ForeColor = Color.White;
                        break;
                    }
                case "S":
                    {
                        if (port.IsOpen)
                        {
                        port.Write("S");
                        }
                        geri.BackColor = Color.Green;
                        geri.ForeColor = Color.White;
                        break;
                    }
                case "A":
                    {
                        if (port.IsOpen)
                        {
                        port.Write("A");
                        }
                        sola.BackColor = Color.Green;
                        sola.ForeColor = Color.White;
                        break;
                    }
                case "D":
                    {
                        if (port.IsOpen)
                        {
                        port.Write("D");
                        }
                        saga.BackColor = Color.Green;
                        saga.ForeColor = Color.White;
                        break;
                    }
                case "Q":
                    {
                        if (port.IsOpen)
                        {
                        port.Write("Q");
                        }
                        sol_capraz.BackColor = Color.Green;
                        sol_capraz.ForeColor = Color.White;
                        break;
                    }
                case "E":
                    {
                        if (port.IsOpen)
                        {
                        port.Write("E");
                        }
                        sag_capraz.BackColor = Color.Green;
                        sag_capraz.ForeColor = Color.White;
                        break;
                    }
                case "Z":
                    {
                        if (port.IsOpen)
                        {
                        port.Write("Z");
                        }
                        sol_asagi_capraz.BackColor = Color.Green;
                        sol_asagi_capraz.ForeColor = Color.White;
                        break;
                    }
                case "C":
                    {
                        if (port.IsOpen)
                        {
                        port.Write("C");
                        }
                        sag_asagi_capraz.BackColor = Color.Green;
                        sag_asagi_capraz.ForeColor = Color.White;
                        break;
                    }
            }
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        if (port.IsOpen)
                        {
                            port.Write("W");
                        }
                        ileri.BackColor = Color.Green;
                        ileri.ForeColor = Color.White;
                        break;
                    }
                case Keys.Down:
                    {
                        if (port.IsOpen)
                        {
                            port.Write("S");
                        }
                        geri.BackColor = Color.Green;
                        geri.ForeColor = Color.White;
                        break;
                    }
                case Keys.Left:
                    {
                        if (port.IsOpen)
                        {
                            port.Write("A");
                        }
                        sola.BackColor = Color.Green;
                        sola.ForeColor = Color.White;
                        break;
                    }
                case Keys.Right:
                    {
                        if (port.IsOpen)
                        {
                            port.Write("D");
                        }
                        saga.BackColor = Color.Green;
                        saga.ForeColor = Color.White;
                        break;
                    }
                case Keys.Space:
                    {
                        if (port.IsOpen)
                        {
                            port.Write("d");
                        }
                        dur.BackColor = Color.Green;
                        dur.ForeColor = Color.White;
                        break;
                    }
            }
        }

        private void araba_kontrol_KeyUp_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "W":
                    {
                        ileri.BackColor = Color.Red;
                        ileri.ForeColor = Color.Black;
                        break;
                    }
                case "S":
                    {
                        geri.BackColor = Color.Red;
                        geri.ForeColor = Color.Black;
                        break;
                    }
                case "A":
                    {
                        sola.BackColor = Color.Red;
                        sola.ForeColor = Color.Black;
                        break;
                    }
                case "D":
                    {
                        saga.BackColor = Color.Red;
                        saga.ForeColor = Color.Black;
                        break;
                    }
                case "Q":
                    {
                        sol_capraz.BackColor = Color.Red;
                        sol_capraz.ForeColor = Color.Black;
                        break;
                    }
                case "E":
                    {
                        sag_capraz.BackColor = Color.Red;
                        sag_capraz.ForeColor = Color.Black;
                        break;
                    }
                case "Z":
                    {
                        sol_asagi_capraz.BackColor = Color.Red;
                        sol_asagi_capraz.ForeColor = Color.Black;
                        break;
                    }
                case "C":
                    {
                        sag_asagi_capraz.BackColor = Color.Red;
                        sag_asagi_capraz.ForeColor = Color.Black;
                        break;
                    }
               
            }
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        ileri.BackColor = Color.Red;
                        ileri.ForeColor = Color.Black;
                        break;
                    }
                case Keys.Down:
                    {
                        geri.BackColor = Color.Red;
                        geri.ForeColor = Color.Black;
                        break;
                    }
                case Keys.Left:
                    {
                        sola.BackColor = Color.Red;
                        sola.ForeColor = Color.Black;
                        break;
                    }
                case Keys.Right:
                    {
                        saga.BackColor = Color.Red;
                        saga.ForeColor = Color.Black;
                        break;
                    }
                     case Keys.Space:
                    {
                        dur.BackColor = Color.Red;
                        dur.ForeColor = Color.Black;
                        break;
                    }
            }
        }
    }
}
