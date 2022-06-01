using IngressoMVC.Data;
using Microsoft.AspNetCore.Mvc;


namespace IngressoMVC.Controllers
{
    public class FilmesController : Controller
    {
        private IngressoDbContext _context;

        public FilmesController(IngressoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Filmes);
        }

        public IActionResult Detalhes(int id)
        {
            return View(_context.Filmes.Find(id));
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Atuaizar(int id)
        {
            //buscar um filme no banco 
            //passar o filme na view
                return View();
        }

        public IActionResult Deletar(int id)
        {
            //buscar um filme no banco 
            //passar o filme na view
                return View();
        }

    }
}