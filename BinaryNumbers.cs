/* 
Name:         Roger Silva Santos Aguiar
Function:     It implements the sum of two numbers and returns the sum in binary
Initial date: January 27, 2021 
Last update:  January 27, 2021 
*/

using System;
using System.Collections.Generic;

namespace BinaryNumbers
{
    public class BinaryNumber 
    {
        public static string AddBinary(int a, int b)
        {
            List<string> binary = new List<string>();
            string outputResult = "";
            int result = a + b;            
            
            while(result / 2 != 1)
            {
                binary.Add(Convert.ToString(result % 2));
                result = result / 2;
            }
            binary.Add(Convert.ToString(result % 2));
            binary.Add(Convert.ToString(result / 2));             
            binary.Reverse();

            foreach(var bit in binary)
            {                
                outputResult += bit;
            }

            return outputResult;        
        }
    }
}