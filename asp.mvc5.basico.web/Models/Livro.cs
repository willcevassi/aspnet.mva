namespace asp.mvc5.basico.web.Models
{
    public class Livro
    {
        public int ID { get; set; }

        public string Titulo { get; set; }
        public string Autor { get; set; }

        public decimal Valor { get; set; }

        public int Estoque { get; set; }
    }
}