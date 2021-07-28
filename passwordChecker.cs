// Using control flow to imitate a password checker program. The program would assist a user in creating
// a password that would be difficult to crack. 

using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "1234567890";
            string specialChars = "!£$%^&*?@><#";

            Console.WriteLine("Please enter a password");
            string userPassword = Console.ReadLine();

            int score = 0;
            Console.WriteLine(score);

            if (userPassword.Length >= minLength)
            {
                score++;
            }
            Console.WriteLine(score);

            // custom tool given by codecademy to check for characters "Tools.Contains"

            // using custom tool to check for uppercase characters

            if (Tools.Contains(userPassword, uppercase))
            {
                score++;
            }
            Console.WriteLine(score);

            // using custom tool to check for lowercase characters

            if (Tools.Contains(userPassword, lowercase))
            {
                score++;
            }
            Console.WriteLine(score);

            // using custom tool to check for digits

            if (Tools.Contains(userPassword, digits))
            {
                score++;
            }
            Console.WriteLine(score);

            // using custom tool to check for special characters

            if (Tools.Contains(userPassword, specialChars))
            {
                score++;
            }
            Console.WriteLine(score);

            // feedback to the user about their password strength

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("your password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("your password is strong");
                    break;
                case 2:
                    Console.WriteLine("your password is okay");
                    break;
                case 1:
                    Console.WriteLine("your password is weak");
                    break;
                default:
                    Console.WriteLine("please try again");
                    break;
            }

        }
    }
}

