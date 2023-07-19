using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Televisor_antiñolo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Televisor gestor = new Televisor();

        //Prendido y Apagado
        private void btnPower_Click(object sender, EventArgs e)
        {
            if (gestor.validacion == false)
            {
                gestor.validacion = true;
                pantalla.Image = Image.FromFile(gestor.imagenes[gestor.canal]) ;
                btnBajaVol.Enabled = true;
                btnSubeVol.Enabled = true;
                btnBajaCanal.Enabled = true;
                btnSubeCanal.Enabled = true;
                numericUpDown1.Enabled = true; 
                btnNumer.Enabled = true;
                btnBrow.Enabled = true;
                btnMute.Enabled = true;
            }
            else
            {
                gestor.validacion = false;
                pantalla.Image = null;
               
                btnBajaVol.Enabled = false;
                btnSubeVol.Enabled = false;
                btnBajaCanal.Enabled = false;
                btnSubeCanal.Enabled = false;
                numericUpDown1.Enabled = false;
                btnNumer.Enabled = false;
                btnBrow .Enabled = false;
                btnMute .Enabled = false;
                webBrowser1.Visible = false;
                validationBrow = false;
                lblMute.Visible = false;
                gestor.validationMute = false;

            }
        }


        private void btnBajaVol_Click(object sender, EventArgs e)
        {
            if (gestor.validationMute == true)
            {
                lblMute.Visible = false;
                gestor.validationMute = false;
            }

            timer2.Enabled = true;
            lblVol.Visible = true;
            if (gestor.volumen > 0)
            {
                gestor.volumen--;

                lblVol.Text = $"VOLUMEN: {Convert.ToString(gestor.volumen)}";
            }
            else if (gestor.volumen == 0)
            {
                lblVol.Text = "VOLUMEN MINIMO";
            }
        }

        private void btnSubeVol_Click(object sender, EventArgs e)
        {
            if (gestor.validationMute == true)
            {
                lblMute.Visible = false;
                gestor.validationMute = false;
            }


            lblVol.Visible = true;
            timer2.Enabled = true;
            if (gestor.volumen < 50)
            {
                gestor.volumen++;

                lblVol.Text = $"VOLUMEN: { Convert.ToString(gestor.volumen)}";
            }else if(gestor.volumen == 50)
            {
                lblVol.Text = "VOLUMEN MAXIMO";
            }
        }

        private void btnBajaCanal_Click(object sender, EventArgs e)
        {
            
            lblCanal.Visible = true;
            timer1.Enabled = true;
            
            if (gestor.canal < 7)
            {
                gestor.canal++;
                lblCanal.Text = Convert.ToString(gestor.canal);
            }else if (gestor.canal == 7)
            {
                gestor.canal = 1;
                lblCanal.Text = Convert.ToString(gestor.canal);
            }
            pantalla.Image = Image.FromFile(gestor.imagenes[gestor.canal]);
        }

        private void btnSubeCanal_Click(object sender, EventArgs e)
        {

            lblCanal.Visible = true;
            timer1.Enabled = true;

            if (gestor.canal > 1)
            {
                gestor.canal--;
                lblCanal.Text = Convert.ToString(gestor.canal);
            }else if (gestor.canal == 1)
            {
                gestor.canal = 7;
                lblCanal.Text = Convert.ToString(gestor.canal);
            }
            pantalla.Image = Image.FromFile(gestor.imagenes[gestor.canal]);
        }

        private void btnNumer_Click(object sender, EventArgs e)
        {
            lblCanal.Visible = true;
            timer1.Enabled = true;
            gestor.canal = Convert.ToInt32(numericUpDown1.Value);
            lblCanal.Text = Convert.ToString(gestor.canal);
            pantalla.Image = Image.FromFile(gestor.imagenes[gestor.canal]);
        }
        
        private void btnMute_Click(object sender, EventArgs e)
        {
            if (gestor.validationMute == false)
            {
                lblMute.Visible = true;
                gestor.validationMute = true;
            }
            else
            {
                lblMute.Visible = false;
                gestor.validationMute = false;
            }
        }

        //Timers para las label de canal y volumen
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCanal.Visible = false;
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblVol.Visible = false;
            timer2.Enabled = false;
        }

        bool validationBrow = false;
        private void btnBrow_Click(object sender, EventArgs e)
        {
            if (validationBrow == false)
            {
                webBrowser1.Visible = true;
                validationBrow = true;
            }
            else
            {
                webBrowser1.Visible = false;
                validationBrow = false;
            }
        }

       
    }
}
