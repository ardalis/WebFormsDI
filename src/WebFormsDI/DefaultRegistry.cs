using Microsoft.AspNet.Identity;
using StructureMap;
using WebFormsDI.Models;

namespace WebFormsDI
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        { 
            this.Policies.SetAllProperties(y => y.WithAnyTypeFromNamespaceContainingType<IProductRepository>());
            For<IProductRepository>().Use<ProductRepository>();
        }
    }
}