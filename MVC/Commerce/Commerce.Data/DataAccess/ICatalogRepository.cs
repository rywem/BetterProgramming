using Commerce.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data.DataAccess
{
    public interface ICatalogRepository
    {
        IQueryable<Category> GetCategories();
    }
}
