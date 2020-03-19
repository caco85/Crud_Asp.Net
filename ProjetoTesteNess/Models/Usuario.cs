using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Xunit;

namespace ProjetoTesteNess.Models
{
    public class Usuario
    {
        public int userID{get;set;}

        public string nome { get; set; }
  //      [RegularExpression(@"[0-9]{3}.\[0-9]{3}.\[0-9]{3}.\[0-9]{2}-\", ErrorMessage = "O cpf tem que ser 000.000.000-19")]
        public string cpf { get; set; }
        public string telefone { get; set; }

    }
}