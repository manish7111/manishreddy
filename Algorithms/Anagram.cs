using System;

public class Anagram
{
	public void Check()                       //created a method
	{
        String s1 = Console.ReadLine();       //Reading of 2 strings 
        String s2 = Console.ReadLine();
        
        if(s1.Length==s2.Length)              
        {
            int count = 0;
            char[] ch1=s1.ToCharArray();        //converting string to array
            char[] ch2 = s2.ToCharArray();
            Array.Sort(ch1);                    //Sorting of array
            Console.WriteLine(ch1);
            Array.Sort(ch2);
            Console.WriteLine(ch2);
            for (int i=0;i<ch1.Length;i++)
            {
                    if(ch1[i]==ch2[i])
                    {
                     count++;
                    }
            }
            if(count==s1.Length)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not a Anagram");
            }
          
        }
        else
        {
            Console.WriteLine("String's entered should be of some length");
        }
    }
}
