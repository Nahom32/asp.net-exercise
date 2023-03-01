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
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Category obj)
    {
        if(ModelState.IsValid)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        return View(obj);
    }
    
    public IActionResult Edit(int? id)
    {
        if(id == null || id <2)
        {
            return NotFound();
        }
        var categoryFromDb = _db.Categories.Find(id);
        if(categoryFromDb == null)
        {
            return NotFound();
        }
        return View(categoryFromDb);    
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Category obj)
    {
        if(ModelState.IsValid)
        {
            _db.Categories.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        return View(obj);
    }

}