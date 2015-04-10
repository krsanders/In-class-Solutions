using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnoyingTextifier1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AnNoYiNgTeXtIfYeR("gobbledygook"));
            Console.ReadKey();
        }
            static string AnNoYiNgTeXtIfYeR(string notAnnoyingString)
        {
            //input: "hello"
            //output: "hELlO"
            //declare a return string for output
            string returnString = string.Empty;

            for (int i = 0; i < notAnnoyingString.Length; i++)
            {
                //get a letter to examine
                string letter = notAnnoyingString[i].ToString();


                //looping over every letter
                //get a letter to examine
                //see if the position of the letter is odd or even

                if (i % 2 == 0)
                {
                    //if even (or odd, whatever the preference is) make it CaPiTal)
                    returnString = returnString + letter.ToUpper();
                }
                else
                {
                    returnString += letter.ToLower();
                }
            }
            return returnString;
         //   for (int i = 0; i < notAnnoyingString.Length; i++)
         //   {
                
         //   }
            
        
        }
    }
}
