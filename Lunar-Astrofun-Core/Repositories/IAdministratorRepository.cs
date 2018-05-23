using System;
using System.Collections.Generic;
using System.Text;
using Lunar.Astrofun.Core.Domain;

namespace Lunar.Astrofun.Core.Repositories
{
    public interface IAdministratorRepository
    {
        IEnumerable<Administrator> GetAll();
    }
}
