using System;

public class Sum_Of_Integers
{
	public void sum()
	{
        Console.WriteLine("Enter the value of n");

        //read length of array 'n' value from the user
        int n = Convert.ToInt32(Console.ReadLine());   
        
        //define a array of integer type as we are Storing integer type elements
        int[] a = new int[n];                               
        int count = 0;

        //read array elements until condition fails
        for (int i=0;i<n;i++)                                
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        //to ckeck the triplets nested forloops are used

        for (int i = 0; i < n; i++)                        
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {

                    //triplet condition

                    if (a[i]+a[j]+a[k]==0)                   
                    {
                        count++;
                        Console.WriteLine("triplets are:" + a[i] + " " + a[j] + " " + a[k]);
                    }
                }
            }
        }

        //prints the count of number of triplets present
        Console.WriteLine("count-->"+count);               
    }
}
