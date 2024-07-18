using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO;
using PROYECTO.CLASES;
using Proyecto_de_desarrolo.Clases;

namespace Proyecto_de_desarrolo.Formularios
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;



        }

        clsValidaciones val = new clsValidaciones();

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            val.validarcm(cmbPregunta.Text);
            if (txtUsuario.Text == "" || txtContra.Text == "" || txtRespuesta.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;

            }
            else
            {
                clsRegistro registro = new clsRegistro();
                Cconexion conexion = new Cconexion();
                if (errorProvider1.GetError(txtUsuario) == "" && errorProvider1.GetError(txtContra) == "" && errorProvider1.GetError(txtRespuesta) == "")
                {

                    registro.setUsu(txtUsuario.Text.Trim());
                    registro.setContra(txtContra.Text);
                    registro.setPregunta(cmbPregunta.Text);
                    registro.setRespuesta(txtRespuesta.Text);

                    if (conexion.VerificarUsuarioExistente(txtUsuario.Text))
                    {
                        MessageBox.Show("Ya existe este usuario");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(registro.getUsu()) || string.IsNullOrWhiteSpace(registro.getContra()) || string.IsNullOrWhiteSpace(registro.getPregunta()) || string.IsNullOrWhiteSpace(registro.getRespuesta()))
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                        return;
                    }
                    conexion.RegistroUsu(registro.getContra(), registro.getPregunta(), registro.getRespuesta(), registro.getUsu(), 3);


                    frmInicioSesion frmInicioSesion = new frmInicioSesion();
                    frmInicioSesion.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }

            }
        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtRespuesta, val.txt_vacio(txtRespuesta.Text) + val.rango_nombre(txtRespuesta.Text) + val.espacio_inicio_final(txtRespuesta.Text));
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtContra, val.validarcontra(txtContra.Text));
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUsuario, val.txt_vacio(txtUsuario.Text) + val.rango_usuario(txtUsuario.Text) + val.espacio_inicio_final(txtUsuario.Text) + val.espacio(txtUsuario.Text));
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmInicioSesion InicioS = new frmInicioSesion();
            InicioS.Show();
        }
    }
}
