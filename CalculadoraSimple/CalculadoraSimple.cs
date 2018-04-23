using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraEjemplo
{
    public class CalculadoraSimple
    {
        public int sumar(int v1, int v2)
        {
            return v1 + v2;
        }

        public int suma(string v1, string v2)
        {
            return (v1.Equals("")) ? Convert.ToInt16(v2) : Convert.ToInt16(v1) + Convert.ToInt16(v2);
        }

        public int restar(int v1, int v2)
        {
            return v1 - v2;
        }

        public int multiplicar(int v1, int v2)
        {
            return v1 * v2;
        }

        public int dividir(int v1, int v2)
        {
            return v1 / v2;
        }

        public int sumar(string v1, string v2)
        {
            int a = (v1.Equals("")) ? 0 : Convert.ToInt32(v1);
            int b = (v2.Equals("")) ? 0 : Convert.ToInt32(v2);

            return a + b;

        }


        public double potencia(int a, int b){
        
       
        return Math.Pow(a, b);
            
        }

        

        public double raizcuadrada(int v)
        { 
            return Math.Sqrt(v);
        }

        public int residuo(int v1, int v2)
        {
            return v1 % v2;
        }

        public int multiplicarceroC(int v1, int v2)
        {
            return v1 == 0 ? 0 : v2 == 0 ? 0 : v1*v2;
        } 
    }
}
