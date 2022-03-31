using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            int scount = 0;
            //2. Number of vowels
            int vcount = 0;
            //3. Number of consonants
            int ccount = 0;
            //4. Number of upper case letters
            int ucount = 0;
            //5. Number of lower case letters
            int lcount = 0;
            //6. frequency of characters
            int charcount = 0;

            foreach (char c in input)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                        vcount++;
                    else if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                        vcount++;


                    else ccount++;
                }
                else others++;


            }



            int scount = 0;
            foreach (char item in sentence)
            {
                if (item == '.')
                {
                    scount++;
                }
            }


            foreach (char c in input)
            {
                if (Char.IsLower(c))
                {
                    Lcount++;
                }
                else if (char.IsUpper(c))
                {
                    Ucount++;
                }

            }

            while (input.Length > 0)
            {
                int countofchar = 0;
                Console.Write($"{input[0]}=");
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[0] == input[i])
                    {
                        countofchar++;
                    }
                }


                return values;
                List<int> values = new List<int>();
                //Initialise all the values in the list to '0'
                for (int i = 0; i < 5; i++)
                {
                    values.Add(0);
                }
                values[0] = lcount;
                values[1] = ucount;
                values[2] = scount;
                values[3] = vcount;
                values[4] = ccount;
                values[5] = countofchar;
                values[6] = others;

                return values;
            }
        }
    }
}
