using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_to_decimal_and_hex_to_decimal
{
    class Program
    {
        static void bintodec(string userInput)
        {
            int decimalValue = 0;
            int num;
            string[] conversionTable = new string[] { "128", "64", "32", "16", "8", "4", "2", "1" };
            string[] binEntry = new string[8];
            binEntry = userInput.Split(',');

            for (int i = 0; i < binEntry.Length; i++)
            {
                if (binEntry[i] == "1")
                {
                    num = Convert.ToInt32(conversionTable[i]);
                    decimalValue = decimalValue + num;                   
                }
            }
            Console.WriteLine("your decimal value is {0}", decimalValue);

        }
        static void dectobin(string userInput)
        {
            string[] binValue = new string[8];
            int input = Convert.ToInt32(userInput);
            if (input - 128 > 0 || input - 128 == 0)
            {
                binValue[0] = "1";
                input = input - 128;
            }
            else
            {
                binValue[0] = "0";
            }

            if (input - 64 > 0 || input - 64 == 0)
            {
                binValue[1] = "1";
                input = input - 64;
            }
            else
            {
                binValue[1] = "0";
            }

            if (input - 32 > 0 || input - 32 == 0)
            {
                binValue[2] = "1";
                input = input - 32;
            }
            else
            {
                binValue[2] = "0";
            }

            if (input - 16 > 0 || input - 16 == 0)
            {
                binValue[3] = "1";
                input = input - 16;
            }
            else
            {
                binValue[3] = "0";
            }

            if (input - 8 > 0 || input - 8 == 0)
            {
                binValue[4] = "1";
                input = input - 8;
            }
            else
            {
                binValue[4] = "0";
            }

            if (input - 4 > 0 || input - 4 == 0)
            {
                binValue[5] = "1";
                input = input - 4;
            }
            else
            {
                binValue[5] = "0";
            }

            if (input - 2 > 0 || input - 2 == 0)
            {
                binValue[6] = "1";
                input = input - 2;
            }
            else
            {
                binValue[6] = "0";
            }

            if (input - 1 == 0)
            {
                binValue[7] = "1";
                input = input - 1;
            }
            else
            {
                binValue[7] = "0";
            }

            for (int i = 0; i < binValue.Length; i++)
            {
                Console.Write(binValue[i]);
            }
        }
  
        static void Main(string[] args)
        {
            int useroption;
            string userInput = "";

            Console.WriteLine("select an option based on number: 1- binary to decimal 2- decimal to binary ");
            useroption = Convert.ToInt32(Console.ReadLine());

            if (useroption == 1)
            {
                Console.WriteLine("enter the binary number that you would like to convert with each digit seperated by a comma");
                userInput = Console.ReadLine();
                bintodec(userInput);                
            }
            else if (useroption == 2)
            {
                Console.WriteLine("enter the decimal value that you would like to convert to binary");
                userInput = Console.ReadLine();
                dectobin(userInput);
            }         
            

            Console.Read();
        }
    }
}
