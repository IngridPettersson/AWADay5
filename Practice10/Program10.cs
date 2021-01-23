// skapa en array med två namn
// Lägg till funktionalitet för att kunna lägga till ett namn i names. Namnet ska läggas sist i names.
// Lägg till funktionalitet för att ta bort ett namn från names. Användaren ska ange det namn som
// ska tas bort.
// Lägg till funktionalitet för att sortera namnen i names.
// Testa med olika metoder för att sortera namnen. T.ex bubble sort och selection sort.


using System;

namespace Practice10
{
    class Program10
    {
        static void Main(string[] args)
        {
            string[] names = new string[2] { "Adam", "Eva" };

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

            names = RemoveName(names, "Eva");
            PrintNames(names);




        }

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

        private static string[] RemoveName(string[] names, string name)
        {
            string[] temp = new string[names.Length - 1];


            for (int i = 0; i < names.Length; i++)
            {
                string removedName = name;
                int indexRemovedName;

                if (removedName == names[i])
                {
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
