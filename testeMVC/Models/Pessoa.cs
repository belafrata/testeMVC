using System.ComponentModel.DataAnnotations;

namespace testeMVC.Models
{
    public class Pessoa
    {
        [Display(Name = "Código do cliente")]
        public int? PessoaId { get; set; }
        [Display(Name = "Nome do cliente")]
        public string? Nome { get; set; }
        [EmailAddress(ErrorMessage = "Endereço de Email Inválido")]
        public string? Email { get; set; }
    }
}
