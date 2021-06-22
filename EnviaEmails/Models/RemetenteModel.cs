using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaEmails.Models
{
    public class RemetenteModel
    {
        public int Porta { get; set; }
        public string Smtp { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Assunto { get; set; }
    }
}
