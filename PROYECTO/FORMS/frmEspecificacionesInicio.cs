﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO.CLASES;

namespace Proyecto_de_desarrolo.Formularios
{
    public partial class frmEspecificacionesInicio : Form
    {
        public frmEspecificacionesInicio()
        {
            InitializeComponent();
        }


        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            /*this.Close();

            frmInicioSesion InicioS = new frmInicioSesion();
            InicioS.Show();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor ingresar los datos");    //en caso de que el usuario este vacio para recup la contraseña
            }
            else
            {
                try
                {
                    Cconexion objC = new Cconexion();

                    using (SqlConnection cn = objC.leer())
                    {
                        if (cn.State == ConnectionState.Open)
                        {
                            cn.Close();
                        }

                        cn.Open();
                        

                        SqlCommand comandoPreguntaRecuperacion = new SqlCommand("PA_ObtenerPreguntaRecuperacion", cn);
                        comandoPreguntaRecuperacion.CommandType = CommandType.StoredProcedure;  //obtiene la pregunta de recuperacion con un procedimiento almacenado.

                        comandoPreguntaRecuperacion.Parameters.AddWithValue("@usuario", usuario);

                        SqlDataReader reader = comandoPreguntaRecuperacion.ExecuteReader();

                        if (reader.Read())
                        {
                            string preguntaRecuperacion = reader["Pregunta_Recuperacion"].ToString();
                            lblPregunta.Text = preguntaRecuperacion;
                            //muestra la pregunta de recuperacion del usuario obtenida en un label.
                            MessageBox.Show("Usuario encontrado");
                            label1.Enabled = false;
                            txtUser.Enabled = false;
                            btnBuscar.Enabled = false;

                            lblPregunta.Show();
                            lblIngrese.Show();
                            txtRespuesta_Recuperacion.Show();
                            btnSiguiente.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado");
                        }

                        reader.Close();
                        cn.Close();     //cierra la conexion.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
      
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string respuestaIngresada = txtRespuesta_Recuperacion.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(respuestaIngresada))
            {
                MessageBox.Show("Por favor ingresar todos los datos");  //en caso de que el usuarip o la respuesta esten en blanco.
            }
            else
            {
                try
                {
                    Cconexion objC = new Cconexion();
                    using (SqlConnection cn = objC.leer())
                    {
                        if (cn.State == ConnectionState.Open)
                        {
                            cn.Close();
                        }

                        cn.Open();
                        
                        SqlCommand comandoRespuestaRecuperacion = new SqlCommand("PA_ObtenerRespuestaRecuperacion", cn);
                        comandoRespuestaRecuperacion.CommandType = CommandType.StoredProcedure;
                        //procedimiento almacenado para obtener la respuesta de recuperacion de contraseña que uso el usuairo al registrarse.
                        comandoRespuestaRecuperacion.Parameters.AddWithValue("@usuario", usuario);

                        SqlDataReader reader = comandoRespuestaRecuperacion.ExecuteReader();

                        if (reader.Read())
                        {
                            string respuestaRecuperacion = reader["Respuesta_Recuperacion"].ToString();

                            if (respuestaIngresada == respuestaRecuperacion)
                            {
                                frmRecuperacion frm = new frmRecuperacion();    //si la respuesta de recuperacion coincide con lo obtenido del procedimeinto almacenado muestra el formulario de cambio de contraseña
                                frm.Show();
                                frm.Usuario = txtUser.Text;
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("La respuesta es incorrecta");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado");
                        }

                        reader.Close();
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string respuestaIngresada = txtRespuesta_Recuperacion.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(respuestaIngresada))
            {
                MessageBox.Show("Por favor ingresar todos los datos");      //valida que para poder continuar almenos haya ingresado algo de datos a los textbox.
            }
            else
            {
                try
                {
                    Cconexion objC = new Cconexion();
                    using (SqlConnection cn = objC.leer())
                    {
                        if (cn.State == ConnectionState.Open)
                        {
                            cn.Close();
                        }

                        cn.Open();

                        SqlCommand comandoRespuestaRecuperacion = new SqlCommand("PA_ObtenerRespuestaRecuperacion", cn);
                        comandoRespuestaRecuperacion.CommandType = CommandType.StoredProcedure;

                        comandoRespuestaRecuperacion.Parameters.AddWithValue("@usuario", usuario);

                        SqlDataReader reader = comandoRespuestaRecuperacion.ExecuteReader();

                        if (reader.Read())
                        {
                            string respuestaRecuperacion = reader["Respuesta_Recuperacion"].ToString();

                            if (respuestaIngresada == respuestaRecuperacion)
                            {
                                frmRecuperacion frm = new frmRecuperacion();
                                frm.Show();
                                frm.Usuario = txtUser.Text;
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("La respuesta es incorrecta");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado");
                        }

                        reader.Close();
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor ingresar los datos");
            }
            else
            {
                try
                {
                    Cconexion objC = new Cconexion();

                    using (SqlConnection cn = objC.leer())
                    {
                        if (cn.State == ConnectionState.Open)
                        {
                            cn.Close();
                        }

                        cn.Open();


                        SqlCommand comandoPreguntaRecuperacion = new SqlCommand("PA_ObtenerPreguntaRecuperacion", cn);
                        comandoPreguntaRecuperacion.CommandType = CommandType.StoredProcedure;

                        comandoPreguntaRecuperacion.Parameters.AddWithValue("@usuario", usuario);

                        SqlDataReader reader = comandoPreguntaRecuperacion.ExecuteReader();

                        if (reader.Read())
                        {
                            string preguntaRecuperacion = reader["Pregunta_Recuperacion"].ToString();
                            lblPregunta.Text = preguntaRecuperacion;

                            MessageBox.Show("Usuario encontrado");
                            label1.Enabled = false;
                            txtUser.Enabled = false;
                            btnBuscar.Enabled = false;
                            //busca si encuentra un usuario con ese nombre, sino dice que el usuario no fue encontrado.
                            lblPregunta.Show();
                            lblIngrese.Show();
                            txtRespuesta_Recuperacion.Show();
                            btnSiguiente.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado");
                        }

                        reader.Close();
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
