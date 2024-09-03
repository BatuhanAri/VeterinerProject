using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AnimalClinic.Models;

public class OwnerController : Controller
{
    private readonly AnimalClinicContext _context;

    public OwnerController(AnimalClinicContext context)
    {
        _context = context;
    }

    // CREATE: Yeni bir hayvan sahibi eklemek için GET ve POST metotları
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Owner owner)
    {
        if (ModelState.IsValid)
        {
            _context.Owners.Add(owner);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(owner);
    }

    // READ: Tüm hayvan sahiplerini listelemek için
    public IActionResult Index()
    {
        var owners = _context.Owners.ToList();
        return View(owners);
    }

    // UPDATE: Var olan bir hayvan sahibini düzenlemek için GET ve POST metotları
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var owner = _context.Owners.Find(id);
        if (owner == null)
        {
            return NotFound();
        }
        return View(owner);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Owner owner)
    {
        if (ModelState.IsValid)
        {
            _context.Owners.Update(owner);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(owner);
    }

    // DELETE: Bir hayvan sahibini silmek için GET ve POST metotları
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var owner = _context.Owners.Find(id);
        if (owner == null)
        {
            return NotFound();
        }
        return View(owner);
    }

    [HttpPost]
    [ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var owner = _context.Owners.Find(id);
        if (owner != null)
        {
            _context.Owners.Remove(owner);
            _context.SaveChanges();
        }
        return RedirectToAction(nameof(Index));
    }
}
