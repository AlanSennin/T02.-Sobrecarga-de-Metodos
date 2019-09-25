using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga1
{
    public class Operaciones
    {
        public double Multiplicar() //Metodo sin Parametros
        {
            double Res;

            Res = 0;

            return Res;
        }

        public double Multiplicar(double A) //Metodo con 1 Parametro
        {
            double Res;

            Res = A;

            return Res;  
        }

        public double Multiplicar(double B, double C) //Metodo con 2 Parametros
        {
            double Res;

            Res = B * C;

            return Res;
        }
    }
}
