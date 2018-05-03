using Redoak.Domain.Model.Models;

namespace Redoak.Dal.Repository
{
    public abstract class BaseRepository
    {
        public RedoakContext Context;

        protected BaseRepository(RedoakContext context)
        {
            Context = context;
        }
    }
}