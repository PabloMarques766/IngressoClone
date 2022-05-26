using IngressoMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class AtoresController : Controller
    {
        private IngressoDbContex _context;
        public IActionResult Index()
        {
            return Ok(_context.Atores);
        }

        public AtoresController(IngressoDbContex context)
        {
            _context = context;
        }



       
    }
}
