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
    public partial class Comision : Form
    {
        public Comision()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'colorNailbarDataSet.Comisiones' Puede moverla o quitarla según sea necesario.
            this.comisionesTableAdapter.Fill(this.colorNailbarDataSet.Comisiones);

        }
    }
}
