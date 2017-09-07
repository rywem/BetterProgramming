using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commerce.Data.DataAccess;
using Commerce.Data.Database;

namespace Commerce.Service
{
    public class CatalogService : Commerce.Data.DataAccess.ICatalogRepository
    {
        IQueryable<Category> ICatalogRepository.GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
