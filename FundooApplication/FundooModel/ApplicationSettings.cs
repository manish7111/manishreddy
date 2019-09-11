// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ApplicationSettings.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// FundooModel is the namespace.
/// </summary>
namespace FundooModel
{
    /// <summary>
    /// ApplicationSettings is the model class.
    /// </summary>
    public class ApplicationSettings
    {
        /// <summary>
        /// Gets or sets the JWT secret.
        /// </summary>
        /// <value>
        /// The JWT secret.
        /// </value>
        public string JWT_Secret
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the client URL.
        /// </summary>
        /// <value>
        /// The client URL.
        /// </value>
        public string Client_URL
        {
            get;
            set;
        }
    }
}
