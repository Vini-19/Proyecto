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
using System.IO;
using System.Drawing.Imaging;
using Proyecto_de_desarrolo.Clases;

namespace Proyecto_de_desarrolo
{
    public partial class frmPedido : Form
    {


        public frmPedido()
        {
            InitializeComponent();
            CargarDatosCategoria();
            DataGridView();


        }

        clsValidaciones val = new clsValidaciones();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Insertar(byte[] image)
        {
            clsProductoNuevo producto = new clsProductoNuevo();
            try
            {
                clsProveedorProducto categoriaSeleccionada = (clsProveedorProducto)cmbCategoria.SelectedItem;

                producto.setcodBarra(txtCodigo.Text);
                producto.setnomProducto(txtNombre.Text);
                producto.setprecio(Convert.ToInt32(txtPrecio.Text));
                producto.setNombre_Imagen(txtNombre_Imagen.Text);

                producto.setcategoriaId(categoriaSeleccionada.Roles_ID);

                if (cmbCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione una categoria.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cmbCategoria.Text) || (this.txtPrecio.Text == "0" || string.IsNullOrWhiteSpace(this.txtPrecio.Text)) || string.IsNullOrWhiteSpace(txtNombre_Imagen.Text))
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
                        // Consulta para insertar el producto y obtener el ID del producto insertado
                        string insertar_producto = "INSERT INTO Productos (Codigo_barra, Nombre_Producto, Categoria_ID, Precio, Nombre_Imagen, imagen) " +
                                                   "VALUES (@codBarra, @nomProducto,@categoriaId, @precio, @Nombre_Imagen,@image); " +
                                                   "SELECT SCOPE_IDENTITY();";

                        SqlCommand comando = new SqlCommand(insertar_producto, cn);
                        comando.Parameters.AddWithValue("@codBarra", producto.getcodBarra());
                        comando.Parameters.AddWithValue("@nomProducto", producto.getnomProducto());
                        comando.Parameters.AddWithValue("@categoriaId", producto.getcategoriaId());
                        comando.Parameters.AddWithValue("@precio", producto.getprecio());
                        comando.Parameters.AddWithValue("@Nombre_Imagen", producto.getNombre_Imagen());
                        comando.Parameters.AddWithValue("@image", image);


                        // Ejecutar la inserción y obtener el ID del producto insertado
                        int nuevoProductoId = Convert.ToInt32(comando.ExecuteScalar());

                        limpiar();
                        errorProvider1.SetError(txtCodigo, "");
                        errorProvider1.SetError(txtNombre, "");
                        errorProvider1.SetError(txtPrecio, "");
                        errorProvider1.SetError(txtNombre_Imagen, "");
                        MessageBox.Show("Producto registrado correctamente");
                        DataGridView();
                        txtCodigo.Focus();

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


        byte[] convertimage(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void CargarDatosCategoria()
        {
            Cconexion conexion = new Cconexion();

            try
            {
                SqlConnection cn = conexion.leer();
                if (cn.State == ConnectionState.Open)
                {
                    string queryExisteProducto = "SELECT Categoria_ID, NombreCategoria FROM [dbo].[Categoria]";
                    SqlCommand comandoExisteProducto = new SqlCommand(queryExisteProducto, cn);

                    SqlDataReader reader = comandoExisteProducto.ExecuteReader();

                    cmbCategoria.Items.Clear();

                    while (reader.Read())
                    {
                        int categoriaId = Convert.ToInt32(reader["Categoria_ID"]);
                        string nombreCategoria = reader["NombreCategoria"].ToString();

                        clsProveedorProducto categoria = new clsProveedorProducto(categoriaId, nombreCategoria);
                        cmbCategoria.Items.Add(categoria);

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

        public void Modificar()
        {
            clsProductoNuevo producto = new clsProductoNuevo();
            try
            {

                producto.setprecio(Convert.ToInt32(txtPrecio.Text));
                producto.setNombre_Imagen(txtNombre_Imagen.Text);


                /* if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cmbCategoria.Text) || (this.txtPrecio.Text == "0" || string.IsNullOrWhiteSpace(this.txtPrecio.Text)) || string.IsNullOrWhiteSpace(txtNombre_Imagen.Text))
                 {
                     MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                     return;
                 }*/

                Cconexion conexion = new Cconexion();
                SqlConnection cn = conexion.leer();

                if (cn.State == ConnectionState.Open)
                {
                    if (dgvProducto.SelectedRows.Count > 0)
                    {
                        string Cod_Barra = dgvProducto.SelectedRows[0].Cells["Codigo_barra"].Value.ToString();

                        string modificar_prod = "UPDATE Productos set Precio=@precio,Nombre_Imagen=@Nombre_Imagen" +
                                              " WHERE Codigo_barra= @Cod_Barra";

                        SqlCommand comando = new SqlCommand(modificar_prod, cn);
                        comando.Parameters.AddWithValue("@precio", producto.getprecio());
                        comando.Parameters.AddWithValue("@Nombre_Imagen", producto.getNombre_Imagen());
                        comando.Parameters.AddWithValue("@Cod_Barra", Cod_Barra);

                        int Actualizacion = comando.ExecuteNonQuery();
                        DataGridView();

                        if (Actualizacion > 0)
                        {
                            limpiar();
                            errorProvider1.SetError(txtCodigo, "");
                            errorProvider1.SetError(txtNombre, "");
                            errorProvider1.SetError(txtPrecio, "");
                            errorProvider1.SetError(txtNombre_Imagen, "");
                          
                            MessageBox.Show("Producto modificado correctamente");
                            btnAgregar.Enabled = true;
                           
                            
                            txtCodigo.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el producto");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error");
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
            

            if (errorProvider1.GetError(txtCodigo) == "" && errorProvider1.GetError(txtNombre) == "" && errorProvider1.GetError(txtNombre_Imagen) == "")
            {
                using (OpenFileDialog dialog = new OpenFileDialog()
                {
                    Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*jpeg",
                    Multiselect = false
                })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        picProducto.Image = Image.FromFile(dialog.FileName);
                        Insertar(convertimage(picProducto.Image));
                    }
                }
            }
            else
            {
                MessageBox.Show("Verifique los campos");
            }

        }
        public void DataGridView()
        {
            string consultaSql = "SELECT* FROM Productos";

            try
            {
                Cconexion conexion = new Cconexion();
                SqlConnection cn = conexion.leer();

                SqlDataAdapter adaptador = new SqlDataAdapter(consultaSql, conexion.leer());
                DataSet dataSet = new DataSet();
                adaptador.Fill(dataSet, "Productos");


                dgvProducto.DataSource = dataSet.Tables["Productos"];


                dgvProducto.Columns["Codigo_barra"].HeaderText = "Codigo_barra";
                dgvProducto.Columns["Nombre_Producto"].HeaderText = "Nombre";
                dgvProducto.Columns["Categoria_ID"].HeaderText = "Categoria";
                dgvProducto.Columns["Precio"].HeaderText = "Precio";
                dgvProducto.Columns["Nombre_Imagen"].HeaderText = "Nombre Imagen";
                dgvProducto.Columns["Imagen"].HeaderText = "Imagen";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

        }
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProducto.Rows[e.RowIndex];


                txtCodigo.Text = fila.Cells["Codigo_barra"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre_Producto"].Value.ToString();
                cmbCategoria.Text = fila.Cells["Categoria_ID"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtNombre_Imagen.Text = fila.Cells["Nombre_Imagen"].Value.ToString();
                cmbCategoria.SelectedItem=Convert.ToInt32(fila.Cells["Categoria_ID"].Value.ToString())-1;

                btnAgregar.Enabled = false;

                if (fila.Cells["imagen"].Value is byte[])
                {
                    byte[] imageBytes = (byte[])fila.Cells["imagen"].Value;

                    // Convertir los bytes a Imagen
                    Image imagen;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        imagen = Image.FromStream(ms);
                    }

                    picProducto.Image = imagen;
                }
                else
                {
                    MessageBox.Show("Error...No se encontro imagen");
                    picProducto.Image = null;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            errorProvider1.SetError(txtCodigo, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtPrecio, "");
            errorProvider1.SetError(txtNombre_Imagen, "");

            txtCodigo.Focus();
        }

        public void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            cmbCategoria.SelectedIndex = -1;
            txtPrecio.Text = "";
            txtNombre_Imagen.Text = "";
            picProducto.Image = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cmbCategoria.Text) || (this.txtPrecio.Text == "0" || string.IsNullOrWhiteSpace(this.txtPrecio.Text)) || string.IsNullOrWhiteSpace(txtNombre_Imagen.Text))
            {
                MessageBox.Show("Por favor, selecione un producto antes de poder ejecutar la acción.");

                return;
            }
            else
            {
                if (errorProvider1.GetError(txtCodigo) == "" && errorProvider1.GetError(txtNombre) == "" && errorProvider1.GetError(txtPrecio) == "" && errorProvider1.GetError(txtNombre_Imagen) == "")
                {
                    Modificar();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }
            }

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtNombre_Imagen_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtNombre_Imagen.Text == "" || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            else
            {
                if (errorProvider1.GetError(txtCodigo) == "" && errorProvider1.GetError(txtNombre) == "" && errorProvider1.GetError(txtNombre_Imagen) == "")
                {
                    using (OpenFileDialog dialog = new OpenFileDialog()
                    {
                        Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*jpeg",
                        Multiselect = false
                    })
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            picProducto.Image = Image.FromFile(dialog.FileName);
                            Insertar(convertimage(picProducto.Image));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Verifique los campos");
                }
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {

            limpiar();
            errorProvider1.SetError(txtCodigo, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtPrecio, "");
            errorProvider1.SetError(txtNombre_Imagen, "");
            btnAgregar.Enabled = true;

            txtCodigo.Focus();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cmbCategoria.Text) || (this.txtPrecio.Text == "0" || string.IsNullOrWhiteSpace(this.txtPrecio.Text)) || string.IsNullOrWhiteSpace(txtNombre_Imagen.Text))
            {
                MessageBox.Show("Por favor, selecione un producto antes de poder ejecutar la acción.");

                return;
            }
            else
            {
                if (errorProvider1.GetError(txtCodigo) == "" && errorProvider1.GetError(txtNombre) == "" && errorProvider1.GetError(txtPrecio) == "" && errorProvider1.GetError(txtNombre_Imagen) == "")
                {
                    Modificar();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }
            }
        }

        private void txtNombre_Imagen_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNombre_Imagen, val.txt_vacio(txtNombre_Imagen.Text) + val.espacio_inicio_final(txtNombre_Imagen.Text) + val.rango_nombre(txtNombre_Imagen.Text));
        }

        private void txtPrecio_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPrecio, val.txt_vacio(txtPrecio.Text) + val.espacio_inicio_final(txtPrecio.Text) + val.validar_precio(txtPrecio.Text));
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNombre, val.txt_vacio(txtNombre.Text) + val.espacio_inicio_final(txtNombre.Text) + val.rango_nombre(txtNombre.Text) + val.validarletra_espacio(txtNombre.Text));
        }

        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCodigo, val.txt_vacio(txtCodigo.Text) + val.espacio_inicio_final(txtCodigo.Text) + val.rango_12(txtCodigo.Text) + val.espacio(txtCodigo.Text));
        }

