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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
