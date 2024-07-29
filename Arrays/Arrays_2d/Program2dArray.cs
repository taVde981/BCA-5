using System;
using System.Net.Http.Headers;
using System.Xml;

namespace Array2d
{
    public class Execution
    {
        public static void Main(string[] args)
        {
            int ch;
            Programs programs = new Programs();
            Console.WriteLine("Enter Choice");
            Console.WriteLine("1. Input Numbers and Display them in a 2d Array");
            Console.WriteLine("2. Find sum of all elements in the Matrix");
            Console.WriteLine("3. Add and display sum of two Matrices");
            Console.WriteLine("4. Multiply and display product of two Matrices");
            Console.WriteLine("5. Subtract and display difference of two Matrices");
            Console.WriteLine("6. Square of each element of 2d array");
            Console.WriteLine("7. Transpose the Matrix");
            Console.WriteLine("8. Check if two Matrices are equal or not");
            Console.WriteLine("9. Check if Matrix is Identity matrix or not");
            Console.WriteLine("10. Check if Matrix is Diagonal matrix or not");
            Console.WriteLine("11. Check if Matrix is Scalar matrix or not");
            Console.WriteLine("12. Find sum of the Diagonal elements of the matrix");
            Console.WriteLine("13. Check if a matrix is Sparse or not");
            Console.WriteLine("14. Convert a Matrix in Lower Triangular form");
            Console.WriteLine("15. Convert a Matrix in Upper Triangular form");
            Console.WriteLine("16. Check if Matrix is Symmetric or not");
            Console.WriteLine("17. Find the Normal and Trace of a Matrix");
            Console.WriteLine("18. Find sum of Upper Triangle of Matrix");
            Console.WriteLine("19. Find sum of Lower Triangle of Matrix");
            Console.WriteLine("20. Find maximum element in the matrix");
            Console.WriteLine("21. Find minimum element in the matrix");
            Console.WriteLine("22. Find position of an element in the matrix");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch) {
                case 1:
                    programs.driver();
                    break;
                case 2:
                    programs.sum2d();
                    break;
                case 3:
                    programs.sum22d();
                    break;
                case 4:
                    programs.prod2d();
                    break;
                case 5:
                    programs.sub22d();
                    break;
                case 6:
                    programs.square2d();
                    break;
                case 7:
                    programs.transpose2d();
                    break;
                case 8:
                    programs.equal2d();
                    break;
                case 9:
                    programs.identity2d();
                    break;
                case 10:
                    programs.diagonal2d();
                    break;
                case 11:
                    programs.scalar2d();
                    break;
                case 12:
                    programs.sumDiagonal2d();
                    break;
                case 13:
                    programs.sparse2d();
                    break;
                case 14:
                    programs.lowerT2d();
                    break;
                case 15:
                    programs.upperT2d();
                    break;
                case 16:
                    programs.symmetric2d();
                    break;
                case 17:
                    programs.normTrace();
                    break;
                case 18:
                    programs.sumUpperT();
                    break;
                case 19:
                    programs.sumLowerT();
                    break;
                case 20:
                    programs.max2d();
                    break;
                case 21:
                    programs.min2d();
                    break;
                case 22:
                    programs.findElement();
                    break;
            }

        }
    }

    public class Programs
    {
        int[,] arr = new int[3,3];

        //***************21***************

        public void findElement()
        {
            getRef(arr);
            int i, j, temp;
            Console.WriteLine("Enter element you want index of");
            temp = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (arr[i, j] == temp)
                        Console.WriteLine("Index of " + arr[i, j] + " is (" + i + "," + j + ")");
                }
            }
        }


        //***************21***************

        public void min2d()
        {
            getRef(arr);
            int i, j, temp = arr[0,0];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (arr[i, j] < temp)
                        temp = arr[i, j];
                }
            }
            Console.WriteLine("Minimum element in the Matrix: " + temp);
        }

        //***************20***************

        public void max2d()
        {
            int i, j, temp = 0;
            getRef(arr);

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (arr[i, j] > temp)
                        temp = arr[i, j];
                }
            }
            Console.WriteLine("Maximum element in the Matrix: " + temp);
        }

        //***************19***************
        public void sumLowerT()
        {
            getRef(arr);
            int i, j, sum = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (j < i)
                        sum += arr[i, j];
                }
            }
            Console.WriteLine("Sum of Lower Triangle Elements: " + sum);
        }

        //***************18***************

        public void sumUpperT()
        {
            getRef(arr);
            int i, j, sum = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (j > i)
                        sum += arr[i, j];
                }
            }
            Console.WriteLine("Sum of Upper Triangle Elements: " + sum);
        }

        //***************17***************

        public void normTrace()
        {
            int i, j, sum = 0, diagonal_sum = 0;
            getRef(arr);
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    sum += arr[i, j];
                    if (i == j)
                        diagonal_sum += arr[i, j];
                }
            }
            display(arr);
            Console.WriteLine("Normal of the Matrix: " + (Math.Sqrt(sum)));
            Console.WriteLine("Trace of the Matrix: " + diagonal_sum);
        }

        //***************16***************

        public void symmetric2d()
        {
            int[,] arr1 = new int[3,3];
            getRef(arr);
            int i, j;
            bool flag = true;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr1[i, j] = arr[j, i];
                }
            }
            display(arr1);

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (arr1[i,j] != arr[i, j])
                    {
                        Console.WriteLine("Arr and Arr(t) are not Equal");
                        flag = false;
                        break;
                    }
                }
                if (flag == false)
                    break;
            }
            if (flag == true)
            {
                display(arr1);
                Console.WriteLine("Arr and Arr(t) are Equal");
            }
        }

        //***************15***************

        public void upperT2d()
        {
            getRef(arr);
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (j < i)
                    {
                        arr[i, j] = 0;
                    }
                }
            }
            display(arr);
        }

        //***************14***************

        public void lowerT2d()
        {
            getRef(arr);
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (j > i)
                    {
                        arr[i, j] = 0;
                    }
                }
            }
            display(arr);
        }

        //***************13***************

        public void sparse2d()
        {
            int i, j, count = 0;
            getRef(arr);
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (arr[i, j] == 0)
                        count++;
                }
            }
            if (count > 4)
                Console.WriteLine("It is Sparse Matrix");
            else Console.WriteLine("It is NOT Sparse Matrix");
        }

        //***************12***************

        public void sumDiagonal2d()
        {
            int i, j;
            getRef(arr);
            int sum = 0;
            bool flag = true;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if(i == j)
                        sum += arr[i,j];
                }
            }
            Console.WriteLine("Sum of Diagonal elements: " + sum);
        }

        //***************11***************

        public void scalar2d()
        {
            int i, j;
            getRef(arr);
            int dup = arr[0,0];
            bool flag = true;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        if (arr[i, j] != dup && arr[i,j] != 0)
                        {
                            flag = false; break;
                        }
                    }
                    if (arr[i, j] != 0 && i != j)
                    {
                        flag = false; break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Matrix is NOT Scalar Matrix");
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Matrix is Scalar Matrix");
            }
        }

        //***************10***************

        public void diagonal2d()
        {
            int i, j;
            getRef(arr);
            bool flag = true;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        if (arr[i, j] == 0)
                        {
                            flag = false; break;
                        }
                    }
                    if (arr[i, j] != 0 && i != j)
                    {
                        flag = false; break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Matrix is NOT Diagonal Matrix");
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Matrix is Diagonal Matrix");
            }
        }

    

        //***************9***************

        public void identity2d()
        {
            getRef(arr);
            int i, j;
            bool flag = true;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        if(arr[i, j] != 1) {
                            flag = false; break; 
                        }
                    }
                    if(arr[i, j] != 0 && i != j)
                    {
                        flag = false; break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Matrix is NOT Identity Matrix");
                    break;
                }
            }
            if(flag == true)
            {
                Console.WriteLine("Matrix is Identity Matrix");
            }
        }

        //***************8***************

        public void equal2d()
        {
            int i, j;
            getRef(arr);
            int[,] arr2 = new int[3, 3];
            getRef(arr2);
            bool flag = true;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (arr[i, j] != arr2[i, j])
                    {
                        Console.WriteLine("Matrices are not equal");
                        flag = false;
                        break;
                    }
                }
                if (flag == false)
                    break;
            }
            if(flag == true)
                Console.WriteLine("Matrices are Equal");
        }

        //***************7***************

        public void transpose2d()
        {
            int i, j;
            getRef(arr);
            Console.WriteLine("Transpose:");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(arr[j,i] + " ");
                }
                Console.WriteLine();
            }
        }

        //***************6***************

        public void square2d()
        {
            int i, j;
            getRef(arr);
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write((arr[i, j] * arr[i, j]) + " ");
                }
                Console.WriteLine();
            }
        }

        //***************5***************

        public void sub22d()
        {
            int i, j;
            getRef(arr);
            int[,] arr2 = new int[3,3];
            getRef(arr2);
            int[,] arr3 = new int[3,3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr3[i,j] = arr[i,j] - arr2[i,j];
                }
            }
            display(arr3);
        }

        //***************4***************

        public void prod2d()
        {
            int i, j, k, sum = 0;
            getRef(arr);
            int[,] arr2 = new int[3, 3];
            getRef(arr2);
            int[,] arr3 = new int[3, 3];

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    for(k = 0; k < 3 /*k < row size*/; k++)
                    {
                        sum += arr[i, k] * arr2[k, j];
                    }
                    arr3 [i, j] = sum;
                }
            }
            display(arr3);
        }

        //***************3***************

        public void sum22d()
        {
            int i, j;
            getRef(arr);
            int[,] arr2 = new int[3, 3];
            getRef(arr2);
            int[,] arr3 = new int[3, 3];

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr3[i, j] = arr[i, j] + arr2[i, j];
                }
            }
            Console.WriteLine("Sum of Two 2d Arrays");
            display(arr3);
        }

        //***************2***************
        public void sum2d()
        {
            int sum = 0, i, j;
            getRef(arr);
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine("Sum of Elements in the Matrix: " + sum);
        }

        //***************1***************
        public void driver() { 
            getRef(arr);
        }

        public void getRef(int[,] arr) {
            int i, j;
            for(i = 0;  i < 3; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter value in (" + i + "," + j + ")");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            display(arr);
        }

        public void display(int[,] arr) {
            int i, j;
            Console.WriteLine("\nArray Value");
            for (i = 0;i < 3; i++)
            {
                for (j = 0;j < 3; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine() ;
        }
    }
}