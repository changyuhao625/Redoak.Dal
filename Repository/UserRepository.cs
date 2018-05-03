using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Redoak.Domain.Model.Models;

namespace Redoak.Dal.Repository
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(RedoakContext context) : base(context)
        {
        }

        public async Task<IList<AspNetUsers>> LoadUsers()
        {
            return await Context.AspNetUsers.ToListAsync();
        }
    }
}