using BulkyWeb1Razor.Data;
using BulkyWeb1Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWeb1Razor.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        

        private readonly ApplicationDbContext _db;
        public Category? Category { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            Category? categoryFromDb = _db.Categories.FirstOrDefault(c => c.Id == id);
            if (categoryFromDb == null) 
            {
                
                RedirectToPage("Index");
            }
            else
            {
                Category = categoryFromDb;
            }
            
        }
        public IActionResult OnPost(int? id)
        {
            Category? categoryFromDb = _db.Categories.FirstOrDefault(c => c.Id == id);
            if (categoryFromDb != null)
            {
                _db.Categories.Remove(categoryFromDb);
                _db.SaveChanges();
                TempData["success"] = "Category deleted successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
