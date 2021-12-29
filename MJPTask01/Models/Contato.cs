using System.ComponentModel.DataAnnotations;

namespace MJPTask01.Models
{
    public class Contato
    {
        public string NumeroCelular { get; set; }
        [Required]
        public string Email { get; set; }
    }
}