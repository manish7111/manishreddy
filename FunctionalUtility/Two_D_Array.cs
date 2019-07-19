// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Two_D_Array.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// Two_D_Array is a class where i defined integer array,double array,boolean array and printing the elements in it.
/// </summary>
public class Two_D_Array
{
    /// <summary>
    /// Arrays this instance and prints the output using the switch case.
    /// </summary>
    public void Array()
	{
        Console.WriteLine("Enter number of rows");

        ////Reading number of rows from the user
        int row = Convert.ToInt32(Console.ReadLine());    
        Console.WriteLine("Enter number of columns");

        ////Reading of number of columns from the user
        int column = Convert.ToInt32(Console.ReadLine());

        ////Declaration of integer type array
        int[,] intArray = new int[row, column];

        ////Declaration of double type array
        double[,] doubleArray = new double[row, column];

        ////Declaration of boolean type array
        bool[,] booleanArray = new bool[row, column];          
        Console.WriteLine("1.Interger array \n2.Double Array \n3.Boolean array");

        ////Read the input from user as which case u want to execute
        int k = Convert.ToInt32(Console.ReadLine());

        ////Switch case to execute code faster
        switch (k)                                     
        {
            case 1:
                Console.WriteLine("Enter integer array elements");

                ////Nested for loop for reading values in the integer array
                for (int i = 0; i < row; i++)           
                {
                    for (int j = 0; j < column; j++)
                    {
                        intArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                ////Nested for loop for printing values of the integer array
                for (int i = 0; i < row; i++)              
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write(intArray[i, j]);
                    }
                    Console.WriteLine();
                }
                ////End of execution
                break;                                   

            case 2:
                Console.WriteLine("Enter double array elements");

                ////Nested for loop for reading values from user in the double array
                for (int i = 0; i < row; i++)             
                {
                    for (int j = 0; j < column; j++)
                    {
                        doubleArray[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                ////Nested for loop for printing values of the double array
                for (int i = 0; i < row; i++)              
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write(doubleArray[i, j]);
                    }
                    Console.WriteLine();
                }
                ////End of execution
                break;                                   
                
            case 3:
                Console.WriteLine("Enter boolean array elements");

                ////Nested for loop for reading values in the boolean array
                for (int i = 0; i < row; i++)            
                {
                    for (int j = 0; j < column; j++)
                    {
                        booleanArray[i, j] = Convert.ToBoolean(Console.ReadLine());
                    }
                    Console.WriteLine();
                }

                ////Nested for loop for printing values present in the boolean array
                for (int i = 0; i < row; i++)            
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write(booleanArray[i, j]);
                    }
                    Console.WriteLine();
                }
                ////End of execution
                break;                                  

            default:
                Console.WriteLine("enter correct number");
                Convert.ToInt32(Console.ReadLine());
                break;

        }  
    }
}
