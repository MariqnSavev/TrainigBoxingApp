using Microsoft.AspNetCore.Mvc;
using TrainigBoxingApp.Data;
using TrainigBoxingApp.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class WorkoutController : Controller
{
    private readonly AppDbContext _context;


    public WorkoutController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var workouts = _context.Workouts.Include(w => w.User).ToList();
        return View(workouts);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Workout workout)
    {
        if (ModelState.IsValid)
        {
            _context.Workouts.Add(workout);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(workout);
    }

    // Други методи (Edit, Delete)
}
