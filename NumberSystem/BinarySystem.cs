using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NumberSystem
{
    public class BinarySystem:ISystem
    {
        int dec;

        List<int> result = new List<int> { };
        public BinarySystem(int number)
        {
            dec = number;
        }

        public BinarySystem(List<int> result)
        {
            this.result = result;
        }

        public void FromDecimalToBinary()
        {
            while (dec>=2)
            {
                result.Add(dec % 2);
                dec = (dec - dec % 2) / 2;
            }
            if (dec != 0)
            {
                result.Add(dec);
            }
            
        }

        public void FromBinaryToDecimal()
        {
            
            dec = 0;
            
            for (int i = 0; i < result.Count; i++)
            {
                dec+= result[i]*(int)Math.Pow(2, i);
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
