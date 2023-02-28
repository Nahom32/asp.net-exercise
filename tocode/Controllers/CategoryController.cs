using Microsoft.AspNetCore.Mvc;
using tocode.Data;
using tocode.Models;

namespace tocode.Controllers;
public class CategoryController: Controller
{
    private readonly ApplicationDbContext _db;
    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        IEnumerable<Category> objCategoryList = _db.Categories.ToList();
        return View(objCategoryList);
    }

}