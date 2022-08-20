using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeBox.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using System;


namespace RecipeBox.Controllers
{
  public class RecipesController : Controller
  {
    private readonly RecipeBoxContext _db;

    public RecipesController(RecipeBoxContext db)
    {
      _db = db;
    }

    public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString)
    {
      ViewData["RateSortParm"] = sortOrder == "Rate" ? "rate_desc" : "Rate";
       
      ViewBag.CurrentFilter = searchString;
      var recipes = from s in _db.Recipes
                    select s;

      if (!string.IsNullOrEmpty(searchString))
      {
          recipes = recipes.Where(s => s.Ingredients.Contains(searchString));
      }
      switch (sortOrder)
      {
        case "Rate":
          recipes = recipes.OrderBy(s => s.Rate);
          break;
        case "rate_desc":
          recipes = recipes.OrderByDescending(s => s.Rate);
          break;
        default:
            recipes = recipes.OrderBy(s => s.Rate);
            break;
      }
      return View(await recipes.AsNoTracking().ToListAsync());
    }

    public ActionResult Details(int id)
    {
        var thisRecipe = _db.Recipes
            .Include(recipe => recipe.JoinEntities)
            .ThenInclude(join => join.Category)
            .FirstOrDefault(recipe => recipe.RecipeId == id);
        return View(thisRecipe);
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Recipe recipe, string RecipeName )
    {     
        if(!(_db.Recipes.Any( u => u.RecipeName == RecipeName)))
        {
          if(ModelState.IsValid)
          {
            _db.Recipes.Add(recipe);
            _db.SaveChanges();
            return RedirectToAction("Index");
          }
        }
        
         return View(recipe);
    }

    public ActionResult Edit(int id)
    {
        var thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
        ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
        return View(thisRecipe);
    }

    [HttpPost]
    public ActionResult Edit(Recipe recipe)
    {
        _db.Entry(recipe).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult Edit(Recipe recipe, int CategoryId)
    {
      if (CategoryId != 0)
      {
        _db.RecipeCategory.Add(new RecipeCategory() { CategoryId = CategoryId, RecipeId = recipe.RecipeId });
      }
      _db.Entry(recipe).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddCategory(int id)
    {
        var thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
        ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
        return View(thisRecipe);
    }

    [HttpPost]
    public ActionResult AddCategory(Recipe recipe, int CategoryId)
    {
        if (CategoryId != 0)
        {
          _db.RecipeCategory.Add(new RecipeCategory() { CategoryId = CategoryId, RecipeId = recipe.RecipeId });
          _db.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
        var thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
        return View(thisRecipe);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeId == id);
        _db.Recipes.Remove(thisRecipe);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteCategory(int joinId)
    {
        var joinEntry = _db.RecipeCategory.FirstOrDefault(entry => entry.RecipeCategoryId == joinId);
        _db.RecipeCategory.Remove(joinEntry);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}