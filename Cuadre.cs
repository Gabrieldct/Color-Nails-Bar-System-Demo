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
    public partial class Cuadre : Form
    {
        public Cuadre()
        {
            InitializeComponent();
        }

        private void Cuadre_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'colorNailbarDataSet.Cuadre' Puede moverla o quitarla según sea necesario.
            this.cuadreTableAdapter.Fill(this.colorNailbarDataSet.Cuadre);

        }

        private void Boton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
