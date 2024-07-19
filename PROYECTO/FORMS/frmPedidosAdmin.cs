using PROYECTO.CLASES;
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

namespace Proyecto_de_desarrolo.Formularios
{
    public partial class frmPedidosAdmin : Form
    {
        public frmPedidosAdmin()
        {
            InitializeComponent();
        }

        private void frmPedidosAdmin_Load(object sender, EventArgs e)
        {
            MostrarDatosCarritos();
        }

        public DataTable ObtenerDatosCarritos()
        {
            DataTable dt = new DataTable();
            Cconexion conexion = new Cconexion();

            try
            {
                SqlConnection cn = conexion.leer();
                if (cn.State == ConnectionState.Open)
                {
                    /*
                    string query = @"
                    SELECT 
                    C.Carrito_ID,
                    C.Productos_ID,
                    P.Nombre_Producto,
                    C.Usuarios_ID,
                    U.Nombre_Usuario,
                    C.cantidad,
                    C.fecha,
                    C.estado
                    FROM dbo.Carritos C
                    INNER JOIN dbo.Productos P ON C.Productos_ID = P.Productos_ID
                    INNER JOIN dbo.Usuarios U ON C.Usuarios_ID = U.Usuarios_ID";
                    */
                    string query = @"
                    SELECT
                    Nombre_Cliente,
                    Numero_Identidad,
                    Direccion,
                    Telefono,
                    Carrito_ID,
                    Productos_ID,
                    Usuarios_ID,
                    Cantidad,
                    Fecha,
                    Estado
                    FROM [dbo].[Pedidos]";



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


        private void MostrarDatosCarritos()
        {
            DataTable dtCarritos = ObtenerDatosCarritos();
            dataGridView1.DataSource = dtCarritos;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int carritoId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Carrito_ID"].Value);
                int estadoActual = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["estado"].Value);

                int nuevoEstado = (estadoActual == 0) ? 1 : 0;

                Cconexion conexion = new Cconexion();
                try
                {
                    SqlConnection cn = conexion.leer();
                    if (cn.State == ConnectionState.Open)
                    {
                        string query = "UPDATE dbo.Pedidos SET estado = @nuevoEstado WHERE Carrito_ID = @carritoId";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
                        cmd.Parameters.AddWithValue("@carritoId", carritoId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Pedido Confirmado Correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error de conexión.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar actualizar el estado: " + ex.Message);
                }

                MostrarDatosCarritos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila de pedido.");
            }
        }

        private void frmPedidosAdmin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