        private void dgvProducto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProducto.Rows[e.RowIndex];


                txtCodigo.Text = fila.Cells["Codigo_barra"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre_Producto"].Value.ToString();
                cmbCategoria.Text = fila.Cells["Categoria_ID"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtNombre_Imagen.Text = fila.Cells["Nombre_Imagen"].Value.ToString();
                cmbCategoria.SelectedItem = 1;

                btnAgregar.Enabled = false;

                if (fila.Cells["imagen"].Value is byte[])
                {
                    byte[] imageBytes = (byte[])fila.Cells["imagen"].Value;

                    // Convertir los bytes a Imagen
                    Image imagen;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        imagen = Image.FromStream(ms);
                    }

                    picProducto.Image = imagen;
                }
                else
                {
                    MessageBox.Show("Error...No se encontro imagen");
                    picProducto.Image = null;
                }
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dgvProducto_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProducto.Rows[e.RowIndex];


                txtCodigo.Text = fila.Cells["Codigo_barra"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre_Producto"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtNombre_Imagen.Text = fila.Cells["Nombre_Imagen"].Value.ToString();
                cmbCategoria.Text = fila.Cells["Categoria"].Value.ToString();
                MessageBox.Show(fila.Cells["Categoria_ID"].Value.ToString());

                btnAgregar.Enabled = false;

                if (fila.Cells["imagen"].Value is byte[])
                {
                    byte[] imageBytes = (byte[])fila.Cells["imagen"].Value;

                    // Convertir los bytes a Imagen
                    Image imagen;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        imagen = Image.FromStream(ms);
                    }

                    picProducto.Image = imagen;
                }
                else
                {
                    MessageBox.Show("Error...No se encontro imagen");
                    picProducto.Image = null;
                }
            }
            
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void cmbCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void frmPedido_Load_1(object sender, EventArgs e)
        {
            
        }

        private void txtCodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }
    }


}
