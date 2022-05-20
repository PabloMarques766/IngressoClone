using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models
{
    public class FilmeCategoria
    {
        public FilmeCategoria(int filmeId, int categoriaId)
        {
            FilmeId = filmeId;
            CategoriaId = categoriaId;
        }
        [Key]
        public int FilmeId { get; private set; }
        public Filme Filme { get; set; }
        
        [Key]
        public int CategoriaId { get; private set; }
        public Categoria Categoria { get; set; }

    }
}
