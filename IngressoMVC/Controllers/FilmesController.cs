using IngressoMVC.Data;
using IngressoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class FilmesController : Controller
    {
        private IngressoDbContex _context;

        public IActionResult Index()
        {
            return Ok(_context.Filmes);
        }

        public FilmesController(IngressoDbContex context)
        {
            _context = context;
        }


        [HttpGet] 
        public ActionResult<Filme> ListarFilmes()
        {
            var resultado = _context.Filmes.Find();

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }
    }
}
