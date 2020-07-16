using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Repositories
{
    interface IBaseRepository<T,Tkey>
        where T : BaseEntity<Tkey>
    {
        public bool Create(T item);
        public IEnumerable<T> Get();
        T Get( Tkey ID);
    }
}
