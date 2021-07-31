using System.ComponentModel.DataAnnotations;

namespace AtelierJaneCunhaWeb.Models
{
    public class MensagemContato
    {
        [Required(ErrorMessage = "Nome precisa estar preenchido!")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Passe um e-mail válido!")]
        [Required(ErrorMessage = "Email precisa estar preenchido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mensagem precisa estar preenchida!")]
        public string Mensagem { get; set; }
    }
}