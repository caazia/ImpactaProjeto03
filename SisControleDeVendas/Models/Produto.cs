using System.ComponentModel.DataAnnotations;

namespace SisControleDeVendas.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        [Display(Name = "Nome do Produto")]
        [Required]
        public string? NomeProduto { get; set; }
        public string? Categoria { get; set; }
        public string? Fornecedor { get; set; }
        public int Quantidade { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
    }
}
