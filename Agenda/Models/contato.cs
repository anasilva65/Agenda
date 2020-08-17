using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    public class contato
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do contato deve ser informado.!")]
        [StringLength(50, MinimumLength = 5)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O telefone deve ser informado.!")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Forneça o número do telefone no formato (00) 00000-0000")]
        [DisplayName("Número do Telefone")]
        public int Telefone { get; set; }

        public int Idade { get; set; }
    }
}