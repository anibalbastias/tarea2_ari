using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_ARI__Bastias___Rojas_
{
    class Funcionario
    {
        public int rut;
        public string dv;
        public string nombre;
        public string apellido_pat;
        public string apellido_mat;
        public string carrera;

        public Funcionario()
        {
            this.rut = 0;
            this.dv = "";
            this.nombre = "";
            this.apellido_pat = "";
            this.apellido_mat = "";
            this.carrera = "";
        }

        public Funcionario(int rut, string dv, string nombre, string apellido_pat,
            string apellido_mat, string carrera)
        {
            this.rut = rut;
            this.dv = dv;
            this.nombre = nombre;
            this.apellido_pat = apellido_pat;
            this.apellido_mat = apellido_mat;
            this.carrera = carrera;
        }

        public int getRut()
        {
            return rut;
        }

        public string getDV()
        {
            return dv;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getApellidoPat()
        {
            return apellido_pat;
        }

        public string getApellidoMat()
        {
            return apellido_mat;
        }

        public string getCarrera()
        {
            return carrera;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setApellidoPat(string apellido_pat)
        {
            this.apellido_pat = apellido_pat;
        }

        public void setApellidoMat(string apellido_mat)
        {
            this.apellido_mat = apellido_mat;
        }

        public void setCarrera(string carrera)
        {
            this.carrera = carrera;
        }

        // Método que será para verificar el rol válido
        public char calcula_dvrut(int rut)
        {
            int suma_rut, digito, secuencia, dv;
            char dvrut;

            suma_rut = 0;
            secuencia = 2;

            while (rut != 0)
            {
                digito = (rut % 10) * secuencia;
                suma_rut = suma_rut + digito;
                rut = rut / 10;
                secuencia++;
                if (secuencia == 8)
                {
                    secuencia = 2;
                }
            }


            dv = 11 - (suma_rut % 11);

            switch (dv)
            {
                case 1: dvrut = '1';
                    break;

                case 2: dvrut = '2';
                    break;

                case 3: dvrut = '3';
                    break;

                case 4: dvrut = '4';
                    break;

                case 5: dvrut = '5';
                    break;

                case 6: dvrut = '6';
                    break;

                case 7: dvrut = '7';
                    break;

                case 8: dvrut = '8';
                    break;

                case 9: dvrut = '9';
                    break;

                case 10: dvrut = 'K';
                    break;

                case 11: dvrut = '0';
                    break;

                default: dvrut = '-';
                    break;
            }


            return dvrut;
        }
    }
}
