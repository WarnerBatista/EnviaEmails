using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaEmails.Models
{
    public class DestinatarioModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string[] DadosDestinatario { get; set; }
    }
}
