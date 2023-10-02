namespace Lesson5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите длинное предложение: ");
            string inputText = Console.ReadLine();

            string[] words = SplitText(inputText);

            Console.WriteLine("\nСлова в предложении:\n");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.Write("\nВведите длинное предложение: ");
            string inputPhrase = Console.ReadLine();

            string reversedPhrase = ReverseWords(inputPhrase);

            Console.WriteLine("\nПереставленные слова:\n");
            Console.WriteLine(reversedPhrase);
        }

        static string[] SplitText(string text)
        {
            return text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }

        static string ReverseWords(string inputPhrase)
        {
            string[] words = SplitText(inputPhrase); 
            Array.Reverse(words); 

            return string.Join(" ", words);
        }
    }
}

