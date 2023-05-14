using Project.DAL.Context;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concretes
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MyContext db):base(db) 
        {

        }
        public void SpecialCategoryCreation(Category category)
        {
            List<Product> products = new List<Product>
           {
               new Product
               {
                   ProductName="Tadelle",
                   UnitPrice = 15.34M
               },
                new Product
               {
                   ProductName="Gofret",
                   UnitPrice = 12.34M
               },
                 new Product
               {
                   ProductName="Cizi",
                   UnitPrice = 16.34M
               },
           };
            category.Products = products;
            Add(category);
        }
    }
}
