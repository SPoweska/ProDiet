using Microsoft.EntityFrameworkCore;
using ProDiet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDietTests.Infrastructure
{
    public static class DbContextFactory
    {
        public static ProDietContext Create()
        {
            var options = new DbContextOptionsBuilder<ProDietContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new ProDietContext(options);

            context.Database.EnsureCreated();

            return context;
        }

        public static void Destroy(ProDietContext context)
        {
            context.Database.EnsureDeleted();

            context.Dispose();
        }
    }
}
