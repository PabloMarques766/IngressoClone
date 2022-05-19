using IngressoMVC.Models.Interfaces;
using System;

namespace IngressoMVC.Models
{
    public abstract class Artista : IEntidade
    {
        protected Artista(string nome, string bio, string fotoPerfilURL)        {
           
            Nome = nome;
            Bio = bio;
            FotoPerfilURL = fotoPerfilURL;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteração { get; set; }

        public string Nome { get; private set; }
        public string Bio { get; private set; }
        public string FotoPerfilURL { get; private set; }
    }
}
