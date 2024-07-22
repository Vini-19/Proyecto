using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class REPOR_PRODUCT : Form
    {
        public REPOR_PRODUCT()
        {
            InitializeComponent();
        }

        private void reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productos.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.productos.Productos);
            // TODO: esta línea de código carga datos en la tabla 'productos.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.productos.Productos);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
