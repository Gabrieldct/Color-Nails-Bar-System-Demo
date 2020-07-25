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

    public partial class Main : Form
    {
        public Main()
        {

            InitializeComponent();

        }
        public double Total;
        public int N;
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'colorNailbarDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter1.Fill(this.colorNailbarDataSet1.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'colorNailbarDataSet1.Productos_Y_Servicios' Puede moverla o quitarla según sea necesario.
            this.productos_Y_ServiciosTableAdapter1.Fill(this.colorNailbarDataSet1.Productos_Y_Servicios);
            // TODO: esta línea de código carga datos en la tabla 'colorNailbarDataSet1.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter1.Fill(this.colorNailbarDataSet1.Empleados);
            





            //BotonFacturar.Enabled = false;
            //BotonCuadre.Enabled = false;
            //BotonCierre.Enabled = false;
            //BotonImpFac.Enabled = false;

        }

        private void BotonFacturar_Click(object sender, EventArgs e) //Ventana Facturacion 
        {

            using (Facturacion VentanaFacturacion = new Facturacion(Total))
                VentanaFacturacion.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  // Agregar Linea Segun Campos
        {
            N = Display.Rows.Add();
            Display.Rows[N].Cells[0].Value = CBEmpleados.Text;            //Agregar Columna empleado
            Display.Rows[N].Cells[1].Value = CBServicios.Text;            //Agregar Servicio
            Display.Rows[N].Cells[2].Value = CBServicios.SelectedValue;   //Valor Del Servicio
        }

        private void button3_Click(object sender, EventArgs e) //Eliminar Linea Seleccionada Data Grid View
        {
            foreach (DataGridViewRow row in Display.SelectedRows) {
                Display.Rows.RemoveAt(row.Index);

                    }
            Total = 0;
            foreach (DataGridViewRow item in Display.Rows)
            {

                Total += Convert.ToDouble(item.Cells[2].Value);
            }
            Sub_total.Text = Total.ToString();
        }

        private void Display_CellValueChanged(object sender, DataGridViewCellEventArgs e)   //Sumatoria Montos
        {
         
            Total = 0;
            foreach (DataGridViewRow item in Display.Rows)
            {
                
                    Total += Convert.ToDouble(item.Cells[2].Value);
            }
            Sub_total.Text = Total.ToString();
        }

        private void GestionS_Click(object sender, EventArgs e) //Ventana Gestion de Servicios
        {
            using (GestionS VentanaGestion = new GestionS())
                VentanaGestion.ShowDialog();
        }

        private void GestionP_Click(object sender, EventArgs e) // Ventana Gestion Personal
        {
            using (GestionP VentanaGestion = new GestionP())
                VentanaGestion.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e) //Ventana Gestion De Clientes
        {
            using (GestionC VentanaGestion = new GestionC())
                VentanaGestion.ShowDialog();
        }

        private void BotonCuadre_Click(object sender, EventArgs e)   //Ventana Cuadre
        {
            using (Cuadre Ventana = new Cuadre())
                Ventana.ShowDialog();
        }

        private void BotonComisiones_Click(object sender, EventArgs e) // ventana Comision
        {
            using(Comision Ventana = new Comision())
                Ventana.ShowDialog();
        }
    }
}
