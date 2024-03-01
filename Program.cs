/*
 *    Author:     Christopher Lopez
 *    Course:     COMP-003A
 *    Purpose:    Code for Assignment7
 */
namespace COMP003A.Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array - CharacterCounter Section
            Console.WriteLine("***************************************************");
            Console.WriteLine("          Array - CharacterCounter Section         ");
            Console.WriteLine("***************************************************");
            Console.Write("Enter a single letter: ");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine();

            int count = CharacterCounter(letter, word);

            Console.WriteLine($"There are '{count}' letter '{letter}' in the word {word}.");

            SectionSeparator();

            // Array - IsPalindrome Section
            Console.WriteLine("***************************************************");
            Console.WriteLine("           Array - IsPalindrome Section            ");
            Console.WriteLine("***************************************************");
            Console.Write("please enter a word to check if it's a palindrome: ");
            string palindromeWord = Console.ReadLine();
            Console.WriteLine();

            bool isPalindrome = IsPalindrome(palindromeWord);

            if (isPalindrome)
            {
                Console.WriteLine($"The word '{palindromeWord}' is a palindrome.(you are the father!)");
            }
            else
            {
                Console.WriteLine($"The word '{palindromeWord}' is not a palindrome.(you are not the father!)");
            }

            SectionSeparator();

            // List - Add Section
            Console.WriteLine("***************************************************");
            Console.WriteLine("           List - Add Section                      ");
            Console.WriteLine("***************************************************");
            List<string> names = new List<string>();
            char userInput = default;

            do
            {
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();
                names.Add(name);

                Console.WriteLine("Press any key to add more or (e) to exit.");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (userInput != 'e');

            SectionSeparator();

            // List - Traversal Section
            Console.WriteLine("***************************************************");
            Console.WriteLine("           List - Traversal Section                ");
            Console.WriteLine("***************************************************");
            TraverseList(names);

            SectionSeparator();

            // List - Reverse Traversal Section
            Console.WriteLine("***************************************************");
            Console.WriteLine("           List - Reverse Traversal Section        ");
            Console.WriteLine("***************************************************");
            TraverseListReverse(names);
        }

        static void SectionSeparator(string sectionName = "")
        {
            Console.WriteLine(" ");
            if (!string.IsNullOrEmpty(sectionName))
            {
                Console.WriteLine(sectionName);
            }
            Console.WriteLine(" ");
        }

        static int CharacterCounter(char characterInput, string word)
        {
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();

            int count = 0;
            foreach (char c in word)
            {
                if (c == characterInput)
                {
                    count++;
                }
            }

            return count;
        }

        static bool IsPalindrome(string word)
        {
            string reversedWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            return string.Equals(word.ToLower(), reversedWord.ToLower());
        }

        static void TraverseList(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void TraverseListReverse(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}