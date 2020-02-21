using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDF
{
    public partial class frmNextDate : Form
    {
        float fDiaEntrada;
        float fMesEntrada;
        float fAñoEntrada;
        float fDiaSalida;
        float fMesSalida;
        float fAñoSalida;
        public frmNextDate()
        {
            InitializeComponent();
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar<=47) || (e.KeyChar >=58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            fDiaEntrada = float.Parse(txtDia1.Text);
            fMesEntrada = float.Parse(txtMes1.Text);
            fAñoEntrada = float.Parse(txtAño1.Text);
            if (fDiaEntrada <= 0 || fDiaEntrada>31) {
                MessageBox.Show("El Dia introducido no es valido","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDia1.Clear();
                return;
            }
            if (fMesEntrada <= 0 || fMesEntrada > 12) {
                MessageBox.Show("El Mes introducido no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMes1.Clear();
                return;
            }
            if (fAñoEntrada <= 0) {
                MessageBox.Show("El Año introducido no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAño1.Clear();
                return;
            }
            if (fAñoEntrada % 4 == 0 || fAñoEntrada % 100==0 || fAñoEntrada % 400 ==0)
            {
                txtBisiesto.Text = "Si";
            }else txtBisiesto.Text="No";
            fDiaSalida = fDiaEntrada + 1;
            fMesSalida = fMesEntrada;
            fAñoSalida = fAñoEntrada;
            if (fMesSalida==2)
            {
                if (txtBisiesto.Text == "Si")
                {
                    if (fDiaSalida > 29)
                    {
                        fDiaSalida = 01;
                        fMesSalida++;
                    }
                }
                if (txtBisiesto.Text == "No")
                {
                    if (fDiaSalida > 28)
                    {
                        fDiaSalida = 01;
                        fMesSalida++;
                    }
                }
            }
                if (fDiaSalida > 30)
                {
                    if(fMesSalida==4 || fMesSalida==6 || fMesSalida==9 || fMesSalida == 11)
                    {
                        fDiaSalida = 01;
                        fMesSalida++;
                    }
                }
                if (fDiaSalida > 31)
                {
                    if(fMesSalida==1 || fMesSalida ==3 || fMesSalida ==5 || fMesSalida ==7 || fMesSalida == 8 || fMesSalida == 10 || fMesSalida ==12)
                    {
                        fDiaSalida = 01;
                        fMesSalida++;
                    }
                }
                if (fMesSalida > 12)
                {
                    fMesSalida = 01;
                    fAñoSalida++;
                }
            txtDia2.Text = fDiaSalida.ToString();
            txtMes2.Text = fMesSalida.ToString();
            txtAño2.Text = fAñoSalida.ToString();

            }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtAño1.Clear();
            txtAño2.Clear(); ;
            txtBisiesto.Clear();
            txtDia1.Clear();
            txtDia2.Clear();
            txtMes1.Clear();
            txtMes2.Clear();
        }
    }
    }
