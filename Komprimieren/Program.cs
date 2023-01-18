using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Komprimieren
{
    
    internal class Program
    {

        static string[] AddString(string[] array, string zeichen)
        {
            var array3 = new string[array.Length +1];

            for (int i = 0; i < array.Length; i++)
            {
                array3[i] = array[i];

            }

            array3[array3.Length - 1] = zeichen;
            return array3;

        }

        static void Main(string[] args)
        {
            var array = new string[] { "A", "A", "A", "A", "2", "2", "7", "7", "7", "7", "7", "7", "7", "7", "O", "P", "P", "P", "P", "P", "9", "9", "9" };
            var array2 = new string[0];

            string LetztesZeichen = "";
            int Anzahl = 0;
            

            for (int i = 0; i < array.Length; i++)
            {
                
                string letter = array[i];

                if(letter == LetztesZeichen)
                {
                    Anzahl++;
                }

                else
                {
                    if (Anzahl > 4)
                    {
                        array2 = AddString(array2, "$");
                       
                        array2 = AddString(array2, Anzahl.ToString());
                        
                        array2 = AddString(array2, LetztesZeichen);
                        

                    }

                    else
                    {
                        for (int j = 0; j < Anzahl; j++)
                        {

                            array2 = AddString(array2, LetztesZeichen);
                            
                        }

                       
                    }
                        LetztesZeichen = array[i];
                        Anzahl = 1;
                    
                }

                if(array.Length == i + 1)
                {
                    for (int j = 0; j < Anzahl; j++)
                    {

                        array2 = AddString(array2, LetztesZeichen);
                        
                    }
                }

            }

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i]);
                
            }

            // if any var in string is used more than 4 times

            // save what var it was (save as LetztesZeichen)
            // count how often the var is used (save as Anzahl)
            // remove those vars from the string
            // add "$", "y", "x" to the string

            // repeat for any other variables that appear more than 4 times


            Console.ReadKey();
        }
    }
}
