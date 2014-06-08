using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_ARI__Bastias___Rojas_
{
    class Venta
    {
        public int id { get; set; }
        public int id_producto { get; set; }
        public int id_funcionario { get; set; }
        public int cantidad { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }

        public Venta()
        {
            this.id = 0;
            this.id_producto = 0;
            this.id_funcionario = 0;
            this.cantidad = 0;
            this.fecha = "";
            this.hora = "";
        }

        public Venta(int id, int id_producto, int id_funcionario, int cantidad,
            string fecha, string hora)
        {
            this.id = id;
            this.id_producto = id_producto;
            this.id_funcionario = id_funcionario;
            this.cantidad = cantidad;
            this.fecha = fecha;
            this.hora = hora;
        }

        public int getId()
        {
            return id;
        }

        public int getIdProducto()
        {
            return id_producto;
        }

        public int getIdFuncionario()
        {
            return id_funcionario;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public string getFecha()
        {
            return fecha;
        }

        public string getHora()
        {
            return hora;
        }

        public void setIdProducto(int id_producto)
        {
            this.id_producto = id_producto;
        }

        public void setIdFuncionario(int id_funcionario)
        {
            this.id_funcionario = id_funcionario;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public void setFecha(string fecha)
        {
            this.fecha = fecha;
        }

        public void setHora(string hora)
        {
            this.hora = hora;
        }
    }
}
