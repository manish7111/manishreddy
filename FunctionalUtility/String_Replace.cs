using System;

namespace FunctionalUtility
{
    public class String_Replace
    {
        public void Replace()
        {
            Console.WriteLine("Enter the name to be replaced");
            String s = Console.ReadLine();
            String s1 = "hello username, how are you?";
            s1 = s1.Replace("username", s);
            Console.WriteLine(s1);
        }
    }
}
