using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Endereco:GenericModel
    {
        [Key]
        public long EnderecoId { get; set; }

        public long PessoaId { get; set; }

        public String Rua { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String CEP { get; set; }

        [ForeignKey("PessoaId")]
        public Pessoa Pessoa { get; set; }
    }
}
