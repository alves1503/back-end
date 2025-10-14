using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrenoMvc.Models
{

    [Table("Produtos")]
    public class Produto
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar o nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o preço!")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar a quantidade!")]
        public int Qunatidade { get; set; }


    }
}
