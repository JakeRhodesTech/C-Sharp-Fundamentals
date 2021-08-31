// A true/false quiz

using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = new string[]
            {
        "A Koala is a placental mammal.",
        "Koalas belong to the marsupial family.",
        "According to folk wisdom, koalas have really fresh breath.",
        "Some people say that Koalas carry Chlamydia.",
        "Koalas are native to South America."
            };

            bool[] answers = new bool[]
            {
        false,
        true,
        true,
        true,
        false
            };

            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning! The number of answers supplied does not match the number of questions.");
            }

            int askingIndex = 0;
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            foreach (bool response in responses)
            {
                Console.WriteLine(response);
            }

            int scoringIndex = 0;
            int score = 0;
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.Write(scoringIndex + 1 + ".");
                Console.WriteLine($"Input: {response} | Answer: {answer}");


                if (response == answer)
                {
                    score++;
                }

                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of {questions.Length} correct.");

        }
    }
}
