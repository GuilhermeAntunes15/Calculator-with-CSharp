using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    class Calculos
    {
        public double Somar(double v1, double v2)
        {
            return v1 + v2;
        }

        public double Subtrair(double v1, double v2)
        {
            return v1 - v2;
        }

        public double Dividir(double v1, double v2)
        {
            if(v2 == 0)
            {
                return 0;
            }
            else
            {
                return v1 / v2;
            }
            
        }

        public double Multiplicar(double v1, double v2)
        {
            return v1 * v2;
        }

        public double Porcentagem(double v1)
        {
            return v1 / 100;
        }

        public double Potenciacao(double v1, double v2)
        {
            return Math.Pow(v1,v2);
        }

        public double Raiz(double v1, double v2)
        {
            return Math.Pow(v1, 1 / v2);
        }
    }
}
