using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformacao
{
    class Comando
    {
        static void Main(string[] args)
        {
           Contas p = new Contas();

            Console.WriteLine("Qual número voce deseja converter?");
            try
            {
               
                p.limit = int.Parse(Console.ReadLine()); 
                if(p.limit < 0)
                { Console.WriteLine("Não é possível converter números negativos");
                p.limit = int.Parse("dasd"); 
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ERR0!!!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            p.DecimalToBinario(p.limit);
          //  Console.WriteLine(divisao);

            Console.ReadKey();

        }
    }
}
