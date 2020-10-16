using System;
using System.Collections.Generic;
using System.Text;

namespace myclass
{
    public class clsCalculos // operaciones 
    {
        private double _resultado;

        public clsCalculos()
        {
           
        }

        public clsCalculos(double resultado)
        {
            _resultado = resultado;
        }

        public double suma(double v1, double v2)
        {
            try
            {
                _resultado = v1 + v2;
                return _resultado;
            }
            catch
            {
                return _resultado;
            }

        }

        public double resta (double v1, double v2)
        {
            try
            {
                _resultado = v1 - v2;
                return _resultado;
            }
            catch
            {
                return _resultado;
            }

        }

        public double multiplicar(double v1, double v2)
        {
            try
            {
                _resultado = v1 * v2;
                return _resultado;
            }
            catch
            {
                return _resultado;
            }

        }

        public double Dividir(double v1, double v2)
        {
            try
            {
                _resultado = v1 / v2;
                return _resultado;
            }
            catch
            {
                return _resultado;
            }

        }

       
    }



}
