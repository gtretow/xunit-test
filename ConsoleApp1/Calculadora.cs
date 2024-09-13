using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;

        public Calculadora(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int val1, int val2)
        {
            int c = val1 + val2;
            listahistorico.Insert(0,"Result:" + c + " - data: " + data);
            return c;
        }
        public int Multiplicar(int val1, int val2)
        {
            int c = val1 * val2;
            listahistorico.Insert(0, "Result:" + c + " - data: " + data);
            return c;
        }
        public int Subtrair(int val1, int val2)
        {
            int c = val1 - val2;
            listahistorico.Insert(0, "Result:" + c + " - data: " + data);
            return c;
        }
        public int Dividir(int val1, int val2)
        {
            int c = val1 / val2;
            listahistorico.Insert(0, "Result:" + c + " - data: " + data);
            return c;
        }

        public List<string> historico()
        {
            List<String> res;
            listahistorico.RemoveRange(3, listahistorico.Count -3);
            return listahistorico;
        }
    }
}
