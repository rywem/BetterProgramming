using Commerce.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commerce.Data.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Commerce.Web.Tests
{
 
    public class TestCatalogRepository : ICatalogRepository
    {
 
        public IQueryable<Category> GetCategories()
        {

            IList<Category> result = new List<Category>();

            for (int i = 1; i < 3; i++)
            {
                Category c = new Category();
                c.ID = i;
                c.Name = "Parent " + i.ToString();
                c.ParentID = 0;

                for (int x = 10; x < 15; x++)
                {
                    Category sub = new Category();
                    sub.ID = x;
                    sub.Name = "Sub " + x.ToString();
                    sub.ParentID = i;
                    result.Add(sub);
                }
                result.Add(c);
            }

            return result.AsQueryable<Category>();
        }
    }
}
