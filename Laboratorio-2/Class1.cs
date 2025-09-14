using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class Class1
    {
        public double mayorA1000(double[] a)
        {

            double Ma1000 = 0;

            foreach (double dato in a)
            {
                if (dato > 1000)
                {
                    Ma1000++;
                }
            }
            return Ma1000;
        }
        public double sumaMayorA1000(double[] a)
        {
            double suma = 0;

            foreach (double dato in a)
            {
                if (dato > 1000)
                {
                    suma = suma + dato;
                }
            }
            return suma;
        }
        public double menorA1000(double[] a)
        {

            double Me1000 = 0;

            foreach (double dato in a)
            {
                if (dato <= 1000 && dato > 500)
                {
                    Me1000++;
                }
            }
            return Me1000;
        }
        public double sumaMenorA1000(double[] a)
        {
            double suma = 0;

            foreach (double dato in a)
            {
                if (dato <= 1000 && dato > 500)
                {
                    suma = suma + dato;
                }
            }
            return suma;
        }

        public double menorA500(double[] a)
        {
            double Me500 = 0;

            foreach (double dato in a)
            {
                if (dato <= 500)
                {
                    Me500++;
                }
            }
            return Me500;
        }
        public double sumaMenorA500(double[] a)
        {
            double suma = 0;

            foreach (double dato in a)
            {
                if (dato <= 500)
                {
                    suma = suma + dato;
                }
            }
            return suma;
        }
        public double sumaTotal(double[] a)
        {
            double suma = 0;
            foreach (double dato in a)
            {
                suma += dato;
            }
            return suma;
        }
    }
}
