using LocalTaste.Data.Migrations;
using LocalTaste.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalTaste.Data
{
    public class LocalTasteDataContext : DbContext, IDisposable
    {
        public LocalTasteDataContext()
            : base("LocalTaste")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<LocalTasteDataContext, Configuration>());
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(u => u.Reviews).WithRequired(r => r.User).HasForeignKey(r => r.UserId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Restaurant>().HasMany(r => r.Reviews).WithRequired(r => r.Restaurant).HasForeignKey(r => r.RestaurantId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Review>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
