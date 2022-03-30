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
        public string text = "nothing";
        public void InputType()
        {
            //Section for user to choose form of input

            bool choiceSelected = false;

            Console.WriteLine("please select one of the following two options ('1' for option 1 and '2' for option 2) \n 1. Do you want to enter the text via the keyboard? \n 2.Do you want to read in the text from a file? \n");
            String userChoice = Console.ReadLine();
            while (choiceSelected == false) 
            {
                if (userChoice == "1")
                {
                    choiceSelected = true;
                    ManualTextInput();
                }
                if (userChoice == "2")
                {
                    choiceSelected = true;
                    FileTextInput();
                }
                else
                {
                    Console.WriteLine("invalid input, please enter '1' for option one or '2' for option 2");
                    userChoice = Console.ReadLine();
                }
            }

        }

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard and enters to a text file for analysis stage

        public string ManualTextInput()
        {            
            
            //array to hold and output all user inputs
            string[] fullInput = new string[99];

            //notifies the user of the txt files creation and location incase they wish to deleate after operation
            text = @"C:\Users\adamr\Documents\userTextInput.txt";
            Console.WriteLine("A new text file will be created in your c: drive that holds the file and text file for the inputed data to be stored in");

            //loop for the user to enter multiple text inputs
            Console.WriteLine("please enter the text you want to input ending each sentence with a astrisk, to end this process enter 'end'");
            for (int x = 0; x < 99; x =+ 1 )
            {
                string userInput = Console.ReadLine();
                //method to end text input loop
                if (userInput == "end")
                {
                    x = 99;
                }
                else if (userInput == null)
                {
                    userInput = ".";
                }
                fullInput [x] = userInput;                
            }
            System.IO.File.WriteAllLines(@"C:\Users\adamr\Documents\MyTest.txt", fullInput);
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string FileTextInput()
        {

            //input to chose a file by entering the file path/adress
            Console.WriteLine("Please enter the file path/adress: ");
            text = Console.ReadLine();

            //loop to confurm the users choice or handle invalid inputs
            bool endLoop = false;
            while (endLoop == false)
            {
                Console.WriteLine($"inputed adress = {text}, enter 'yes' to confirm and 'no' to reselect");
                string userConfirm = Console.ReadLine();
                //ends loop on confirmation
                if (userConfirm == "yes")
                {
                    endLoop = true;
                }
                //allows the user to chandge the file path 
                else if (userConfirm == "no")
                {
                    Console.WriteLine("Please enter the file path/adress: ");
                    text = Console.ReadLine();
                }
                //counter for invalid inputs
                else
                {
                    Console.WriteLine($"invalid input, please enter 'yes' to confirm the desired adress is {text} or 'no' to change your choice");
                    userConfirm = Console.ReadLine();
                }
            }
            return text;
        }
    }
}
