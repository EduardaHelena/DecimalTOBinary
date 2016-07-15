using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformacao
{
    class Contas
    {
       public int limit = 100;
       public int result;
       List<int> Restos = new List<int>();
       int controle = 0;
       string Final = "";
    
        public void DecimalToBinario(int limit)
        {
                controle = 0; 
                result = limit;

                while (result > 1)
                {
                    Restos.Add(result % 2);
                    result = result/2;
                    Final+=Restos[controle].ToString();
                    controle++;
                }
                Restos.Add(result);
                Final+=Restos[controle].ToString();
                Console.Write (Reverse( Final));     
                Console.ReadKey();
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
       


    }
}
