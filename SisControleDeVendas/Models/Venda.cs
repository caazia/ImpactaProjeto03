using System.ComponentModel.DataAnnotations;

namespace SisControleDeVendas.Models
{
    public class Venda
    {
        public int VendaID { get; set; }

        public int FuncionarioID { get; set; }
        [Display(Name = "Nome do Funcionário")]
        public string? NomeFunc { get; set; }
        public int ClienteID { get; set; }
        [Display(Name = "Nome do Cliente")]
        public string? NomeCliente { get; set; }
        [Display(Name = "Data de Compra")]
        public DateTime DataCompra { get; set; } = DateTime.Now;
        public int ProdutoID { get; set; }
        [Display(Name = "Nome do Produto")]
        public string? NomeProduto { get; set; }
    }
}
