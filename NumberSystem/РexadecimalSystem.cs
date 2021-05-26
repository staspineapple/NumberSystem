using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystem
{
    public class РexadecimalSystem:ISystem
    {
        int dec;

        List<string> result = new List<string> { };

        public РexadecimalSystem(int number)
        {
            dec = number;
        }

        public РexadecimalSystem(List<string> number)
        {
            result = number;
        }


        public void FromDecimalToPexa()
        {
            while (dec >= 16)
            {
                switch (dec % 16)
                {
                    case 10:
                        result.Add("A");
                        break;
                    case 11:
                        result.Add("B");
                        break;
                    case 12:
                        result.Add("C");
                        break;
                    case 13:
                        result.Add("D");
                        break;
                    case 14:
                        result.Add("E");
                        break;
                    case 15:
                        result.Add("F");
                        break;
                    default:
                        result.Add($"{dec % 16}");
                        break;
                }
                
                dec = (dec - dec % 16) / 16;
            }
            if (dec != 0)
            {
                
                    switch (dec % 16)
                    {
                        case 10:
                            result.Add("A");
                            break;
                        case 11:
                            result.Add("B");
                            break;
                        case 12:
                            result.Add("C");
                            break;
                        case 13:
                            result.Add("D");
                            break;
                        case 14:
                            result.Add("E");
                            break;
                        case 15:
                            result.Add("F");
                            break;
                        default:
                            result.Add($"{dec % 16}");
                            break;
                    }
                
               
            }
        }

        public void FromPexaToDecimal()
        {
            dec = 0;

            for (int i = 0; i < result.Count; i++)
            {
                switch (result[i])
                {
                    case "A":
                        dec += 10 * (int)Math.Pow(16, i);
                        break;
                    case "B":
                        dec += 11 * (int)Math.Pow(16, i);
                        break;
                    case "C":
                        dec += 12 * (int)Math.Pow(16, i);
                        break;
                    case "D":
                        dec += 13 * (int)Math.Pow(16, i);
                        break;
                    case "E":
                        dec += 14 * (int)Math.Pow(16, i);
                        break;
                    case "F":
                        dec += 15 * (int)Math.Pow(16, i);
                        break;
                    default:
                        dec += int.Parse(result[i]) * (int)Math.Pow(16, i);
                        break;
                }
                
            }
        }



        public void Print()
        {
            for (int i = result.Count - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
        }
        public void PrintDecimal()
        {

            Console.WriteLine(dec);

        }
    }
}
