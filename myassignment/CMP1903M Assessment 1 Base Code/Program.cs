//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Report Output_user = new Report();
            Input input1 = new Input();
            string inputchoice = inputchoice.ChoiceofMethod();
            string text = "";
            inputchoice.contains("m");
            if (inputchoice.ToLower().Equals("m"))
            {
                text = input1.manualTextInput();
            }
            else if (inputchoice.ToLower().Equals("m"))
            {
                text = input1.filetextput("")
            }
            else
            {
                console.WriteLine("invalid");
            }
            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Analyse analyse1 = new Analyse();
            var analyse = analyse1.analyseText(text);
            Output_user.userOutput(analyse);

            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}
