using IngressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace IngressoMVC.Models
{
    public class Cinema : IEntidade
    {
        public Cinema(string nome, string descricao, string logoURL)
        {
            Nome = nome;
            Descricao = descricao;
            LogoURL = logoURL;

        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteração { get; set; }
        public string Nome { get;  private set; }
        public string Descricao { get; private set; }
        public string LogoURL { get; private set; }
        
        public List<Filme> Filmes { get; set; }

        #region relacionamentos 

        public int CinemaId { get; set; }
        public int ProdutorId { get; set; }
        public Produtor Produtor { get; set; }

        public List<AtorFilme> AtoresFilmes { get; set; }

        #endregion
    }
}
