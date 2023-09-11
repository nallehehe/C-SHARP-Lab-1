using System.Diagnostics.Tracing;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();

            Console.WriteLine("Welcome to the code simulator.");
            Console.WriteLine("******************************");
            Console.WriteLine("Type in a string for me: ");

            string stringRem = Console.ReadLine();

            for (int i = 0; i < stringRem.Length; i++)
            {
                if (char.IsDigit(stringRem[i]))
                {
                    int firstIndex = i;
                    int secondIndex = 0;

                    for (int j = firstIndex + 1; j < stringRem.Length; j++)
                    {
                        if (char.IsDigit(stringRem[j]))
                        {
                            if (stringRem[j] == stringRem[i])
                            {
                                secondIndex = j;
                                myList.Add(stringRem.Substring(firstIndex, secondIndex - firstIndex + 1));
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            foreach (string entry in myList)
            {
                Console.ResetColor();
                int startIndex = stringRem.IndexOf(entry);
                int endIndex = startIndex + entry.Length;

                for (int i = 0; i < stringRem.Length; i++)
                {
                    if (i == startIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (i == endIndex)
                    {
                        Console.ResetColor();
                    }

                    Console.Write(stringRem[i]);
                }
                Console.WriteLine();
                Console.ResetColor();

            }

        }
    }
}