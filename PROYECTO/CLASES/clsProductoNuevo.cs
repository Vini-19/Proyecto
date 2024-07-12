using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.CLASES
{
    public class clsProductoNuevo
    {
        private string codBarra;
        private string nomProducto;
        private string proveedor;
        private float precio;
        private int cantidad;
        private int personasid;
        private int productoid;

        // nuevos
        private string categoria;
        private int categoriaId;
        private string Nombre_Imagen;
        private byte[] Imagen;

        public clsProductoNuevo()
        {
            codBarra = string.Empty;
            nomProducto = string.Empty;
            proveedor = string.Empty;
            precio = 0;
            cantidad = 0;
            personasid = 0;
            productoid = 0;



            categoria = string.Empty;
            categoriaId = 0;
            Nombre_Imagen = string.Empty;
            Imagen = new byte[0];
        }

        public clsProductoNuevo(string codBarra, string nomProducto, string proveedor, float precio, int cantidad, int personasid, int productoid, string categoria, int categoriaId, string Nombre_Imagen, byte[] Imagen)
        {
            this.codBarra = codBarra;
            this.nomProducto = nomProducto;
            this.proveedor = proveedor;
            this.precio = precio;
            this.cantidad = cantidad;
            this.personasid = personasid;
            this.productoid = productoid;


            this.categoria = categoria;
            this.categoriaId = categoriaId;
            this.Nombre_Imagen = Nombre_Imagen;
            this.Imagen = Imagen;
        }

        public string getcodBarra() { return codBarra; }
        public void setcodBarra(string text) { codBarra = text; }
        public string getnomProducto() { return nomProducto; }
        public void setnomProducto(string text) { nomProducto = text; }
        public string getproveedor() { return proveedor; }
        public void setproveedor(string text) { proveedor = text; }
        public float getprecio() { return precio; }
        public void setprecio(float value) { precio = value; }
        public int getcantidad() { return cantidad; }
        public void setcantidad(int value) { cantidad = value; }
        public int getpersonasid() { return personasid; }
        public void setpersonasid(int value) { personasid = value; }
        public int getproductoid() { return productoid; }
        public void setproductoid(int value) { productoid = value; }

        public string getcategoria() { return categoria; }
        public void setcategoria(string value) { categoria = value; }
        public int getcategoriaId() { return categoriaId; }
        public void setcategoriaId(int value) { categoriaId = value; }
        public string getNombre_Imagen() { return Nombre_Imagen; }
        public void setNombre_Imagen(string value) { Nombre_Imagen = value; }
        public byte[] getImagen() { return Imagen; }
        public void setImagen(byte[] value) { Imagen = value; }
    }

}
 
