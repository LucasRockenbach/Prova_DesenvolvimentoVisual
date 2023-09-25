using System.ComponentModel.DataAnnotations;

namespace APIExemplo.Models
{
    public class Medicamento
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string descricao { get; set; }
        public string lote { get; set; }
        public int mesVencimento { get; set; }
        public int anoVencimento { get; set; }
        public string marca { get; set; }
        public string fabricante { get; set; }

    }
}
