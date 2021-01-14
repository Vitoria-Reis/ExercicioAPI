using System.ComponentModel.DataAnnotations;

namespace exercicio.Models
{
    public class Product
    {
        [Key]
        public int Id { get {return Id;} private set{ } }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 1 e 3 caracteres")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Este campo deve conter no maximo 1024 caracteres")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Este campo e obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O preco deve ser maior que zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria invalida")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}