using System;

namespace AWADay5Practice1
{
    class ProgramGitTrial
    {
        static void Main(string[] args)
        {
            /*DemoParams(new int[] { 1, 2, 3 }); *///fast utan params nu för det använder man så sällan tydligen.
            int i = 10;
            Console.WriteLine(i--); // 10 skrivs ut innan beräkningen utförs (just för att det är en -- operator) och EFTER det tar den i - 1.
            Console.WriteLine(i);
            Console.WriteLine(i - 1); // 8, för här görs beräkningen INNAN värdet skrivs ut
        }

        //private static void DemoParams(int[] arrayOfInts)
        //{
            
        //}

    }
}
