using System.Collections.Generic;

namespace Convention.Repositories
{
    using Convention = Models.Convention;

    public interface IConventionRepository
    {
        public IList<Convention> Get(); 
    }
}
