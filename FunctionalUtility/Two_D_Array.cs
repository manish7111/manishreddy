using System;

public class Two_D_Array
{
	public void Array()
	{
        Console.WriteLine("Enter number of rows");

        //reading number of rows from the user
        int m = Convert.ToInt32(Console.ReadLine());    
        Console.WriteLine("Enter number of columns");

        //reading of number of columns from the user
        int n = Convert.ToInt32(Console.ReadLine());

        //declaration of integer type array
        int[,] intArray = new int[m, n];

        //declaration of double type array
        double[,] doubleArray = new double[m, n];

        //declaration of boolean type array
        bool[,] booleanArray = new bool[m, n];          
        Console.WriteLine("1.Interger array \n2.Double Array \n3.Boolean array");

        //read the input from user as which case u want to execute
        int k = Convert.ToInt32(Console.ReadLine());

        //switch case to execute code faster
        switch (k)                                     
        {
            case 1:
                Console.WriteLine("Enter integer array elements");

                //nested for loop for reading values in the integer array
                for (int i = 0; i < m; i++)           
                {
                    for (int j = 0; j < n; j++)
                    {
                        intArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                //nested for loop for printing values of the integer array
                for (int i = 0; i < m; i++)              
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(intArray[i, j]);
                    }
                    Console.WriteLine();
                }
                //end of execution
                break;                                   

            case 2:
                Console.WriteLine("Enter double array elements");

                //nested for loop for reading values from user in the double array
                for (int i = 0; i < m; i++)             
                {
                    for (int j = 0; j < n; j++)
                    {
                        doubleArray[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                //nested for loop for printing values of the double array
                for (int i = 0; i < m; i++)              
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(doubleArray[i, j]);
                    }
                    Console.WriteLine();
                }
                //end of execution
                break;                                   
                
            case 3:
                Console.WriteLine("Enter boolean array elements");

                //nested for loop for reading values in the boolean array
                for (int i = 0; i < m; i++)            
                {
                    for (int j = 0; j < n; j++)
                    {
                        booleanArray[i, j] = Convert.ToBoolean(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                //nested for loop for printing values present in the boolean array
                for (int i = 0; i < m; i++)            
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(booleanArray[i, j]);
                    }
                    Console.WriteLine();
                }
                //end of execution
                break;                                  

            default:
                Console.WriteLine("enter correct number");
                Convert.ToInt32(Console.ReadLine());
                break;

        }  
    }
}
