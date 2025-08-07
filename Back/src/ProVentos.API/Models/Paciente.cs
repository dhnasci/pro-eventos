using System;
using System.ComponentModel.DataAnnotations;

namespace ProVentos.API.Models
{
    public class Paciente
    {
        [Key]
        public int PacienteId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [RegularExpression(@"^\(\d{2}\) \d{4}-\d{4}$", ErrorMessage = "Telefone deve estar no formato (dd) dddd-dddd")]
        public string Telefone { get; set; }

        [Required]
        [StringLength(255)]
        public string Endereco { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inválido, formato esperado: XXX.XXX.XXX-XX")]
        public string CPF { get; set; }

        [Required]
        [StringLength(50)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(50)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(2)]
        public string SiglaEstado { get; set; }

        [Required]
        public DateTime Criacao { get; set; }

        public DateTime? Alteracao { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [StringLength(255)]
        public string Anamnese { get; set; }
    }
}
