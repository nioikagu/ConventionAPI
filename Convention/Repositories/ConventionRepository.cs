using Convention.Models;
using System.Collections.Generic;
using System.Linq;

namespace Convention.Repositories
{
    public class ConventionRepository : IConventionRepository
    {
        private readonly ConventionContext context;

        public ConventionRepository(ConventionContext context)
        {
            this.context = context;
        }

        public IList<Models.Convention> Get()
        {
            return context.Conventions.ToList();
        }
    }
}
