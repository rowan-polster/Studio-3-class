using System;

namespace Studio_3_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is a practice sentence!!!!";

            Console.WriteLine("Please enter a sentence for character counting:\n");
            string inputSentence = Console.ReadLine();

            var charactersInString = new CharacterCounting();

            charactersInString.FindChars(inputSentence);
        }
    }
}
