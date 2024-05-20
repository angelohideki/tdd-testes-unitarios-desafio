using System.Collections.Generic;

namespace ProjectTDD
{
    public class Calculadora
    {
        private readonly List<string> listaHistorico;
        private readonly string data;

        public Calculadora(string data )
        {
            this.data = data;
            listaHistorico = new List<string>();
        }

          public int Somar(int val1, int val2)
        {
            int resultado = val1 + val2;

            listaHistorico.Insert(0, "resultado da adição = " + resultado + " data: "+data);

            return resultado;
 
        }

        public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;

            listaHistorico.Insert(0, "resultado da subtração = " + resultado + " data: " + data);

            return resultado;
        }
        public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;

            listaHistorico.Insert(0, "resultado da multiplicação = " + resultado + " data: " + data);

            return resultado;
        }

        public int Dividir(int val1, int val2)
        {
            int resultado = val1 / val2;

            listaHistorico.Insert(0, "resultado da divisão=  " + resultado + " data: " + data);

            return resultado;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
