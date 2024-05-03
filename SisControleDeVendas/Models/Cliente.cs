using System.ComponentModel.DataAnnotations;

namespace SisControleDeVendas.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        [Display(Name = "Nível de Acesso")]
        public int NivelDeAcesso { get; set; }

        [Required]
        [Display(Name = "Nome do Cliente")]
        public string? NomeCliente { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string? Telefone { get; set; }
        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }

        [StringLength(8, MinimumLength = 8, ErrorMessage = "O CEP é composto por 8 algarismos.")]
        [DataType(DataType.PostalCode)]
        public string? CEP { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string? Email { get; set; }
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Máximo de 10, mínimo de 4 caracteres")]
        [Display(Name = "Senha")]
        public string? Senha { get; set; }
        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        public DateTime DtCad { get; set; } = DateTime.Now;
        [Display(Name = "Situação")]
        public int Situacao { get; set; }
    }
}
