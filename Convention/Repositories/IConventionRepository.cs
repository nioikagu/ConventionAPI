using System.Collections.Generic;

namespace Convention.Repositories
{
    using Convention = Models.Convention;
    public interface IConventionRepository
    {
        public IList<Convention> Get();
        public void Add(Convention convention);
        public void Remove(Convention convention);
        public Convention Find(int id); 
    }
}
