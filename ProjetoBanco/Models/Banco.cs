using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBanco.Models
{
    public class Banco
    {
        [key]
        public int BancoID { get; set; }

        public string Nome { get; set; }

        public string Descicao { get; set; }

        public string CD { get; set; }

        public int Saldo { get; set; }

        public int NumeroConta { get; set; }

        [ForeignKey("Cliente")]

        public long fk_ClienteID { get; set; }

        public Cliente? Cliente { get; set; }
    }
}
