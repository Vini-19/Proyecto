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
using PROYECTO;
using PROYECTO.CLASES;
using Proyecto_de_desarrolo.Clases;

namespace Proyecto_de_desarrolo.Formularios
{
    public partial class frmRecuperacion : Form
    {
        public frmRecuperacion()
        {
            InitializeComponent();
        }

        clsValidaciones val = new clsValidaciones();


       public string Usuario { get; set; }

        
        private void txtNueva_Contraseña1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNueva_Contraseña1, val.validarcontra(txtNueva_Contraseña1.Text));
        }

        private void txtNueva_Contraseña2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNueva_Contraseña2, val.validarcontra(txtNueva_Contraseña2.Text));
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNueva_Contraseña1.Text == "" || txtNueva_Contraseña2.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;

            }
            else
            {

                if (errorProvider1.GetError(txtNueva_Contraseña1) == "" && errorProvider1.GetError(txtNueva_Contraseña2) == "")
                {
                    string nuevaContraseña1 = txtNueva_Contraseña1.Text;
                    string nuevaContraseña2 = txtNueva_Contraseña2.Text;

                    if (nuevaContraseña1 != nuevaContraseña2)
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                    else
                    {
                        try
                        {
                            clsRegistro registro = new clsRegistro();
                            Cconexion objC = new Cconexion();
                            using (SqlConnection cn = objC.leer())
                            {
                                if (cn.State == ConnectionState.Open)
                                {
                                    cn.Close();
                                }

                                cn.Open();

                                SqlCommand comandoRecuperarContra = new SqlCommand("PA_ActualizarContraseña", cn);
                                comandoRecuperarContra.CommandType = CommandType.StoredProcedure;

                                comandoRecuperarContra.Parameters.AddWithValue("@nuevaContraseña", nuevaContraseña2);
                                comandoRecuperarContra.Parameters.AddWithValue("@usuario", Usuario);

                                int filasAfectadas = comandoRecuperarContra.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    MessageBox.Show("Contraseña actualizada correctamente");
                                    this.Hide();
                                    frmInicioSesion ini = new frmInicioSesion();
                                    ini.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Error al actualizar la contraseña");
                                }

                                cn.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");

                }

            }

        }
        }
    }

