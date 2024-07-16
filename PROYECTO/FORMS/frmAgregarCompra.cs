using PROYECTO.CLASES;
using Proyecto_de_desarrolo.Clases;
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
    public partial class frmAgregarCompra : Form
    {

        public frmAgregarCompra()
        {
            InitializeComponent();
            CargarDatosProveedores();
            Cargarcategoria();


        }

        clsValidaciones val = new clsValidaciones();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatosProveedores()
        {
            Cconexion conexion = new Cconexion();

            try
            {
                SqlConnection cn = conexion.leer();
                if (cn.State == ConnectionState.Open)
                {
                    string queryExisteProducto = "SELECT R.[Roles_ID], R.Rol, P.[Primer_Nombre] FROM [dbo].[Personas] P INNER JOIN [dbo].[Roles] R ON R.Roles_ID = P.Roles_ID WHERE R.Rol LIKE 'Proveedor'";
                    SqlCommand comandoExisteProducto = new SqlCommand(queryExisteProducto, cn);

                    SqlDataReader reader = comandoExisteProducto.ExecuteReader();

                    cmbProveedor.Items.Clear();

                    while (reader.Read())
                    {
                        int rolesID = Convert.ToInt32(reader["Roles_ID"]);
                        string proveedorNombre = reader["Primer_Nombre"].ToString();

                        clsProveedorProducto proveedor = new clsProveedorProducto(rolesID, proveedorNombre);
                        cmbProveedor.Items.Add(proveedor);
                    }

                    reader.Close();
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
        }



        private void button1_Click(object sender, EventArgs e)
        {


        }
        float precio, total, subtotal;

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            int cant;
            int indiceprove = cmbProveedor.SelectedIndex;
            int indicecate = cmbCategoria.SelectedIndex;

            ListaCompras.Items.Add(cmbProveedor.Items[indiceprove].ToString());
            ListaCompras.Items.Add(cmbCategoria.Items[indicecate].ToString());


            ListaCompras.Items.Add(txtCantidad.Text);
            ListaCompras.Items.Add(txtPrecio.Text);

            

            cant = int.Parse(txtCantidad.Text);
            precio = float.Parse(txtPrecio.Text);

            subtotal = cant * precio;
            total = total + subtotal;



            lbltotal2.Text = total.ToString("Lps.");
            lblsubtotal2.Text = subtotal.ToString("Lps.");

        }

        private void ListaCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Text = "";
            Cargarcategoria();
        }

        public void Cargarcategoria()
        {
            Cconexion conexion = new Cconexion();
            string nombreProve = cmbProveedor.Text;

            try
            {
                SqlConnection cn = conexion.leer();
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        string queryExisteProducto = "Select P.Categoria from dbo.Personas P WHERE P.Primer_Nombre = @nombre";
                        SqlCommand comando = new SqlCommand(queryExisteProducto, cn);
                        {
                            comando.Parameters.AddWithValue("@nombre", nombreProve);

                            SqlDataReader reader = comando.ExecuteReader();
                            {
                                cmbCategoria.Items.Clear();

                                while (reader.Read())
                                {
                                    string nombreCategoria = reader["Categoria"].ToString();
                                    cmbCategoria.Items.Add(nombreCategoria);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error de conexión.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);
            }
        }


        private void btnQuitarC_Click(object sender, EventArgs e)
        {
            if (ListaCompras.SelectedIndex > -1)
            {
                ListaCompras.Items.RemoveAt(ListaCompras.SelectedIndex);
            }





        }

        private void frmAgregarCompra_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmProveedores prove = new frmProveedores();
            prove.Show();
        }

        private void btnFinalizarC_Click(object sender, EventArgs e)
        {
            Cconexion conexion = new Cconexion();
            try
            {
                SqlConnection cn = conexion.leer();
                if (cn.State == ConnectionState.Open)
                {
                    int personaId = ((clsProveedorProducto)cmbProveedor.SelectedItem).Roles_ID;
                    int categoriaId = cmbCategoria.SelectedIndex + 1;
                    int cantidadProducto = int.Parse(txtCantidad.Text);
                    DateTime fechaIngreso = DateTime.Now;
                    string descripcion = "Compra de " + cmbCategoria.SelectedItem.ToString();
                    float precio = float.Parse(txtPrecio.Text);

                    // Insertar datos en la tabla Inventario
                    string query = "INSERT INTO Inventario (Persona_ID, Categoria_ID, Estado, Cantidad_Producto, fecha_ingreso, Descripcion, Precio) " +
                                   "VALUES (@personaId, @categoriaId, @estado, @cantidadProducto, @fechaIngreso, @descripcion, @precio)";

                    SqlCommand comando = new SqlCommand(query, cn);
                    comando.Parameters.AddWithValue("@personaId", personaId);
                    comando.Parameters.AddWithValue("@categoriaId", categoriaId);
                    comando.Parameters.AddWithValue("@estado", "Activo");
                    comando.Parameters.AddWithValue("@cantidadProducto", cantidadProducto);
                    comando.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@precio", precio);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Compra finalizada y registrada con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar la compra.");
                    }
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

        }

        private void frmAgregarCompra_Load_1(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }

}
