using System;
namespace Programa
{
    class fibonacci
    {
        public static void Main(String[] args)
        {
            int prim = 1;
            int segun = 0;
            int terc = 0;
            Console.WriteLine("Hasta que numero quieres la serie de fibonacci");
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(segun);
            }

            else if (n == 1)
            {
                Console.WriteLine(segun);
                Console.WriteLine(prim);
            }
            else
            {
                Console.WriteLine(segun);
                Console.WriteLine(prim);
                while (segun <= n)
                {
                    segun = terc + prim;
                    if (segun < n)
                    {
                        Console.WriteLine(segun);
                        terc = prim;
                        prim = segun;
                    }

                }



            }


            Console.ReadKey();


        }
    }
}