using System;

namespace Triangle_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("1.Enter triangle dimensions");
                Console.WriteLine("2.Exit");
                String menu = Console.ReadLine();
                int choice;
                bool correctInput = Int32.TryParse(menu, out choice);
                if (correctInput == true)
                {

                    switch (choice)
                    {
                        case 1:
                            int a, b, c;
                            Console.WriteLine("Enter three integers: ");
                            Console.WriteLine("Enter the first integer: ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the second integer: ");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the third integer: ");
                            c = int.Parse(Console.ReadLine());
                            string result = TriangleSolver.Analyze(a, b, c);
                            Console.WriteLine(result);
                            break;
                        case 2:
                            System.Environment.Exit(0);
                            break;
                        default:
                            break;

                    }
                }

            }
        }
    }
}
