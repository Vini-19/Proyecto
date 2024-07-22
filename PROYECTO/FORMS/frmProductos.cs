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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_de_desarrolo.Formularios
{
    public partial class frmProductos : Form
    {
        public int idProveedor = 4;

        public frmProductos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void RegistroProducto()
        {
            clsProductoNuevo producto = new clsProductoNuevo();

            try
            {
                producto.setcodBarra(txtCodbarra.Text);
                producto.setnomProducto(txtnomProducto.Text);
                producto.setproveedor(cmbProveedor.Text);
                producto.setprecio(Convert.ToInt32(txtPrecio.Text));
                producto.setcantidad(Convert.ToInt32(txtCantidadP.Text));

                if (cmbProveedor.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un proveedor.");
                    return;
                }



                if (string.IsNullOrWhiteSpace(txtCodbarra.Text) || string.IsNullOrWhiteSpace(txtnomProducto.Text) || string.IsNullOrWhiteSpace(cmbProveedor.Text) || (this.txtPrecio.Text == "0" || string.IsNullOrWhiteSpace(this.txtPrecio.Text)) || (this.txtCantidadP.Text == "0" || string.IsNullOrWhiteSpace(this.txtCantidadP.Text)))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                Cconexion conexion = new Cconexion();
                SqlConnection cn = conexion.leer();

                if (cn.State == ConnectionState.Open)
                {
                    string queryExisteProducto = "SELECT COUNT(*) FROM Productos WHERE Nombre_Producto = @nomProducto";
                    SqlCommand comandoExisteProducto = new SqlCommand(queryExisteProducto, cn);

                    MessageBox.Show(producto.getnomProducto());

                    comandoExisteProducto.Parameters.AddWithValue("@nomProducto", producto.getnomProducto());

                    int count = (int)comandoExisteProducto.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Ya existe ese producto en el inventario. Ingrese producto no existente.");
                    }
                    else
                    {
                       
                        string insertar_producto = "INSERT INTO Productos (Codigo_barra, PersonasID, Nombre_Producto, Precio, Cantidad_Producto) " +
                                                   "VALUES (@codBarra, @personasid, @nomProducto, @precio, @cantidad); " +
                                                   "SELECT SCOPE_IDENTITY();";

                        SqlCommand comando = new SqlCommand(insertar_producto, cn);
                        comando.Parameters.AddWithValue("@codBarra", producto.getcodBarra());
                        comando.Parameters.AddWithValue("@personasid", idProveedor);
                        comando.Parameters.AddWithValue("@nomProducto", producto.getnomProducto());
                        comando.Parameters.AddWithValue("@precio", producto.getprecio());
                        comando.Parameters.AddWithValue("@cantidad", producto.getcantidad());

                       
                        int nuevoProductoId = Convert.ToInt32(comando.ExecuteScalar());

                        MessageBox.Show("Producto registrado correctamente");

                        string queryPersonal = "SELECT PersonasID FROM [dbo].[Personas] WHERE Primer_Nombre = @nomPersona";
                        SqlCommand comandoPersona = new SqlCommand(queryPersonal, cn);


                        comandoPersona.Parameters.AddWithValue("@nomPersona", producto.getproveedor());

                        int nomPersonal = (int)comandoPersona.ExecuteScalar();



                        string insertar_inventario = "INSERT INTO Inventario (Persona_ID, Producto_ID, Estado, Cantidad_Producto, Descripcion) " +
                                                   "VALUES (@personasid, @productoID, @estado, @cantidad_p,@descripcion);";
                        SqlCommand comando2 = new SqlCommand(insertar_inventario, cn);
                        comando2.Parameters.AddWithValue("@personasid", nomPersonal);
                        comando2.Parameters.AddWithValue("@productoID", nuevoProductoId);
                        comando2.Parameters.AddWithValue("@estado", "Activo");
                        comando2.Parameters.AddWithValue("@cantidad_p", producto.getcantidad());
                        comando2.Parameters.AddWithValue("@descripcion", producto.getnomProducto());

                      
                        comando2.ExecuteNonQuery();

                        MessageBox.Show("Producto registrado en inventario correctamente");

                        cn.Close();
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



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistroProducto();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarDatosProveedores();

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



        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            clsProveedorProducto proveedorSeleccionado = (clsProveedorProducto)cmbProveedor.SelectedItem;
            idProveedor = proveedorSeleccionado.Roles_ID;



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            RegistroProducto();
        }

        private void cmbProveedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            clsProveedorProducto proveedorSeleccionado = (clsProveedorProducto)cmbProveedor.SelectedItem;
            idProveedor = proveedorSeleccionado.Roles_ID;
        }

        private void txtCantidadP_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
