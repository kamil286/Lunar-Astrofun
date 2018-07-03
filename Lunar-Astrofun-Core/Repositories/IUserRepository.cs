using System;
using Lunar.Astrofun.Core.Domain;
using System.Collections.Generic;

namespace Lunar.Astrofun.Core.Repositories
{
    public interface IUserRepository: IBaseRepository<User>
    {
        User GetByEmail(string email);
    }
}
