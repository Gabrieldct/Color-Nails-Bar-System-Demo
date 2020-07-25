using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorNails
{
   
    public partial class Facturacion : Form
    {
        
        public Facturacion(Double Total)
        {
            
            InitializeComponent();
            Txt_Total.Text = Total.ToString();
            
        }


       

        private void Facturacion_Load(object sender, EventArgs e)       //Carga de la Forma
        {
            BotonFacturar.Enabled = false;
            Txt_Transferencia.Text = "0";
            Txt_Efectivo.Text = "0";
            Txt_Tarjeta.Text = "0";
            Txt_Comprobacion.Text = "0";


        }

        private void Letras(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void Cambio(object sender, EventArgs e)
        {

            double Tarjeta = 0;
            double Efectivo = 0;
            double Transferencia = 0;
            if (Txt_Efectivo.Text != "")                        //Si variable Diferente de Texto Vacion
            {
                Efectivo = Convert.ToDouble(Txt_Efectivo.Text);
            }
            if (Txt_Tarjeta.Text != "")                         //Si variable Diferente de Texto Vacion
            {
                Tarjeta = Convert.ToDouble(Txt_Tarjeta.Text);
            }
            if (Txt_Transferencia.Text != "")                   //Si variable Diferente de Texto Vacion
            {
                Transferencia = Convert.ToDouble(Txt_Transferencia.Text);
            } 
            double Comprobacion = Efectivo + Tarjeta + Transferencia;        //Sumatoria de Campos
            Txt_Comprobacion.Text = Comprobacion.ToString();                //Comprobacion total y sumatoria mismo Monto
            if(Comprobacion == Convert.ToDouble(Txt_Total.Text))
            {
                BotonFacturar.Enabled = true;                               //Activacion boton Facturar
            }
            else
            {
                BotonFacturar.Enabled = false;
            }
        }
    }
}
