// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserContext.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Manish Reddy"/>
// --------------------------------------------------------------------------------------------------------------------
using FundooModel;
using FundooModel.UserModel;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


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
        public UserContext() :base("connect")
        {
            
        }
       
        /// <summary>
        /// Gets or sets the user data.
        /// </summary>
        /// <value>
        /// The user data.
        /// </value>
        public DbSet<UserModels> UserData
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>
        /// The notes.
        /// </value>
        public DbSet<NotesModel> Notes
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>
        /// The labels.
        /// </value>
        public DbSet<LabelModel> Labels
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the note label.
        /// </summary>
        /// <value>
        /// The note label.
        /// </value>
        public DbSet<NotesLabelModel> NoteLabel
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the collaborator.
        /// </summary>
        /// <value>
        /// The collaborator.
        /// </value>
        public DbSet<CollaboratorModel> Collaborator
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the admin model.
        /// </summary>
        /// <value>
        /// The admin model.
        /// </value>
        public DbSet<AdminModel> AdminModel
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the admin login.
        /// </summary>
        /// <value>
        /// The admin login.
        /// </value>
        public DbSet<AdminLoginModel> AdminLogin
        {
            get;
            set;
        }
        /// <summary>
        /// Asynchronously saves all changes made in this context to the underlying database.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous save operation.
        /// The task result contains the number of state entries written to the underlying database. This can include
        /// state entries for entities and/or relationships. Relationship state entries are created for
        /// many-to-many relationships and relationships where there is no foreign key property
        /// included in the entity class (often referred to as independent associations).
        /// </returns>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        public override Task<int> SaveChangesAsync()
        {
            var addedEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Added).ToList();
            addedEntities.ForEach(E =>
            {
                E.Property("CreatedDate").CurrentValue = DateTime.Now;
            });
            var editedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Modified).ToList();
            editedEntities.ForEach(e =>
            {
                e.Property("ModifiedDate").CurrentValue = DateTime.Now;
            });
            return base.SaveChangesAsync();
            }
        }

}

