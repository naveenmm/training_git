using System;

namespace matrix90
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Rotate 90°");
            Console.WriteLine("Enter rows:");
            string i = Console.ReadLine();
            Console.WriteLine("Enter columns:");
            string j = Console.ReadLine();
            int row, column;
            row = Convert.ToInt32(i);
            column = Convert.ToInt32(j);
            int[,] arr = new int[10, 10];
            Console.WriteLine("Enter the elements::");
            int m, n;
            for (m = 0; m < row; m++)
            {
                for (n = 0; n < column; n++)
                {
                    arr[m, n] = Convert.ToInt16(Console.ReadLine());
                }
            }

            for (m = 0; m < row; m++)
            {
                for (n = 0; n < column; n++)
                {
                    Console.Write(" " + arr[m, n]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (n = column - 1; n >= 0; n--)
            {
                for (m = 0; m < row; m++)
                {
                    Console.Write(" " + arr[m, n]);
                }
                Console.WriteLine();
            }

        }
    }
}
