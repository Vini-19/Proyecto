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

        private void frmAgregarCompra_Load_2(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cmbProveedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Text = "";
            Cargarcategoria();
        }

        private void txtCantidad_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCantidad, val.txt_vacio(txtCantidad.Text) + val.espacio_inicio_final(txtCantidad.Text) + val.espacio(txtCantidad.Text) + val.validarnumenteros(txtCantidad.Text) + val.validar_peso(txtCantidad.Text));
        }

        private void txtPrecio_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPrecio, val.txt_vacio(txtPrecio.Text) + val.espacio_inicio_final(txtPrecio.Text) + val.validar_precio(txtPrecio.Text) + val.espacio(txtPrecio.Text));
        }

        int o = -1;
        float totalCompra = 0;
        List<string> listCompras = new List<string>();
        List<int> listPersonasId = new List<int>();

        private void btnAgregarC_Click_1(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "" || txtPrecio.Text == "" || cmbProveedor.SelectedIndex == -1 || cmbCategoria.SelectedIndex == -1 || cmbProveedor.Text == "" || cmbCategoria.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;

            }
            else
            {
                if (errorProvider1.GetError(txtCantidad) == "" && errorProvider1.GetError(txtPrecio) == "")
                {
                    ListaCompras.Items.Add("Proveedor:  " + cmbProveedor.Text);
                    ListaCompras.Items.Add("Categoria:  " + cmbCategoria.Text);
                    ListaCompras.Items.Add("Peso:       " + txtCantidad.Text);
                    ListaCompras.Items.Add("Precio:     " + txtPrecio.Text);
                    ListaCompras.Items.Add("--------------------------");
                    totalCompra = totalCompra + float.Parse(txtPrecio.Text) * float.Parse(txtCantidad.Text);
                    listCompras.Add(cmbProveedor.Text);
                    listCompras.Add(cmbCategoria.Text);
                    listCompras.Add(txtCantidad.Text);
                    listCompras.Add(txtPrecio.Text);
                    listCompras.Add(cmbProveedor.SelectedIndex.ToString());
                    lbltotal2.Text = totalCompra.ToString();


                    txtCantidad.Clear();
                    txtPrecio.Clear();
                    errorProvider1.SetError(txtCantidad, "");
                    errorProvider1.SetError(txtPrecio, "");
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }
            }
        }

        private void btnQuitarC_Click_1(object sender, EventArgs e)
        {
            if (o != -1)
            {


                float pre = 0, cant = 0;
                float x = ListaCompras.Items.Count;
                x = x / 5;
                int y = -1;
                int t = 5;
                List<int> ListPosicion = new List<int>()
                {


                };
                for (int i = 0; i < x; i++)
                {

                    if (t != 2)
                    {
                        t = 5;
                        for (int j = 0; j < 5; j++)
                        {
                            y++;
                            ListPosicion.Add(y);

                            if (o == y)
                            {
                                t++;
                            }
                            else
                            {
                                t--;
                            }
                        }

                    }
                    if (t != 2)
                    {
                        ListPosicion.Clear();
                    }

                }
                for (int i = ListPosicion.Count - 1; i >= 0; i--)
                {
                    int indice = ListPosicion[i];

                    if (i == 3)
                    {
                        int pre2 = ListPosicion[3];
                        pre = float.Parse(listCompras[pre2]);
                    }
                    else if (i == 2)
                    {
                        int cont2 = ListPosicion[2];
                        cant = float.Parse(listCompras[cont2]);
                    }



                    if (indice >= 0 && indice < ListaCompras.Items.Count)
                    {
                        ListaCompras.Items.RemoveAt(indice);
                        listCompras.RemoveAt(indice);
                    }
                }

                totalCompra = totalCompra - (cant * pre);
                lbltotal2.Text = totalCompra.ToString();
            }
            o = -1;
        }

        private void btnFinalizarC_Click_1(object sender, EventArgs e)
        {
            Cconexion conexion = new Cconexion();
            try
            {
                SqlConnection cn = conexion.leer();
                if (cn.State == ConnectionState.Open)
                {

                    int i = 0;
                    float po = listCompras.Count / 5;

                    for (int x = 0; x < po; x++)
                    {
                        if (i < listCompras.Count)
                        {
                            SqlCommand Comandocategoria = new SqlCommand("Select Categoria_ID from Categoria where NombreCategoria= '" + listCompras[i + 1] + "'", cn);
                            SqlDataAdapter sda = new SqlDataAdapter(Comandocategoria);
                            DataTable dataTable = new DataTable();
                            sda.Fill(dataTable);
                            int d = dataTable.Rows.Count;

                            string categoriaid = "";
                            for (int n = 0; n < d; n++)
                            {
                                categoriaid = dataTable.Rows[n][0].ToString();
                            }

                            int j = int.Parse(listCompras[i + 4]);

                            string descripcion = "Compra de " + listCompras[i + 1];

                            string query = "INSERT INTO Inventario (Persona_ID, Categoria_ID, Estado, Cantidad_Producto, Descripcion, Precio) " +
                                "VALUES ('" + listPersonasId[j] + "', '" + categoriaid + "', 'Activo', '" + listCompras[i + 2] + "','" + descripcion + "', '" + listCompras[i + 3] + "')";
                            SqlCommand comando = new SqlCommand(query, cn);
                            comando.ExecuteNonQuery();

                            // Actualizar el Stock en la tabla Categoria
                            string updateStockQuery = "UPDATE Categoria SET Stock = Stock + @cantidad WHERE Categoria_ID = @categoriaId";
                            SqlCommand updateStockCommand = new SqlCommand(updateStockQuery, cn);
                            updateStockCommand.Parameters.AddWithValue("@cantidad", listCompras[i + 2]);
                            updateStockCommand.Parameters.AddWithValue("@categoriaId", categoriaid);
                            updateStockCommand.ExecuteNonQuery();

                            MessageBox.Show("Materia Prima Ingresada Correctamente a Inventario");
                            i = i + 5;
                        }
                    }
                    listCompras.Clear();
                    ListaCompras.Items.Clear();
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

        private void txtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void txtPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }

}
