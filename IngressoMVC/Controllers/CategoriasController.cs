using IngressoMVC.Data;
using Microsoft.AspNetCore.Mvc;


namespace IngressoMVC.Controllers
{
    public class CategoriasController : Controller
    {
        private IngressoDbContext _context;

        public CategoriasController(IngressoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Atores);
        }

        public IActionResult Detalhes(int id)
        {
            return View(_context.Categorias.Find(id));
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Atuaizar(int id)
        {
            //buscar um categoria no banco 
            //passar o categoria na view
                return View();
        }

        public IActionResult Deletar(int id)
        {
            //buscar um categoria no banco 
            //passar o categoria na view
                return View();
        }

    }
}
