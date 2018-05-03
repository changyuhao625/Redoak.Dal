using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Redoak.Domain.Model.Models;

namespace Redoak.Dal.Repository
{
    public class RoleRepository : BaseRepository
    {
        public RoleRepository(RedoakContext context) : base(context)
        {
        }

        public async Task<IList<AspNetRoles>> LoadRoles()
        {
            return await Context.AspNetRoles.ToListAsync();
        }
    }
}