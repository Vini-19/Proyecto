using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO.CLASES;

namespace Proyecto_de_desarrolo.Formularios
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        public DataTable ObtenerDatosInventario()
        {
            DataTable dt = new DataTable();
            Cconexion conexion = new Cconexion();

            try
            {
                SqlConnection cn = conexion.leer();
                if (cn.State == ConnectionState.Open)
                {
                    string query = @"
                    SELECT 
   
                    I.Inventario_ID,
                    C.NombreCategoria,
                    U.Primer_Nombre,
                    I.Cantidad_Producto,
                    I.Precio,
                    I.fecha_ingreso,
                    I.Categoria_ID,
                    I.Persona_ID
                    FROM dbo.Inventario I
                    INNER JOIN dbo.Categoria C ON I.Categoria_ID = C.Categoria_ID
                    INNER JOIN dbo.Personas U ON I.Persona_ID = U.PersonasID";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                else
                {
                    MessageBox.Show("Error de conexión.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);
            }

            return dt;
        }

        private void CalcularYSumarCantidades()
        {
            DataTable dt = ObtenerDatosInventario();

            decimal sumaCategoria1 = 0;
            decimal sumaCategoria2 = 0;

            foreach (DataRow row in dt.Rows)
            {
                int categoriaID = Convert.ToInt32(row["Categoria_ID"]);
                decimal cantidadProducto = Convert.ToDecimal(row["Cantidad_Producto"]);

                if (categoriaID == 1)
                {
                    sumaCategoria1 += cantidadProducto;
                }
                else if (categoriaID == 2)
                {
                    sumaCategoria2 += cantidadProducto;
                }
            }

            lblRes.Text = sumaCategoria1.ToString();
            lblCerdo.Text = sumaCategoria2.ToString();
        }

        private void GuardarCambios()
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            Cconexion conexion = new Cconexion();

            try
            {
                SqlConnection cn = conexion.leer();
                if (cn.State == ConnectionState.Open)
                {
                    string selectQuery = @"
                    SELECT 
                    Inventario_ID,
                    Categoria_ID,
                    Cantidad_Producto,
                    Precio,
                    fecha_ingreso,
                    Persona_ID
                    FROM dbo.Inventario";

                    SqlDataAdapter da = new SqlDataAdapter(selectQuery, cn);
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);

                    da.Update(dt);

                    DataTable newDt = ObtenerDatosInventario();
                    dataGridView1.DataSource = newDt;

                    MessageBox.Show("Cambios guardados y datos actualizados correctamente.");
                }
                else
                {
                    MessageBox.Show("Error de conexión.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar guardar los cambios: " + ex.Message);
            }
        }

        private void FiltrarDatos(string texto)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            if (dt != null)
            {
                dataGridView1.ClearSelection();

                if (!string.IsNullOrEmpty(texto))
                {
                    bool encontrado = false;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["Primer_Nombre"].Value != null && row.Cells["Primer_Nombre"].Value.ToString().ToLower().Contains(texto.ToLower()))
                        {
                            row.Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                            encontrado = true;
                            break; // Selecciona la primera y termina
                        }
                    }
                    if (!encontrado)
                    {
                        dataGridView1.ClearSelection();
                    }
                }
            }
        }

        public void CargarDatosEnDataGridView()
        {
            DataTable dt = ObtenerDatosInventario();
            dataGridView1.DataSource = dt;
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
            CalcularYSumarCantidades();

            txtBuscar.Focus();
        }

        private bool modoEdicion = false;
        private void button1_Click(object sender, EventArgs e)
        {
            modoEdicion = !modoEdicion; // Cambiar el estado de edición
            dataGridView1.ReadOnly = !modoEdicion; // Habilitar/deshabilitar edición según el estado
            btnModificar.Text = modoEdicion ? "Desactivar Modificación" : "Activar Modificación";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
            CalcularYSumarCantidades();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos(txtBuscar.Text);
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            FiltrarDatos(txtBuscar.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modoEdicion = !modoEdicion;
            dataGridView1.ReadOnly = !modoEdicion;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name == "Cantidad_Producto" || column.Name == "Categoria_ID")
                {
                    column.ReadOnly = !modoEdicion;
                }
                else
                {
                    column.ReadOnly = true;
                }
            }

            btnModificar.Text = modoEdicion ? "Desactivar Modificación" : "Activar Modificación";
        }
    }
}
