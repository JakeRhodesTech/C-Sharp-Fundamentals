/* 
By 6 a.m. on Sunday, your team’s project is nearly finished. The Object of Your Affection (the name’s a work in progress) is getting attention from other teams in the hackathon. With one day left, they’re getting desperate. To steal your project idea, your competitors have been reading your team’s emails!

As the team’s C# expert, you have been asked to write a cipher: a tool to encrypt text, making it unreadable to other teams. You’ve decided to implement the Caesar Cipher, which was used by the Roman Empire to encode military secrets.
*/

using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Enter your secret message: ");
            string input = Console.ReadLine();
            char[] secretMessage = input.ToCharArray();

            char[] encryptedMessage = new char[secretMessage.Length];

            Console.WriteLine(secretMessage.Length);
            Console.WriteLine(encryptedMessage.Length);

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int letterPosition = Array.IndexOf(alphabet, letter);
                int newLetterPosition = (letterPosition + 3) % 26;
                char letterEncoded = alphabet[newLetterPosition];
                encryptedMessage[i] = letterEncoded;
            }

            string encodedString = String.Join("", encryptedMessage);
            Console.WriteLine($"Your encoded message is: {encodedString}");

        }
    }
}
