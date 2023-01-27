using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoC;
using static System.Net.Mime.MediaTypeNames;

namespace DistanciaEntrePuntosC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPunto1.Text = "";
            txtPunto2.Text = "";
            txtResultado.Text = "";
            adver.Visible= false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (adver.Visible == false)
            {
                int x1 = 0;
                int x2 = 0;
                int y1 = 0;
                int y2 = 0;
                int part = 0;
                string aux = "";
                for (int i = 0; i < txtPunto1.Text.Length; i++)
                {
                    if (part == 0)
                    {
                        if (txtPunto1.Text.Substring(i, 1) == ",")
                        {
                            part = 1;
                            x1 = Convert.ToInt32(aux);
                            aux = "";
                        }
                        else
                        {
                            if (txtPunto1.Text.Substring(i, 1) != "(")
                            {
                                aux += txtPunto1.Text.Substring(i, 1);
                            }
                        }
                    }
                    else
                    {
                        if (txtPunto1.Text.Substring(i, 1) == ")")
                        {
                            part = 0;
                            y1 = Convert.ToInt32(aux);
                            aux = "";
                        }
                        else
                        {
                            aux += txtPunto1.Text.Substring(i, 1);
                        }
                    }
                }

                for (int i = 0; i < txtPunto2.Text.Length; i++)
                {
                    if (part == 0)
                    {
                        if (txtPunto2.Text.Substring(i, 1) == ",")
                        {
                            part = 1;
                            x2 = Convert.ToInt32(aux);
                            aux = "";
                        }
                        else
                        {
                            if (txtPunto2.Text.Substring(i, 1) != "(")
                            {
                                aux += txtPunto2.Text.Substring(i, 1);
                            }
                        }
                    }
                    else
                    {
                        if (txtPunto2.Text.Substring(i, 1) == ")")
                        {
                            part = 0;
                            y2 = Convert.ToInt32(aux);
                            aux = "";
                        }
                        else
                        {
                            aux += txtPunto2.Text.Substring(i, 1);
                        }
                    }
                }

                Punto Punto1 = new Punto(x1, y1);
                Punto Punto2 = new Punto(x2, y2);
                txtResultado.Text = Math.Round(Punto2.Distancia(Punto1), 4).ToString();
            }
        }

        private void txtPunto1_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtPunto1.Text) | String.IsNullOrEmpty(txtPunto1.Text)){
                p1.Visible = true;
            }
           else{
                p1.Visible = false;
        }
        }

        private void txtPunto2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPunto2.Text) | String.IsNullOrEmpty(txtPunto2.Text))
            {
                p2.Visible = true;
            }
            else
            {
                p2.Visible = false;
            }
        }
        private void TextChange(object sender, EventArgs e)
        {

            string punto1 = txtPunto1.Text.Replace(" ", "");
            string punto2 = txtPunto2.Text.Replace(" ", "");
            if (punto1.StartsWith("(") & punto2.StartsWith("(") & punto1.EndsWith(")") & punto2.EndsWith(")"))
            {
                for (int f = 1; f < punto1.Length - 2; ++f)
                {
                    string p = punto1.Substring(f, 1);
                    if (punto1.Substring(f, 1) != "," & punto1.Substring(f, 1) != "1" & punto1.Substring(f, 1) != "2" &
                        punto1.Substring(f, 1) != "3" & punto1.Substring(f, 1) != "4" & punto1.Substring(f, 1) != "5" &
                        punto1.Substring(f, 1) != "6" & punto1.Substring(f, 1) != "7" & punto1.Substring(f, 1) != "8" &
                        punto1.Substring(f, 1) != "9" & punto1.Substring(f, 1) != "0" & punto1.Substring(f, 1) != "-")
                    {
                        adver.Visible = true;
                        return;
                    }
                    else
                    {
                        adver.Visible = false;
                    }
                }

                for (int f = 1; f < punto2.Length - 2; ++f)
                {
                    string p = punto2.Substring(f, 1);
                    if (punto2.Substring(f, 1) != "," & punto2.Substring(f, 1) != "1" & punto2.Substring(f, 1) != "2" &
                        punto2.Substring(f, 1) != "3" & punto2.Substring(f, 1) != "4" & punto2.Substring(f, 1) != "5" &
                        punto2.Substring(f, 1) != "6" & punto2.Substring(f, 1) != "7" & punto2.Substring(f, 1) != "8" &
                        punto2.Substring(f, 1) != "9" & punto2.Substring(f, 1) != "0" & punto2.Substring(f, 1) != "-")
                    {
                        adver.Visible = true;
                        return;
                    }
                    else
                    {
                        adver.Visible = false;
                    }
                }
            }
            else
            {
                adver.Visible = true;
            }
        if (p1.Visible == true | p2.Visible == true){
                    adver.Visible = false;
       }

        }
    }
}
