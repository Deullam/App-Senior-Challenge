using livraria.Models;
using Microsoft.AspNetCore.Mvc;

namespace livraria.Controllers
{
    public class LivrariaController :Controller
    {
        private readonly AppDbContext _context;

        public LivrariaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var books = _context.Livros.ToList();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Livro livro)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Livros.Add(livro);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError(string.Empty, 
                       $"Algo deu errado {ex.Message}");
                }
            }
            ModelState.AddModelError(string.Empty, 
               $"Algo deu errado, modelo inválido");
            return View(livro);
        }        
    }
}