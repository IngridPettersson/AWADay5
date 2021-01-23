using System;

namespace SortingAlgorithms
{
    class ProgramSorting
    {
        static char[] characters = new char[5] { 'b', 'e', 'a', 'c', 'd' };
        //static char[] sortedCharacters = new char[5];
        static void Main(string[] args)
        {
            SelectionSort();
        }

        private static void SelectionSort()
        {
            for (int i = 0; i < characters.Length - 1; i++)
            {
                int lvi = i;

                for (int j = i + 1; j < characters.Length; j++)
                {
                    if (characters[j] < characters[lvi])
                    {
                        // Min lösning men då behöver alla värden byta plats "under the hoods", även om a tex står sist och 
                        // man innan det måste byta till tex c och sedan b.

                        //char savedChar = characters[j];
                        //characters[j] = characters[lvi];
                        //characters[lvi] = savedChar;

                        lvi = j;
                    }
                }

                if (lvi != i)
                {
                    char savedChar = characters[i];
                    characters[i] = characters[lvi];
                    characters[lvi] = savedChar;
                }
            }

            foreach (char character in characters)
            {
                Console.WriteLine(character);
            }

            //foreach (char character in sortedCharacters)
            //{
            //    Console.WriteLine(character);
            //}
        }
    }
}
