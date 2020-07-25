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

    public partial class GestionS : Form
    {
        public int select;
        public GestionS()
        {
            InitializeComponent();
        }

        private void GestionS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'colorNailbarDataSet.Productos_Y_Servicios' Puede moverla o quitarla según sea necesario.
            this.productos_Y_ServiciosTableAdapter.Fill(this.colorNailbarDataSet.Productos_Y_Servicios);
            


        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.productos_Y_ServiciosTableAdapter.EliminarServicio(Convert.ToInt32(dataGridView1.Rows[select].Cells[0].Value));
            MessageBox.Show("Servicio/Producto Eliminado Correctamente");
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (Txt_NombreS.Text != "" && Txt_CostoS.Text != "")
            {
                this.productos_Y_ServiciosTableAdapter.AgregarServicios(Txt_NombreS.Text, Convert.ToInt32(Txt_CostoS.Text));
                MessageBox.Show("Servicio/Producto Agregado Correctamente");
                this.Close();
            }

            else
                MessageBox.Show("Debe Introducir El Nombre y el Precio del Servicio/Producto", "ERROR");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Txt_NombreS.Text != "" && Txt_CostoS.Text != "")
            {
                this.productos_Y_ServiciosTableAdapter.ActualizarServicio(Txt_NombreS.Text,
                Convert.ToInt32(Txt_CostoS.Text),
                Convert.ToInt32(dataGridView1.Rows[select].Cells[0].Value),
                dataGridView1.Rows[select].Cells[1].Value.ToString(),
                Convert.ToInt32(dataGridView1.Rows[select].Cells[2].Value),
                Convert.ToInt32(dataGridView1.Rows[select].Cells[0].Value));

                MessageBox.Show("Servicio Actualizado Correctamente");
                this.Close();
            }
            else
                MessageBox.Show("Debe Introducir El Nombre y el Precio del Servicio/Producto", "ERROR");
        }
        


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            select = dataGridView1.CurrentCell.RowIndex;
            
        }

        private void Txt_CostoS_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' ))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }
    }  
}
