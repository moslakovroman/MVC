using System.Collections.Generic;
using model;

namespace api.Interfaces
{
    public interface IRepoProduct
    {
        List<Product> GetIndexData();

    }
}