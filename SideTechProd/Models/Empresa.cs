using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SideTechProd.Models
{
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [DisplayName("Nome Fantasia")]
        public string NomeFantasia { get; set; }
        [Column(TypeName = "nvarchar(18)")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }
    }
}
