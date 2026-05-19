using Bulky1.DataAccess.Repository.IRepository;
using Bulky1.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb1.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Product> objProductList = _unitOfWork.Product.GetAll().ToList();
            return View(objProductList);
        }
    }
}
