using System.ComponentModel.DataAnnotations;

namespace SisControleDeVendas.Models
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }
        [Display(Name = "Nível de Acesso")]
        public int NivelDeAcesso { get; set; }
        [Required]
        [Display(Name = "Nome do Funcionário")]
        public string? NomeFunc { get; set; }
        public string? CPF { get; set; }
        public string? Telefone { get; set; }
        public string? Cargo { get; set; }

        [Display(Name = "Salário")]
        public decimal Salario { get; set; }

        [Display(Name = "Data de Admissão")]
        public DateTime DtAdmissao { get; set; } = DateTime.Now;

        [Display(Name = "Email")]
        public string? Email { get; set; }
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Máximo de 10, mínimo de 4 caracteres")]
        public string? Senha { get; set; }
        [Display(Name = "Situação")]
        public int Situacao { get; set; }
    }
}
