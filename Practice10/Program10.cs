// 1. skapa en array med två namn
// 2. Lägg till funktionalitet för att kunna lägga till ett namn i names. Namnet ska läggas sist i names.
// 3. Lägg till funktionalitet för att ta bort ett namn från names. Användaren ska ange det namn som
// ska tas bort.
// 4. Lägg till funktionalitet för att sortera namnen i names.
// 5. Testa med olika metoder för att sortera namnen. T.ex bubble sort och selection sort.


using System;

namespace Practice10
{
    class Program10
    {
        static void Main(string[] args)
        {
            string[] names = new string[2] { "Adam", "Eva" };
            string name;

            //names = AddName(names, "Strumpan");
            //PrintNames(names);

            names = AddNameDifferently(names, "Strumpan");
            PrintNames(names);

            Console.ReadLine();
            Console.Clear();

            names = AddNameDifferently(names, "Madame");
            PrintNames(names);

            Console.ReadLine();
            Console.Clear();

            names = RemoveLastName(names, names[names.Length - 1]);
            PrintNames(names);

            Console.ReadLine();
            Console.Clear();

            Console.Write("Enter name you want to remove: ");
            name = Console.ReadLine();
            names = RemoveName(names, name);
            PrintNames(names);
        }
        #region
        private static string[] AddNameDifferently(string[] names, string name)
        {
            string[] temp = new string[names.Length + 1];

            for (int i = 0; i < names.Length; i++)
            {
                temp[i] = names[i];
            }

            temp[names.Length] = name;

            return temp;
        }

        //private static string[] AddName(string[] names, string name)
        //{
        //    string[] temp = new string[3] { names[0], names[1], name };
        //    return temp;
        //}

        private static string[] RemoveLastName(string[] names, string name)
        {
            string[] temp = new string[names.Length - 1];

            for (int i = 0; i < names.Length - 1; i++)
            {
                temp[i] = names[i];
            }
            return temp;
        }
        #endregion

        private static string[] RemoveName(string[] names, string name)
        {
            string[] temp = new string[names.Length - 1];


            for (int i = 0; i < names.Length; i++)
            {
                int indexRemovedName;
                string removedName;
                if (names[i] == name)
                {
                    removedName = name;
                    indexRemovedName = i;
                    string lastName = names[names.Length - 1];
                    temp[names.Length - 1] = removedName;

                }
            }

            for (int i = 0; i < names.Length - 1; i++)
            {
                temp[i] = names[i];

            }

            return temp;
        }

        private static void PrintNames(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
