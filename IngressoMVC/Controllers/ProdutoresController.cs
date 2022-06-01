using IngressoMVC.Data;
using Microsoft.AspNetCore.Mvc;


namespace IngressoMVC.Controllers
{
    public class ProdutoresController : Controller
    {
        private IngressoDbContext _context;

        public ProdutoresController(IngressoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Filmes);
        }

        public IActionResult Detalhes(int id)
        {
            return View(_context.Produtores.Find(id));
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Atuaizar(int id)
        {
            //buscar um produtor no banco 
            //passar o produtor na view
                return View();
        }

        public IActionResult Deletar(int id)
        {
            //buscar um produtor no banco 
            //passar o produtor na view
                return View();
        }

    }
}