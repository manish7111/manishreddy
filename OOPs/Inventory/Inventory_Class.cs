// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inventory_Class.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Text;
/// <summary>
/// OOPs is an namespace where all the class and methods are declared.
/// </summary>
namespace OOPs
{
    /// <summary>
    /// Inventory classs is a class works as an model class
    /// </summary>
    public class Inventory_Class
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;
        /// <summary>
        /// The weight
        /// </summary>
        private double weight;
        /// <summary>
        /// The price per kg
        /// </summary>
        private double pricePerKg;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        /// <summary>
        /// Gets or sets the price per kg.
        /// </summary>
        /// <value>
        /// The price per kg.
        /// </value>
        public double PricePerKg
        {
            get
            {
                return this.pricePerKg;
            }
            set
            {
                this.pricePerKg = value;
            }
        }
    }
}
