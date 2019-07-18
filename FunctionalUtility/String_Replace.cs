using System;

namespace FunctionalUtility
{
    public class String_Replace
    {
        public string Replace()
        {
            Console.WriteLine("Enter the name to be replaced");

            //read string from the user which has to replace
            String s = Console.ReadLine();                          
            String s1 = "hello username, how are you?";

            //using static method replace for string replacement
            s1 = s1.Replace("username", s);

            //prints the output of replaced string
            return s1;                                 
        }
    }
}
