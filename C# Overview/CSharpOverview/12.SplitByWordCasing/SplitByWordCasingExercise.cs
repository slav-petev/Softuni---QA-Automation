using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SplitByWordCasing
{
    class SplitByWordCasingExercise
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(
                new[]
                {
                    ' ', ':', ',', ';',
                    '.', '!', '(', ')',
                    '\'', '"', '\\', '/',
                    '[', ']'
                }, StringSplitOptions.RemoveEmptyEntries);

            PrintLowercaseWords(GetLowercaseWords(words));
            PrintMixedcaseWords(GetMixedcaseWords(words));
            PrintUppercaseWords(GetUppercaseWords(words));
        }

        private static string[] GetLowercaseWords(string[] words)
        {
            List<string> lowercaseWords = new List<string>();

            foreach (var word in words)
            {
                if (IsLowercaseWord(word))
                    lowercaseWords.Add(word);
            }

            return lowercaseWords.ToArray();
        }

        private static string[] GetMixedcaseWords(string[] words)
        {
            List<string> mixedcaseWords = new List<string>();

            foreach (var word in words)
            {
                if (IsMixedcaseWord(word))
                    mixedcaseWords.Add(word);
            }

            return mixedcaseWords.ToArray();
        }

        private static string[] GetUppercaseWords(string[] words)
        {
            List<string> uppercaseWords = new List<string>();

            foreach (var word in words)
            {
                if (IsUppercaseWord(word))
                    uppercaseWords.Add(word);
            }

            return uppercaseWords.ToArray();
        }

        private static bool IsUppercaseWord(string word)
        {
            foreach (var symbol in word)
            {
                if (char.IsLower(symbol) || char.IsDigit(symbol) || !char.IsLetter(symbol))
                    return false;
            }

            return true;
        }

        private static bool IsLowercaseWord(string word)
        {
            foreach (var symbol in word)
            {
                if (char.IsUpper(symbol) || char.IsDigit(symbol) || !char.IsLetter(symbol))
                    return false;
            }

            return true;
        }

        private static bool IsMixedcaseWord(string word)
        {
            return !IsUppercaseWord(word) && !IsLowercaseWord(word);
        }

        private static void PrintLowercaseWords(IEnumerable<string> lowercaseWords)
        {
            Console.WriteLine("Lower-case: {0}",
                JoinWords(lowercaseWords));
        }

        private static void PrintMixedcaseWords(IEnumerable<string> mixedcaseWords)
        {
            Console.WriteLine("Mixed-case: {0}",
                JoinWords(mixedcaseWords));
        }

        private static void PrintUppercaseWords(IEnumerable<string> uppercaseWords)
        {
            Console.WriteLine("Upper-case: {0}",
                JoinWords(uppercaseWords));
        }

        private static string JoinWords(IEnumerable<string> words)
        {
            return string.Join(", ", words);
        }
    }
}
