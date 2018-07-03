using Lunar.Astrofun.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lunar.Astrofun.Core.Repositories
{
    public interface IBaseRepository<T>
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();  
        void Add(T model);
        void Update(T model);
        void Remove(Guid id);
    }
}
