using System.Collections.Generic;

namespace WebFormsDI.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> List();
    }
}