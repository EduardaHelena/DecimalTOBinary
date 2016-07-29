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
     
    
        public int DecimalToBinario(int limit)
        {
                controle = 0; 
                result = limit;
                Restos = new List<int>();
                while (result > 1)
                {
                    Restos.Add(result % 2);
                    result = result/2;
                    Final+=Restos[controle].ToString();
                    controle++;
                }
                Restos.Add(result);
                Final+=Restos[controle].ToString();
                
                return int.Parse(Reverse(Final));

        }

        public int BinarioToDecimal(int limit)
        {
           string temp= Reverse( limit.ToString());
           //Console.WriteLine(temp);
           int result;
           int finalR = 0 ; 
            for (int i = 0;i<temp.Length;i++)
            {
               // Console.WriteLine("o numero testado é " + int.Parse(temp[i].ToString())+" valor i "+i);
                result = int.Parse(temp[i].ToString()) * Convert.ToInt32(Math.Pow(2,i));
                //result += result;
               // Console.WriteLine(result);
                finalR += result;
            }
            
            return finalR;
        }
        public int HexToDecimal(string hex)
        {
            int result =0 ; 
            string temp = Reverse(hex);
            int resultFinal=0;
            for (int i= 0;i<temp.Length;i++)
            {
                int num;
                if (int.TryParse(temp[i].ToString(), out num))
                {
                   // Console.WriteLine("consegue");
                }
                else
                {
                    //Console.WriteLine("Nop consegue");
                    switch (temp[i].ToString().ToUpper())
                    {
                        case "A":
                            num = 10;
                            break;
                        case "B":
                            num = 11;
                            break;
                        case "C":
                            num = 12;
                            break;
                        case "D":
                            num = 13;
                            break;
                        case "E":
                            num = 14;
                            break;
                        case "F":
                            num = 15;
                            break;
                        default:
                           Console.WriteLine("Essa Letra n é HEX");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;                    
                                                        
                    }
                }//Console.WriteLine("numero "+num);
                result = num * Convert.ToInt32(Math.Pow(16, i));
                //Console.WriteLine("valor " + result);
                resultFinal += result;
            }
            return  resultFinal;
        }
        public string  DecimalToHex(int limit )
        {
            Restos = new List<int>() ;
            int controll = 0; 
             int result2 = limit;
             
             while (result2 > 1)
                {
                    Restos.Add(result2 % 16);
                    result2 = result2/16;
                 switch(Restos[controll])
                 {  
                     case 10:
                         Final += "A";
                         break;
                         case 11:
                         Final += "B";
                         break;
                         case 12:
                         Final += "C";
                         break;
                         case 13:
                         Final += "D";
                         break;
                         case 14:
                         Final += "E";
                         break;
                          case 15:
                         Final += "F";
                         break;

                     default:
                          Final += Restos[controll].ToString();
                         break;

                 }                   
                    
                    //Console.WriteLine(Restos[controll]);
                  //  Console.Write("divisores:" + result2);
                    controll++;
                                       
                }
           //  Restos.Add(result2);
           //  Final += Restos[controll].ToString();
           return Reverse(Final);             
        }


         



        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
       


    }
}
