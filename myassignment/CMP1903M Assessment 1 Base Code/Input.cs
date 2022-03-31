using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string choice()
        {
            console.Writeline("please enter your the method you want")
            console.Writeline("press f, for file input")
            console.writeline("press m, for manual input")
            console.write("")
            text = console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string manualTextInput(string fileName)
        {
            Console.WriteLine(" please enter your manual text")
            Console.Write("");
            text = console.ReadLine();
            return text;
        }
        public string fileText(string filename)
        {
            console.WriteLine("Hi")
            return text;
        }

    }
}
