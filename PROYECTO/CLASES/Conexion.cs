using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROYECTO.CLASES
{
    public class Cconexion
    {
        public SqlConnection leer()
        {
            SqlConnection cn = new SqlConnection("Data Source=croas.database.windows.net;Initial Catalog=Proyecto_Carniceria;Persist Security Info=True;User ID=Vini;Password=Cr0as_P4ss;TrustServerCertificate=True");
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            else
            {
                cn.Open();
            }
            return cn;

        }

        public void RegistroUsu(string contra, string pregunta, string respuesta, string nomUsuario, int Roles_ID)
        {

            Cconexion conexion = new Cconexion();

            try
            {
                SqlConnection cn = conexion.leer();
                if (cn.State == ConnectionState.Open)
                {
                    SqlCommand comandoExisteUsuario = new SqlCommand("PA_RegistroUsuario", cn);
                    comandoExisteUsuario.CommandType = CommandType.StoredProcedure;


                    comandoExisteUsuario.Parameters.AddWithValue("@Contraseña", contra);
                    comandoExisteUsuario.Parameters.AddWithValue("@Roles_ID", Roles_ID);
                    comandoExisteUsuario.Parameters.AddWithValue("@Pregunta_Recuperacion", pregunta);
                    comandoExisteUsuario.Parameters.AddWithValue("@Respuesta_Recuperacion", respuesta);
                    comandoExisteUsuario.Parameters.AddWithValue("@Nombre_Usuario", nomUsuario);


                    comandoExisteUsuario.ExecuteNonQuery();

                    MessageBox.Show("Usuario registrado correctamente");

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


        public bool VerificarClienteExistente(string dni)
        {
            Cconexion conexion = new Cconexion();
            bool verificar = true;
            try
            {
                using (SqlConnection cn = conexion.leer())
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    SqlCommand comandoExisteCliente = new SqlCommand("PA_VerificarClienteExistente", cn);
                    comandoExisteCliente.CommandType = CommandType.StoredProcedure;
                    comandoExisteCliente.Parameters.AddWithValue("@dni", dni);

                    int count = (int)comandoExisteCliente.ExecuteScalar();

                    if (count > 0)
                    {

                        verificar = true;

                    }
                    else
                    {
                        verificar = false;

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);
            }
            return verificar;
        }
        public bool VerificarUsuarioExistente(string usu)
        {
            Cconexion conexion = new Cconexion();
            bool verificar = true;
            try
            {
                using (SqlConnection cn = conexion.leer())
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    SqlCommand comandoExisteUsuario = new SqlCommand("PA_VerificarUsuarioExistente", cn);
                    comandoExisteUsuario.CommandType = CommandType.StoredProcedure;
                    comandoExisteUsuario.Parameters.AddWithValue("@nombre", usu);

                    int count = (int)comandoExisteUsuario.ExecuteScalar();

                    if (count > 0)
                    {

                        verificar = true;

                    }
                    else
                    {
                        verificar = false;

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

            Cconexion conexion = new Cconexion();

            try
            {
                using (SqlConnection cn = conexion.leer())
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    SqlCommand comandoInsertarCliente = new SqlCommand("PA_RegistrarCliente", cn);
                    comandoInsertarCliente.CommandType = CommandType.StoredProcedure;
                    comandoInsertarCliente.Parameters.AddWithValue("@RTN", rtn);
                    comandoInsertarCliente.Parameters.AddWithValue("@DNI", dni);
                    comandoInsertarCliente.Parameters.AddWithValue("@nombre", nombre);
                    comandoInsertarCliente.Parameters.AddWithValue("@rol", rol);
                    comandoInsertarCliente.Parameters.AddWithValue("@estado", estado);
                    comandoInsertarCliente.Parameters.AddWithValue("@telefono", telefono);
                    comandoInsertarCliente.Parameters.AddWithValue("@correo", correo);
                    comandoInsertarCliente.Parameters.AddWithValue("@direccion", direccion);
                    comandoInsertarCliente.Parameters.AddWithValue("@fecha_Inscripcion", fecha);

                    comandoInsertarCliente.ExecuteNonQuery();

                    MessageBox.Show("Cliente registrado correctamente");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);
            }
        }

        //public DataTable DataGridViewClientes()
        //{
        //    string consultaSql = "SELECT PersonasID, RTN_Persona, DNI_Persona, Roles_ID, Primer_Nombre, Estado, Numero_Telefono, Correo, Direccion, Fecha_Inscripcion FROM Personas WHERE Roles_ID = 3";

        //    try
        //    {
        //        Cconexion conexion = new Cconexion();
        //        using (SqlConnection cn = conexion.leer())
        //        {

        //            DataTable dt = new DataTable();
        //            SqlCommand cmd = new SqlCommand(consultaSql,cn);
        //            cmd.Parameters.AddWithValue("PersonasID",)



        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al cargar datos: " + ex.Message);
        //    }
        //}
    }
}
