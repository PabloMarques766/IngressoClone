﻿namespace IngressoMVC.Models
{
    public class FilmeCategoria
    {
        public FilmeCategoria(int filmeId, int categoriaId)
        {
            FilmeId = filmeId;
            CategoriaId = categoriaId;
        }

        public Filme Filme { get; set; }
        public int FilmeId { get; private set; }

        public Categoria Categoria { get; set; }
        public int CategoriaId { get; private set; }

    }
}
