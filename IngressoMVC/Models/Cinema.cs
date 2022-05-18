﻿using System;

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
    }
}
