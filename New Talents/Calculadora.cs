using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Talents
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data
        public Calculadora(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }
       public int somar(int val1, int val2)
        {
            int res = val1 + val2;

            listahistorico.Insert(0, "Res: " + res);
            return res;

        }
       public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;

            listahistorico.Insert(0, "Res: " + res);
            return res;
        }
       public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;

            listahistorico.Insert(0, "Res: " + res);
            return res;
        }
        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;

            listahistorico.Insert(0, "Res: " + res);
            return res;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count -3);
            return listahistorico; 
        }
    }
}
