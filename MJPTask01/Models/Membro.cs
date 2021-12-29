using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MJPTask01.Models
{
    public class Membro
    {
        public Membro()
        {
            id = Guid.NewGuid();
            DataCadastro = DateTime.Now;
        }
        public Guid id { get; set; }
        [Required]
        public string NomeCompleto { get; set; }
        [Required]
        public DateTime DataNacimento { get; set; }
        public DateTime? DataBatismo { get; set; }
        public DateTime DataCadastro { get; set; }
        public Contato ContatoPessoal { get; set; }
        public Endereco Endereco { get; set; }

       

    }
}