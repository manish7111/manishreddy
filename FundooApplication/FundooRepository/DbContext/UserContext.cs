// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserContext.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;
using System;
using System.Data.Entity;

/// <summary>
/// FundooRepository is the namespace.
/// </summary>
namespace FundooRepository
{
    /// <summary>
    /// UserContext is a class which implements DbContext.
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class UserContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserContext"/> class.
        /// </summary>
        public UserContext() : base("connect")
        {

        }
        /// <summary>
        /// Gets or sets the user data.
        /// </summary>
        /// <value>
        /// The user data.
        /// </value>
        public DbSet<UserModel> UserData
        {
            get;
            set;
        }
       
    }
}
