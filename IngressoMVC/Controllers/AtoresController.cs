using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.ViewModels.Request;
using Microsoft.AspNetCore.Mvc;


namespace IngressoMVC.Controllers
{
    public class AtoresController : Controller
    {
        public IngressoDbContext _context;

        public AtoresController(IngressoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Atores);
        }

        public IActionResult Detalhes(int id)
        {
            return View(_context.Atores.Find(id));
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(PostAtorDTO atorDto)
        {
            //receber os dados  check(x)
            Ator ator = new Ator(atorDto.Nome, atorDto.Bio, atorDto.FotoPerfilURL);
            //instanciar um novo ator que recebe os dados 
            _context.Atores.Add(ator);
            //gravar esse ator no banco
            _context.SaveChanges();
            //salvar essas mudanças

            return RedirectToAction(nameof(Index));
        }

        //public IActionResult Criar([Bind("Nome,Bio,FotoPerfilURL")] Ator ator)
        //{
        //    receber os dados / check(x)
        //    instanciar um novo ator que recebe os dados/ check(x)
        //    gravar esse ator no banco check(x)
        //    _context.Atores.Add(ator);

        //    salvar essas mudanças check(x)
        //    _context.SaveChanges();
        //    return RedirectToAction(nameof(Index));
        //}

        public IActionResult Atuaizar(int id)
        {
            //buscar um ator no banco 
            //passar o ator na view
            return View();
        }

        public IActionResult Deletar(int id)
        {
            //buscar um ator no banco 
            //passar o ator na view
            return View();
        }

    }
}
