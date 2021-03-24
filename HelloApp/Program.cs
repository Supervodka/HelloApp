using System;

namespace HelloApp
{
    class Program
    {


        static int Sum(int hui, int hui2)
        {
            return hui + hui2;
        }


        static void Main(string[] args)
        {
            int a = 25;
            int b = 35;
            int c = 35;
            int d = 35;
            int e = 35;
            int f = 35;


            var ef = Sum(e, f);
            var result = Sum(a, Sum(b, Sum(c, Sum(d, ef))));

            var res = (a + (b + (c + d)));

                Console.WriteLine(result);

                Console.ReadKey();
           

        }

    }
}

