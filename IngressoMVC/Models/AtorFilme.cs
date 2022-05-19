﻿namespace IngressoMVC.Models
{
    public class AtorFilme
    {
        public AtorFilme(int atorId, int filmeId)
        {
            AtorId = atorId;
            FilmeId = filmeId;
        }

        public Ator Ator { get;  set; }
        public int AtorId { get; private set; }

        public Filme Filme  { get; set; }
        public int  FilmeId { get; private set; }
    
    }
}
