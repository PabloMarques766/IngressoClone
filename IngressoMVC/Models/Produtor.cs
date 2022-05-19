using System.Collections.Generic;

namespace IngressoMVC.Models
{
    public class Produtor : Artista
    {
        public int ProdutorId { get; set; }
        public List<Filme> Filmes { get; set; }
        public List<FilmeCategoria> FilmesCategorias { get; set; }
    }
}
