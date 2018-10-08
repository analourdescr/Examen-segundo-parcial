using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class SeñalPotencia : Señal
    {
        public SeñalPotencia()
        {
            Muestras = new List<Muestra>();
            N = 0.0;
            AmplitudMaxima = 0.0;
        }

        public SeñalPotencia(double n)
        {
            N = n;
            Muestras = new List<Muestra>();
            AmplitudMaxima = 0.0;
        }

        override public double evaluar(double tiempo)
        {
            double resultado;
            resultado = tiempo;
            if(resultado < 0)
            {
                resultado = -(Math.Pow(tiempo,N));
            }
            else if (resultado > 0)
            {
                resultado = (Math.Pow(tiempo, N));
            }
            else 
            {
                resultado = 0;
            }
            return resultado;
        }
    }
}
