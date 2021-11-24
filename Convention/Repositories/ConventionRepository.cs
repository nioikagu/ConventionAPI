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

        public void Add(Models.Convention convention)
        {
            context.Conventions.Add(convention);
        }

        public IList<Models.Convention> Get()
        {
            return context.Conventions.ToList();
        }

        public void Remove(Models.Convention convention)
        {
            context.Conventions.Remove(convention);
        }

        public Models.Convention Find(int id)
        {
            return context.Conventions.FirstOrDefault(x => x.Id == id);
        }

    }
}
