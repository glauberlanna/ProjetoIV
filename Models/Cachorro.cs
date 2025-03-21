using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_jcm_g3_eixo_4_2025_1.Models
{
    [Table("Cachorros")]
    public class Cachorro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do cachorro!")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data de nascimento do cachorro!")]
        [Display(Name = "Nascimento")]
        public int Nascimento { get; set; }

        [Display(Name = "Raça")]
        public string Raca { get; set; }

        public ICollection<Alimentacao> Alimentacoes { get; set; }

    }
}
