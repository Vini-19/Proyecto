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

namespace Proyecto_de_desarrolo
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
            CargarComboCliente();
            txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

       

        clsValidaciones val = new clsValidaciones();

        

        private Dictionary<string, string> clientesRTN = new Dictionary<string, string>();
        public void CargarComboCliente()
        {
            Cconexion conexion = new Cconexion();

            try
            {
                using (SqlConnection cn = conexion.leer())
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        string queryCliente = "SELECT [Primer_Nombre], [RTN_Persona] FROM [dbo].[Personas] WHERE Roles_ID = 3";
                        using (SqlCommand comando = new SqlCommand(queryCliente, cn))
                        {
                            using (SqlDataReader reader = comando.ExecuteReader())
                            {
                                cmbCliente.Items.Clear();
                                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

                                while (reader.Read())
                                {
                                    string nombreCliente = reader["Primer_Nombre"].ToString();
                                    string rtnCliente = reader["RTN_Persona"].ToString();

                                    cmbCliente.Items.Add(nombreCliente);
                                    autoComplete.Add(nombreCliente);
                                    clientesRTN[nombreCliente] = rtnCliente;
                                }

                                cmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                                cmbCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
                                cmbCliente.AutoCompleteCustomSource = autoComplete;
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

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientesRTN.TryGetValue(cmbCliente.Text, out string rtn))
            {
                txtRTN.Text = rtn;
            }
            else
            {
                txtRTN.Clear();
            }
        }

        public DataTable ObtenerProductoPorCodigoDeBarra(string codigoBarra)
        {
            DataTable dt = new DataTable();
            Cconexion conexion = new Cconexion();

            try
            {
                using (SqlConnection cn = conexion.leer())
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Codigo_barra, Nombre_Producto, Precio FROM Productos WHERE Codigo_barra = @Codigo_barra";
                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            cmd.Parameters.AddWithValue("@Codigo_barra", codigoBarra);
                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                da.Fill(dt);
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

            return dt;
        }

        private void AgregarProductoAlDataGridView(string codigoBarra)
        {
            Cconexion conexion = new Cconexion();
            DataTable producto = ObtenerProductoPorCodigoDeBarra(codigoBarra);

            if (producto.Rows.Count > 0)
            {
                DataRow row = producto.Rows[0];
                dgvProductos.Rows.Add(row["Codigo_barra"], row["Nombre_Producto"], 1, row["Precio"], row["Precio"]);
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private decimal CalcularTotalVenta()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells["Precio"].Value != null && row.Cells["Cantidad"].Value != null)
                    {
                        try
                        {
                            decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                            int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                            total += precio * cantidad;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al calcular el total: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fila con datos nulos o inválidos encontrada.");
                    }
                }
            }

            return total;
        }

        private void btnGenerar_Factura_Click(object sender, EventArgs e)
        {
            /*string fechaVenta = DateTime.Now.ToString("yyyy-MM-dd");
            string cliente = cmbCliente.Text;
            string rtnCliente = txtRTN.Text;
            decimal totalVenta = CalcularTotalVenta();

            Cconexion conexion = new Cconexion();
            try
            {
                using (SqlConnection cn = conexion.leer())
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        string queryInsertVenta = @"INSERT INTO Ventas (FechaVenta, Cliente, RTN_Cliente, Total) 
                                            VALUES (@FechaVenta, @Cliente, @RTN_Cliente, @Total)";
                        using (SqlCommand cmd = new SqlCommand(queryInsertVenta, cn))
                        {
                            cmd.Parameters.AddWithValue("@FechaVenta", fechaVenta);
                            cmd.Parameters.AddWithValue("@Cliente", cliente);
                            cmd.Parameters.AddWithValue("@RTN_Cliente", rtnCliente);
                            cmd.Parameters.AddWithValue("@Total", totalVenta);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Venta registrada correctamente.");
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
                MessageBox.Show("Error al intentar registrar la venta: " + ex.Message);
            }*/
            string fechaVenta = DateTime.Now.ToString("yyyy-MM-dd");
            string cliente = cmbCliente.Text;
            string rtnCliente = txtRTN.Text;
            decimal totalVenta = CalcularTotalVenta();

            Cconexion conexion = new Cconexion();
            try
            {
                using (SqlConnection cn = conexion.leer())
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        string queryInsertVenta = @"INSERT INTO Ventas (FechaVenta, Cliente, RTN_Cliente, Total) 
                                            VALUES (@FechaVenta, @Cliente, @RTN_Cliente, @Total);
                                            SELECT SCOPE_IDENTITY();";
                        using (SqlCommand cmd = new SqlCommand(queryInsertVenta, cn))
                        {
                            cmd.Parameters.AddWithValue("@FechaVenta", fechaVenta);
                            cmd.Parameters.AddWithValue("@Cliente", cliente);
                            cmd.Parameters.AddWithValue("@RTN_Cliente", rtnCliente);
                            cmd.Parameters.AddWithValue("@Total", totalVenta);

                            int ventaId = Convert.ToInt32(cmd.ExecuteScalar());

                            //detalles de la venta
                            foreach (DataGridViewRow row in dgvProductos.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    string codigoBarra = row.Cells["Codigo"].Value.ToString();
                                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                                    string queryInsertDetalle = @"INSERT INTO DetallesVenta (VentaID, ProductoID, Cantidad) 
                                                          VALUES (@VentaID, 
                                                          (SELECT Productos_ID FROM Productos WHERE Codigo_barra = @Codigo_barra), 
                                                          @Cantidad)";
                                    using (SqlCommand cmdDetalle = new SqlCommand(queryInsertDetalle, cn))
                                    {
                                        cmdDetalle.Parameters.AddWithValue("@VentaID", ventaId);
                                        cmdDetalle.Parameters.AddWithValue("@Codigo_barra", codigoBarra);
                                        cmdDetalle.Parameters.AddWithValue("@Cantidad", cantidad);

                                        cmdDetalle.ExecuteNonQuery();
                                    }
                                }
                            }

                            MessageBox.Show("Venta registrada correctamente.");
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
                MessageBox.Show("Error al intentar registrar la venta: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && !dgvProductos.CurrentRow.IsNewRow)
            {
                DataGridViewRow currentRow = dgvProductos.CurrentRow;
                int cantidadActual = Convert.ToInt32(currentRow.Cells["Cantidad"].Value);
                currentRow.Cells["Cantidad"].Value = cantidadActual + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && !dgvProductos.CurrentRow.IsNewRow)
            {
                DataGridViewRow currentRow = dgvProductos.CurrentRow;
                int cantidadActual = Convert.ToInt32(currentRow.Cells["Cantidad"].Value);
                if (cantidadActual > 0)
                {
                    currentRow.Cells["Cantidad"].Value = cantidadActual - 1;
                }
            }
        }

        private void dgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                if (row.Cells["Cantidad"].Value != null && row.Cells["Precio"].Value != null)
                {
                    int cantidad;
                    decimal precio;

                    if (int.TryParse(row.Cells["Cantidad"].Value.ToString(), out cantidad) &&
                        decimal.TryParse(row.Cells["Precio"].Value.ToString(), out precio))
                    {
                        row.Cells["Total"].Value = cantidad * precio;
                    }
                    else
                    {
                        MessageBox.Show("Valores no válidos en las celdas.");
                    }
                }
            }
        }

        

        

        private void frmVentas_Load_1(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            string codigoBarra = txtCodigo_Barra.Text;
            if (!string.IsNullOrEmpty(codigoBarra))
            {
                AgregarProductoAlDataGridView(codigoBarra);
            }
            txtCodigo_Barra.Clear();
        }

        private void btnEnter_Click_2(object sender, EventArgs e)
        {
            string codigoBarra = txtCodigo_Barra.Text;
            if (!string.IsNullOrEmpty(codigoBarra))
            {
                AgregarProductoAlDataGridView(codigoBarra);
            }
            txtCodigo_Barra.Clear();
        }

        private void cmbCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (clientesRTN.TryGetValue(cmbCliente.Text, out string rtn))
            {
                txtRTN.Text = rtn;
            }
            else
            {
                txtRTN.Clear();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && !dgvProductos.CurrentRow.IsNewRow)
            {
                DataGridViewRow currentRow = dgvProductos.CurrentRow;
                int cantidadActual = Convert.ToInt32(currentRow.Cells["Cantidad"].Value);
                if (cantidadActual < 101)
                {
                    currentRow.Cells["Cantidad"].Value = cantidadActual + 1;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && !dgvProductos.CurrentRow.IsNewRow)
            {
                DataGridViewRow currentRow = dgvProductos.CurrentRow;
                int cantidadActual = Convert.ToInt32(currentRow.Cells["Cantidad"].Value);
                if (cantidadActual > 1)
                {
                    currentRow.Cells["Cantidad"].Value = cantidadActual - 1;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && !dgvProductos.CurrentRow.IsNewRow)
            {
                dgvProductos.Rows.Remove(dgvProductos.CurrentRow);

            }
        }

        private void btnGenerar_Factura_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToString(dgvProductos.Rows.Count) == "1")
            {
                MessageBox.Show("Ingrese productos antes de generar la venta");
            }
            else
            {

                string fechaVenta = DateTime.Now.ToString("yyyy-MM-dd");
                string cliente = cmbCliente.Text;
                string rtnCliente = txtRTN.Text;
                decimal totalVenta = CalcularTotalVenta();

                Cconexion conexion = new Cconexion();
                try
                {
                    using (SqlConnection cn = conexion.leer())
                    {
                        if (cn.State == ConnectionState.Open)
                        {
                            string queryInsertVenta = @"INSERT INTO Ventas (FechaVenta, Cliente, RTN_Cliente, Total) 
                                            VALUES (@FechaVenta, @Cliente, @RTN_Cliente, @Total);
                                            SELECT SCOPE_IDENTITY();";
                            using (SqlCommand cmd = new SqlCommand(queryInsertVenta, cn))
                            {
                                cmd.Parameters.AddWithValue("@FechaVenta", fechaVenta);
                                cmd.Parameters.AddWithValue("@Cliente", cliente);
                                cmd.Parameters.AddWithValue("@RTN_Cliente", rtnCliente);
                                cmd.Parameters.AddWithValue("@Total", totalVenta);

                                int ventaId = Convert.ToInt32(cmd.ExecuteScalar());

                                //detalles de la venta
                                foreach (DataGridViewRow row in dgvProductos.Rows)
                                {
                                    if (!row.IsNewRow)
                                    {
                                        string codigoBarra = row.Cells["Codigo"].Value.ToString();
                                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                                        string queryInsertDetalle = @"INSERT INTO DetallesVenta (VentaID, ProductoID, Cantidad) 
                                                          VALUES (@VentaID, 
                                                          (SELECT Productos_ID FROM Productos WHERE Codigo_barra = @Codigo_barra), 
                                                          @Cantidad)";
                                        using (SqlCommand cmdDetalle = new SqlCommand(queryInsertDetalle, cn))
                                        {
                                            cmdDetalle.Parameters.AddWithValue("@VentaID", ventaId);
                                            cmdDetalle.Parameters.AddWithValue("@Codigo_barra", codigoBarra);
                                            cmdDetalle.Parameters.AddWithValue("@Cantidad", cantidad);

                                            cmdDetalle.ExecuteNonQuery();
                                        }
                                    }
                                }

                                MessageBox.Show("Venta registrada correctamente.");
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
                    MessageBox.Show("Error al intentar registrar la venta: " + ex.Message);
                }

            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
