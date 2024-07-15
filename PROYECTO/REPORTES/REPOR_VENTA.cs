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
    public partial class REPOR_VENTA : Form
    {
        public REPOR_VENTA()
        {
            InitializeComponent();
        }

        private void REPOR_VENTA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTAS.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.vENTAS.Ventas);

            this.reportViewer1.RefreshReport();
        }
    }
}
