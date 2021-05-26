using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystem
{
    public class OctalSystem: ISystem
    {
        int dec;

        List<int> result = new List<int> { };

        public OctalSystem(int number)
        {
            dec = number;
        }

        public OctalSystem(List<int> number)
        {
            result = number;
        }

        public void FromDecimalToOctal()
        {
            while (dec >= 8)
            {
                result.Add(dec % 8);
                dec = (dec - dec % 8) / 8;
            }
            if (dec != 0)
            {
                result.Add(dec);
            }
        }

        public void FromOctalToDecimal()
        {
            dec = 0;

            for (int i = 0; i < result.Count; i++)
            {
                dec += result[i] * (int)Math.Pow(8, i);
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
