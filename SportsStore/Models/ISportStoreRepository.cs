using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface ISportStoreRepository
    {
        //percorrer todos os produtos
        public IEnumerable<Product> Products { get;}
    }
}
