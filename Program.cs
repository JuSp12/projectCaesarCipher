using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("What is the secret message?");
            string secretMessage = Console.ReadLine();

            char[] secretMessageArray = secretMessage.ToCharArray();
            

            char[] encryptedMessage = new char[secretMessage.Length];
            //string secretMessage = String.Join("", secretMessageArray);

            

            for (int i = 0; i < secretMessage.Length; i++)
            {
               char eachChar = secretMessage[i];
               int index = Array.IndexOf(alphabet, eachChar);
                int letterPosition = (index + 3)%26;
                char newLetter = alphabet[letterPosition];
                encryptedMessage[i] = newLetter;

            }

            string secretMessageNew = String.Join("", encryptedMessage);
            Console.WriteLine($"Your new code message is: {secretMessageNew}");

        }
    }
}