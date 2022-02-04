using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Db
{
    public class Database : DbContext
    {
        public Database(DbContextOptions options ) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is AuditableEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));


            //var userName = ;

            foreach (var entityEntry in entries)
            {
                ((AuditableEntity)entityEntry.Entity).ModifiedAt = DateTime.UtcNow;
                //((AuditableEntity)entityEntry.Entity).ModifiedBy = userName;

                if (entityEntry.State == EntityState.Added)
                {
                    ((AuditableEntity)entityEntry.Entity).CreatedAt = DateTime.UtcNow;
                    //((AuditableEntity)entityEntry.Entity).CreatedBy = userName;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
