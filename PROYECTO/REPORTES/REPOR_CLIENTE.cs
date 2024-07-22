using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO.REPORTES
{
    public partial class REPOR_CLIENTE : Form
    {
        public REPOR_CLIENTE()
        {
            InitializeComponent();
        }

        private void REPOR_CLIENTE_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productos.Compra_cliente' Puede moverla o quitarla según sea necesario.
            this.compra_clienteTableAdapter.Fill(this.productos.Compra_cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
