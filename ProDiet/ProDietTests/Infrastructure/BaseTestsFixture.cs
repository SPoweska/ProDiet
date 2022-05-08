using ProDiet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDietTests.Infrastructure
{
    public abstract class BaseTestFixture : IDisposable
    {
        public ProDietContext Context { get; }

        public BaseTestFixture()
        {
            Context = DbContextFactory.Create();
        }
        public void Dispose()
        {
            DbContextFactory.Destroy(Context);
        }
    }
}
