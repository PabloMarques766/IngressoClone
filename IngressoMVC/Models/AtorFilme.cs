namespace IngressoMVC.Models
{
    public class AtorFilme
    {
        public Ator Ator { get; set; }
        public int AtorId { get; set; }

        public Filme Filme  { get; set; }
        public int  FilmeId { get; set; }
    
    }
}
