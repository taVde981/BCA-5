using System;

namespace Array_2d
{
    class Execution
    {
        public static void Main(string[] args)
        {
            int ch;
            Programs programs = new Programs();
            Console.WriteLine("Enter Choice");
            Console.WriteLine("1. Matrix Addition");
            Console.WriteLine("2. Matrix Multiplication");
            Console.WriteLine("3. Transpose of a Matrix");
            Console.WriteLine("4. Sum of All Elements");
            Console.WriteLine("5. Print Diagonal Elements");
            Console.WriteLine("6. Print MAtrix in a spiral");
            Console.WriteLine("7. Search in 2D Array");
            Console.WriteLine("8. Rotate Matrix");
            Console.WriteLine("9. Maximum Element in Each Row");
            Console.WriteLine("10. Print Boundary Elements");


            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    programs.add2d();
                    break;
                case 2:
                    break;

            }
        }

        public class Programs
        {
            public void add2d()
            {
                int[,] arr1 = new int[2, 2];
                Console.WriteLine("Enter array elements");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                int[,] arr2 = new int[2, 2];
                Console.WriteLine("Enter array elements");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Smm of both arrays");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write((arr1[i, j] + arr2[i, j]) + " ");
                    }
                    Console.WriteLine();
                }
            }

            //*********************************************

            /*
            public object elements()
            {
                int[,] arr = new int[5,5];
                Console.WriteLine("Enter array elements");
                for (int i = 0; i < 5; i++)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        arr[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                return arr;
            }*/
            //---------------------------------------------

            public void display(int[,] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}