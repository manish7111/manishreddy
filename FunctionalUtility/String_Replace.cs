// --------------------------------------------------------------------------------------------------------------------
// <copyright file="String_Replace.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
namespace FunctionalUtility
{
    /// <summary>
    /// String_Replace is a class where Replace method is created
    /// </summary>
    public class String_Replace
    {
        /// <summary>
        /// Replaces this instance.
        /// </summary>
        /// <returns>returns Replaced String<returns>
        public string Replace()
        {
            Console.WriteLine("Enter the name to be replaced");

            ////Read string from the user which has to replace
            string string1 = Console.ReadLine();                          
            string string2 = "hello username, how are you?";

            ////Using static method replace for string replacement
            string2 = string2.Replace("username", string1);

            ////Prints the output of replaced string
            return string2;                                 
        }
    }
}
