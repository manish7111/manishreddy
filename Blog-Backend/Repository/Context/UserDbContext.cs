using Common;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
        public DbSet<Items> Items
        {
            get;
            set;
        }
        public DbSet<Description> Descriptions
        {
            get;
            set;
        }
        public DbSet<Sizes> Sizes
        {
            get;
            set;
        }
        public DbSet<Colors> Colors
        {
            get;
            set;
        }
        public DbSet<SelectedItem> SelectedItem
        {
            get;
            set;
        }
        public DbSet<AuthUser> AuthUsers
        {
            get;
            set;
        }
        public DbSet<Address> Addresses
        {
            get;
            set;
        }
    }
}
