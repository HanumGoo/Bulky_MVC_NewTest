using Bulky1.DataAccess.Data;
using Bulky1.DataAccess.Repository.IRepository;
using Bulky1.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky1.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
        }

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
