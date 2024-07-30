using clients.Models;
using livraria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    public class ClientController : Controller
    {
        private readonly AppDbContext _context;

        public ClientController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var clients = _context.Clients.ToList();
            return View(clients);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Client client)
        {
            return client.Create();
        }        
    }
}