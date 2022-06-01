using IngressoMVC.Data;
using Microsoft.AspNetCore.Mvc;


namespace IngressoMVC.Controllers
{
    public class CinemasController : Controller
    {
        private IngressoDbContext _context;

        public CinemasController(IngressoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Filmes);
        }

        public IActionResult Detalhes(int id)
        {
            return View(_context.Cinemas.Find(id));
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Atuaizar(int id)
        {
            //buscar um cinemas no banco 
            //passar o cinemas na view
                return View();
        }

        public IActionResult Deletar(int id)
        {
            //buscar um cinemas no banco 
            //passar o cinemas na view
                return View();
        }

    }
}