using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly Database db;

        public UserRepository(Database db)
        {
            this.db = db;
        }
        public async Task CreateUser(User user)
        {
            if(user == null)
            {
                throw new Exception(nameof(User));
            }

            db.Users.Add(user);
            await db.SaveChangesAsync(default);
        }
    }
}
