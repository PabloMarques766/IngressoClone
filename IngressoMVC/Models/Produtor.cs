using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Produtor : Artista
    {
        public int ProdutorId { get; set; }
        public Produtor Produtor { get; set; }
        public List<Filme> Filmes { get; set; }
        public List<FilmeCategoria> FilmesCategorias { get; set; }
    }
}
