using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_ARI__Bastias___Rojas_
{
    class Producto
    {
        public int id;
        public string nombre;
        public string tipo;
        public int precio;
        public int stock;

        public Producto()
        {
            this.id = 0;
            this.nombre = "";
            this.tipo = "";
            this.precio = 0;
            this.stock = 0;
        }

        public Producto(int id, string nombre, string tipo, int precio, int stock)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipo = tipo;
            this.precio = precio;
            this.stock = stock;
        }

        public int getId()
        {
            return id;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getTipo()
        {
            return tipo;
        }

        public int getPrecio()
        {
            return precio;
        }

        public int getStock()
        {
            return stock;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public void setPrecio(int precio)
        {
            this.precio = precio;
        }

        public void setStock(int stock)
        {
            this.stock = stock;
        }
    }
}
