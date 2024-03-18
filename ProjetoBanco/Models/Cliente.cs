using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;

namespace ProjetoBanco.Models
{
    public class Cliente
    {
        [key]
        public long ClienteID { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }
        public string Email { get; set; }

        public string Telefone { get; set; }
    }
}
