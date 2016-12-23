using System.ComponentModel.DataAnnotations;

namespace asp.mvc5.basico.web.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [DataType(DataType.Text)]
        [StringLength(30)]
        public string Descricao { get; set; }
    }
}