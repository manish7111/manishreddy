// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Singleton.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
/// <summary>
/// DesignPatterns is an namespace.
/// </summary>
namespace DesignPatterns
{
    /// <summary>
    /// Singleton is a class.
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// The instance count
        /// </summary>
        public static int instanceCount = 0;
        /// <summary>
        /// The instance
        /// </summary>
        private static Singleton instance ;
        /// <summary>
        /// The lock object
        /// </summary>
        private static readonly object lockObject = new object();
        /// <summary>
        /// Prevents a default instance of the <see cref="Singleton"/> class from being created.
        /// </summary>
        private Singleton()
        {
            instanceCount++;
            Console.WriteLine("Instance created: " + instanceCount);
        }
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static Singleton Instance
        {
            get
            {
                ////Lock is used to lock the object to create more than once.
                lock(lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
        /// <summary>
        /// Prints the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void PrintMessage(string message)
        {
            Console.WriteLine("Message : " + message);
        }
    }
}

