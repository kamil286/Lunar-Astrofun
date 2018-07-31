using Lunar.Astrofun.Core.Domain;
using Lunar.Astrofun.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lunar.Astrofun.Infrastructure.Repositories
{
    public class InMemoryAdmistratorRepository : IAdministratorRepository
    {
        public IEnumerable<Administrator> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
