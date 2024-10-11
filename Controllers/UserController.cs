using Microsoft.AspNetCore.Mvc;
using TrainigBoxingApp.Data; // Папка с контекста на базата данни
using TrainigBoxingApp.Models; // Папка с моделите
using System.Threading.Tasks;

namespace TrainigBoxingApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // Заменете с името на метода, който показва списъка с потребители
            }
            return View(user);
        }

        // Метод за показване на списък с потребители
        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }
    }
}