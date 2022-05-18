using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class FilmeCategoria
    {
        public Filme Filme { get; set; }
        public int FilmeId { get; set; }

        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

    }
}
