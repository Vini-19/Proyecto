using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace frmAdmin.CLASS
{
    public class Cconexion
    {
        public SqlConnection leer()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Proyecto_de_desarrolo.Properties.Settings.SQL"].ConnectionString);
            
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);
            }

            return cn;
        }

        public void RegistroUsu(string contra, string pregunta, string respuesta, string nomUsuario)
        {
            try
            {
                using (SqlConnection cn = leer())
                {
                    SqlCommand comandoExisteUsuario = new SqlCommand("PA_RegistroUsuario", cn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    comandoExisteUsuario.Parameters.AddWithValue("@Contraseña", contra);
                    comandoExisteUsuario.Parameters.AddWithValue("@Roles_ID", 3);
                    comandoExisteUsuario.Parameters.AddWithValue("@Pregunta_Recuperacion", pregunta);
                    comandoExisteUsuario.Parameters.AddWithValue("@Respuesta_Recuperacion", respuesta);
                    comandoExisteUsuario.Parameters.AddWithValue("@Nombre_Usuario", nomUsuario);

                    comandoExisteUsuario.ExecuteNonQuery();
                    MessageBox.Show("Usuario regi
