using Store.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Store.Domain.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Get(IEnumerable<Guid> ids);
    }
}