using System;
using System.Collections.Generic;

namespace IngressoMVC.Models
{
    public class Cinema : IEntidade
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteração { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string LogoURL { get; set; }
        
        public List<Filme> Filmes { get; set; }

        #region relacionamentos 

        public int CinemaId { get; set; }
        public int ProdutorId { get; set; }
        public Produtor Produtor { get; set; }

        public List<AtorFilme> AtoresFilmes { get; set; }

        #endregion
    }
}
