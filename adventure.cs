/* A program that models a text-based choose your own adventure game, to build a better understanding of control flow. */

using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

            Console.Write("Type YES or NO: ");
            string noiseChoicePrecursor = Console.ReadLine();
            string noiseChoice = noiseChoicePrecursor.ToUpper();
            if (noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room! THE END.");
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
            }

            Console.Write("Type OPEN or KNOCK: ");
            string doorChoicePrecursor = Console.ReadLine();
            string doorChoice = doorChoicePrecursor.ToUpper();

            if (doorChoice == "KNOCK")
            {
                Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle:\" \"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                Console.Write("Type your answer: ");
                string riddleAnswerPrecursor = Console.ReadLine();
                string riddleAnswer = riddleAnswerPrecursor.ToUpper();
                if (riddleAnswer == "NOTHING")
                {
                    Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door. THE END.");
                }
                else
                {
                    Console.WriteLine("You answered incorrectly. The door doesn/'t open. THE END");
                }
            }
            else if (doorChoice == "OPEN")
            {
                Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                Console.Write("Enter a number (1-3):");
                string keyChoicePrecursor = Console.ReadLine();
                string keyChoice = keyChoicePrecursor.ToUpper();
                switch (keyChoice)
                {
                    case "1":
                        Console.WriteLine("You choose the first key. Lucky choice! The door open and NOTHING is there. Strange... THE END.");
                        break;
                    case "2":
                        Console.WriteLine("You choose the second key. The door doesn/'t open. THE END.");
                        break;
                    case "3":
                        Console.WriteLine("You chose the third key. The door doesn't open. THE END.");
                        break;
                }

            }
        }
    }
}
