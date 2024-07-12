using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROYECTO.CLASES
{
    public class Cconexion
    {
        private readonly string connectionString = "Data Source=croas.database.windows.net;Initial Catalog=Proyecto_Carniceria;Persist Security Info=True;User ID=Vini;Password=Cr0as_P4ss;TrustServerCertificate=True";

        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(connectionString);
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            return cn;
        }

        public void RegistroUsu(string contra, string pregunta, string respuesta, string nomUsuario)
        {
            try
            {
                using (SqlConnection cn = ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("PA_RegistroUsuario", cn))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Contraseña", contra);
                        comando.Parameters.AddWithValue("@Roles_ID", 3);
                        comando.Parameters.AddWithValue("@Pregunta_Recuperacion", pregunta);
                        comando.Parameters.AddWithValue("@Respuesta_Recuperacion", respuesta);
                        comando.Parameters.AddWithValue("@Nombre_Usuario", nomUsuario);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuario registrado correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);
            }
        }

        public bool VerificarClienteExistente(string nombre)
        {
            bool verificar = false;
            try
            {
                using (SqlConnection cn = ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("PA_VerificarClienteExistente", cn))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@nombre", nombre);

                        int count = (int)comando.ExecuteScalar();
                        verificar = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);
            }
            return verificar;
        }

        public void RegistroCliente(string rtn, string dni, string nombre, int rol, bool estado, int telefono, string correo, string direccion, DateTime fecha)
        {
            try
            {
                using (SqlConnection cn = ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("PA_RegistrarCliente", cn))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@RTN", rtn);
                        comando.Parameters.AddWithValue("@DNI", dni);
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@rol", rol);
                        comando.Parameters.AddWithValue("@estado", estado);
                        comando.Parameters.AddWithValue("@telefono", telefono);
                        comando.Parameters.AddWithValue("@correo", correo);
                        comando.Parameters.AddWithValue("@direccion", direccion);
                        comando.Parameters.AddWithValue("@fecha_Inscripcion", fecha);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cliente registrado correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);
            }
        }
    }
}
