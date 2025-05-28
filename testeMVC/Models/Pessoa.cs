using System.ComponentModel.DataAnnotations;

namespace testeMVC.Models
{
    public class Pessoa
    {
        [Display(Name = "Código do cliente")]
        public int? PessoaId { get; set; }
        [Display(Name = "Nome do cliente")]
        public string? Nome { get; set; }
        [Display(Name = "Email do cliente")]
        public string? Email { get; set; }
    }
}
