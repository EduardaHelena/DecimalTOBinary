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
            bool loop = true;
            while (loop)
            {
                Contas p = new Contas();
                Console.WriteLine("Qual operação voce deseja?");
                Console.WriteLine("");
                Console.WriteLine("1 - Decimal To Binary");
                Console.WriteLine("2 - Binary to decimal");
                Console.WriteLine("3 - Decimal to Hexadecimal");
                Console.WriteLine("4 - Hexadecimal to Decimal");
                Console.WriteLine("5 - Hexadecimal to Binario");
                Console.WriteLine("6 - Binario to Hexadecimal");

               ConsoleKeyInfo Operaçoes = Console.ReadKey();
               Console.WriteLine("");
                int limit;
                string limit2;
                switch (Operaçoes.Key)
                {
                    case ConsoleKey.D1  :
                        Console.WriteLine("Digite o número Decimal ");
                        Console.WriteLine("");
                        limit = int.Parse(Console.ReadLine());
                      
                       Console.WriteLine( p.DecimalToBinario(limit));
                        break;

                    case ConsoleKey.NumPad1:
                        Console.WriteLine("Digite o número Decimal ");
                        Console.WriteLine("");
                        limit = int.Parse(Console.ReadLine());
                        Console.WriteLine(p.DecimalToBinario(limit));
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine("Digite o número Binário ");
                        Console.WriteLine("");
                        limit = int.Parse(Console.ReadLine());
                        Console.WriteLine( p.BinarioToDecimal(limit));
                        break;

                    case ConsoleKey.NumPad2:
                        Console.WriteLine("Digite o número Binário ");
                        Console.WriteLine("");
                        limit = int.Parse(Console.ReadLine());
                        Console.WriteLine(p.BinarioToDecimal(limit));
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine("Digite o número Decimal ");
                        Console.WriteLine("");
                        limit = int.Parse(Console.ReadLine());
                        Console.WriteLine( p.DecimalToHex(limit));
                        break;

                    case ConsoleKey.NumPad3:
                        Console.WriteLine("Digite o número Decimal ");
                        Console.WriteLine("");
                        limit = int.Parse(Console.ReadLine());
                        Console.WriteLine(p.DecimalToHex(limit));
                        break;

                    case ConsoleKey.D4:
                        Console.WriteLine("Digite o número Hexadecimal ");
                        Console.WriteLine("");
                         limit2 = Console.ReadLine();
                       Console.WriteLine(  p.HexToDecimal(limit2));
                        break;

                    case ConsoleKey.NumPad4:
                        Console.WriteLine("Digite o número Hexadecimal ");
                        Console.WriteLine("");
                        limit2 = Console.ReadLine();
                        Console.WriteLine(p.HexToDecimal(limit2));
                        break;
                        
                    case ConsoleKey.D5:
                        Console.WriteLine("Digite o número Hexadecimal ");
                        Console.WriteLine("");
                        limit2 = Console.ReadLine();
                        int temp= p.HexToDecimal(limit2);
                        Console.WriteLine(p.DecimalToBinario(temp));
                        break;
                    case ConsoleKey.NumPad5:
                        Console.WriteLine("Digite o número Hexadecimal ");
                        Console.WriteLine("");
                        limit2 = Console.ReadLine();
                        int temp2 = p.HexToDecimal(limit2);
                        Console.WriteLine(p.DecimalToBinario(temp2));
                        break;

                    case ConsoleKey.D6:
                        Console.WriteLine("Digite o número Binario ");
                        Console.WriteLine("");
                        limit =int.Parse(Console.ReadLine());

                        int temp3 =p.BinarioToDecimal(limit);
                        Console.WriteLine(p.DecimalToHex(temp3));
                        break;
                    case ConsoleKey.NumPad6:
                        Console.WriteLine("Digite o número Binario ");
                        Console.WriteLine("");
                        limit = int.Parse(Console.ReadLine());

                        int temp4 = p.BinarioToDecimal(limit);
                        Console.WriteLine(p.DecimalToHex(temp4));
                        break;


                    default:
                        Console.WriteLine("Voce digitou o controle errado");
                        Console.WriteLine("");
                        break;

                }
                Console.ReadLine();
            }/*

          /*  try
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
            }*/

           // p.DecimalToBinario(p.limit);
            //p.BinarioToDecimal(p.limit);
           //p.HexToDecimal(Console.ReadLine());
          //  Console.WriteLine(divisao);
            
          

        }
    }
}
