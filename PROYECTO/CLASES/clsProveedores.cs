using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.CLASES
{
    public class clsProveedores
    {
        private string rtn;
        private string dni;
        private string nombre;
        private int telefono;
        private string correo;
        private string direccion;
        private string categoria;
        private int rol;
        private bool estado;

        public clsProveedores()
        {
            rtn = string.Empty;
            dni = string.Empty;
            nombre = string.Empty;
            telefono = 0;
            correo = string.Empty;
            direccion = string.Empty;
            categoria = string.Empty;
            rol = 4;
            estado = true;
        }

        public clsProveedores(string rtn, string dni, string nombre, int telefono, string correo, string direccion, string categoria, int rol, bool estado)
        {
            this.rtn = rtn;
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
            this.direccion = direccion;
            this.categoria = categoria;
            this.rol = rol;
            this.estado = estado;
        }

        public string getrtn() { return rtn; }
        public void setrtn(string value) { rtn = value; }
        public string getdni() { return dni; }
        public void setdni(string value) { dni = value; }
        public string getnombre() { return nombre; }
        public void setnombre(string value) { nombre = value; }
        public int gettelefono() { return telefono; }
        public void settelefono(int value) { telefono = value; }
        public string getcorreo() { return correo; }
        public void setcorreo(string value) { correo = value; }
        public string getdireccion() { return direccion; }
        public void setdireccion(string value) { direccion = value; }
        public string getCategoria() { return categoria; }
        public void setcategoria(string value) { categoria = value; }
        public int getrol() { return rol; }
        public void setrol(int value) { rol = value; }
        public bool getestado() { return estado; }
        public void setestado(bool value) { estado = value; }
    }
}
