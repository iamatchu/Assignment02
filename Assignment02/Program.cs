using System;

namespace Assignment02
{
    /* This class handles the logic of application by calculating the volume of the rectangle based up on the user
     * input -length, width and height.
     */
    class Program
    {
        /* This method returns the integer and validates the user input. If input is not selected from the menu,
           it will ask the user to reneter the input from the menu. 
         */
        public static int RectangleMenuSelection()
        {
            string givenUserInput = "";
            bool validRectMenuSelect = false;

            while (validRectMenuSelect == false)
            {
                //This method provides the list of menu options to the user.
                menuMethod();

                Console.WriteLine("Please select an option, by entering a number:\n");
                givenUserInput = Console.ReadLine();

                if (givenUserInput != "1" &&
                    givenUserInput != "2" &&
                    givenUserInput != "3" &&
                    givenUserInput != "4" &&
                    givenUserInput != "5" &&
                    givenUserInput != "6" &&
                    givenUserInput != "7" &&
                    givenUserInput != "8")
                {
                    Console.WriteLine("That's not a valid entered menu option, could you please try again:\n");
                }
                else
                {
                    validRectMenuSelect = true;
                }
            }
            Console.WriteLine();
            return int.Parse(givenUserInput);
        }

        /*  This method contains the list of menu and it is a void method.
         */
        private static void menuMethod()
        {
            Console.WriteLine("1 = Get Rectangle length");
            Console.WriteLine("2 = Change Rectangle length");
            Console.WriteLine("3 = Get Rectangle width");
            Console.WriteLine("4 = Change Rectangle width");
            Console.WriteLine("5 = Get Rectangle height");
            Console.WriteLine("6 = change Rectangle height");
            Console.WriteLine("7 = Get Rectangle Volume");
            Console.WriteLine("8 = Exit\n");
        }

        /*
          This method will update the user entered number and returns the integer.
         */
        public static int ValidateGivenInput(string selectedNumber)
        {
            int updatedNumber = 1;
            bool isValid = false;
            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {selectedNumber}:");
                string givenUserInput = Console.ReadLine();
                Console.WriteLine();

                // Parsing the user input to the boolean
                bool result = int.TryParse(givenUserInput, out updatedNumber);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input please, please try again.\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"Your {selectedNumber} has been changed to: {updatedNumber}.\n");
                }
            }
            return updatedNumber;
        }
        /*
         * Static main method which will load first when the application started. It calls the RectangleMenuSelection()
         * and returns the appropriate response based up on the menu selected by the user.
         */
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            bool validRectSelect = false;
            string rectSelection;
            int selectedValue;

            while (validRectSelect == false)
            {
                Console.WriteLine("Please choose number 1 to begin:");
                rectSelection = Console.ReadLine();
                Console.WriteLine();
                if (rectSelection != "1")
                {
                    Console.WriteLine("That's not a valid selectedValue, please try again.\n");
                }

                else if (int.Parse(rectSelection) == 1)
                {
                    RectMethod(out r, out validRectSelect);
                }
            }
            selectedValue = RectangleMenuSelection();
            // If the selected option is valid, this while loop will be executed.
            while (selectedValue != 8)
            {
                int result;
                // Switch case to handle the selected value based up on the menus selected. It is used instead of
                // multiple if conditions.
                switch (selectedValue)
                {
                    case 1:
                        Console.WriteLine($"The length is: {r.Getlength()}\n");
                        break;
                    case 2:
                        result = ValidateGivenInput("length");
                        r.Setlength(result);
                        break;
                    case 3:
                        Console.WriteLine($"The width is: {r.Getwidth()}\n");
                        break;
                    case 4:
                        result = ValidateGivenInput("width");
                        r.Setwidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"The height is: {r.GetHeight()}\n");
                        break;
                    case 6:
                        result = ValidateGivenInput("height");
                        r.SetHeight(result);
                        break;
                    case 7:
                        Console.WriteLine($"The volume for the given rectangle is: {r.GetRectangleVolume()}\n");
                        break;
                    default:
                        break;
                }
                selectedValue = RectangleMenuSelection();
            }
        }

        private static void RectMethod(out Rectangle r, out bool validRectSelect)
        {
            RectangleMenuSelection();
            int length;
            int width;
            int height;
            validRectSelect = true;
            length = ValidateGivenInput("length");
            width = ValidateGivenInput("width");
            height = ValidateGivenInput("height");

            Console.WriteLine($"Your given custom numbers are {length} and {width} and {height}.\n");
            Rectangle customRect = new Rectangle(length, width, height);
            r = customRect;
        }
    }
}


