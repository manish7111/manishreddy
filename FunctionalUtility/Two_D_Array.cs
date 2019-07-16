using System;

public class Two_D_Array
{
	public void Array()
	{
        Console.WriteLine("Enter number of rows");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of columns");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] intArray = new int[m, n];
        double[,] doubleArray = new double[m, n];
        bool[,] booleanArray = new bool[m, n];
        Console.WriteLine("1.Interger array \n2.Double Array \n3.Boolean array");
        int k = Convert.ToInt32(Console.ReadLine());
        switch (k)
        {
            case 1:
                Console.WriteLine("Enter integer array elements");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        intArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(intArray[i, j]);
                    }
                    Console.WriteLine();
                }
                break;

            case 2:
                Console.WriteLine("Enter double array elements");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        doubleArray[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(doubleArray[i, j]);
                    }
                    Console.WriteLine();
                }
                break;
                
            case 3:
                Console.WriteLine("Enter boolean array elements");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        booleanArray[i, j] = Convert.ToBoolean(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(booleanArray[i, j]);
                    }
                    Console.WriteLine();
                }
                break;

            default:
                Console.WriteLine("enter correct number");
                Convert.ToInt32(Console.ReadLine());
                break;

        }  
    }
}
