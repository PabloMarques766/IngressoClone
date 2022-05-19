using IngressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace IngressoMVC.Models
{
    public class Filme : IEntidade
    {
        public Filme( string titulo, string descricao, decimal preco, string imageURL)
        {
            Titulo = titulo;
            Descricao = descricao;
            Preco = preco;
            ImageURL = imageURL;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteração { get; set; }
       
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public string ImageURL { get; private set; }
        
        public Cinema Cinema { get; set; }
        public List<FilmeCategoria> FilmesCategorias { get; set; }

        //relacionamentos
        public void AlterarPreco(decimal novoPreco)
        {
            Preco = novoPreco;
        }
    }
}
