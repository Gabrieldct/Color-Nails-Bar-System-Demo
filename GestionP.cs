using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ColorNails
{
    
    public partial class GestionP : Form
    {
        public string Nombre="";
        public string Telefono = "";
        public string Direccion = "";
        public string Cedula = "";
        public int select;
        public GestionP()
        {
            InitializeComponent();
        }

        private void GestionP_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'colorNailbarDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.colorNailbarDataSet.Empleados);



        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(Txt_Nombre.Text != "")
            {
                Nombre = Txt_Nombre.Text;
            }
            if (Txt_Telefono.Text != "")
            {
                Telefono = Txt_Telefono.Text;
            }
            if (Txt_Dir.Text != "")
            {
                Direccion = Txt_Dir.Text;
            }
            if (Txt_Cedula.Text != "")
            {
                Cedula = Txt_Cedula.Text;
            }
            if (Nombre != "" && Telefono != "" && Direccion != "" && Cedula != "") //Verificacion Campos No Esten Vacios
            {
                this.empleadosTableAdapter.AgregarEmpleado(Nombre,Telefono,Direccion,Cedula);
                MessageBox.Show("Empleado Agregado Con Exito!");
                this.Close();
            }

            else
            {
                MessageBox.Show("Error al Agregar Empleado. Porfavor Complete los campos", "Error");
            }
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            select = dataGridView1.CurrentCell.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Quiere eliminar este registro?", "Confirmacion", MessageBoxButtons.YesNo);
               
                if (conf == DialogResult.Yes) {
                this.empleadosTableAdapter.EliminarEmpleado(Convert.ToInt32(dataGridView1.Rows[select].Cells[0].Value));

                MessageBox.Show("Registro Eliminado Correctamente");
                this.Close();
            }

        }

        private void Btn_act_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre.Text == "")
            {
                Nombre = dataGridView1.Rows[select].Cells[1].Value.ToString(); 
            }
            else { Nombre = Txt_Nombre.Text; }


            
                if (Txt_Telefono.Text == "")
            {
                Telefono = dataGridView1.Rows[select].Cells[2].Value.ToString(); 
            }
            else { Telefono = Txt_Telefono.Text; }



                if (Txt_Dir.Text == "")
            {
                Direccion = dataGridView1.Rows[select].Cells[3].Value.ToString(); 
            }
            else { Direccion = Txt_Dir.Text;}


            if (Txt_Cedula.Text == "")
            {
                        Cedula = dataGridView1.Rows[select].Cells[4].Value.ToString(); 
            }
            else{ Cedula = Txt_Cedula.Text;}

           

            if (Nombre !="" && Telefono !="" && Direccion !="" && Cedula !="") //Verificacion Campos No Esten Vacios
            {
                int elid = Convert.ToInt32(dataGridView1.Rows[select].Cells[0].Value);
                this.empleadosTableAdapter.ActualizarEmpleado(Nombre, Telefono, Direccion, Cedula,elid);
                MessageBox.Show("Empleado Actualizado Con Exito!");
                this.Close();
            }

            else{
                MessageBox.Show("Error al Actualizar Empleado. Porfavor Complete los campos", "Error");
            }
        }

        private void Txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
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
