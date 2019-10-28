using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeRepository : ISportStoreRepository
    {
        //criar lista falsa
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product{Name = "Football ball",Price = 25 },
            new Product{Name = "Surf board",Price = 300 },
            new Product{Name = "T-shirt",Price = 30 }
            

        };
    }
}
