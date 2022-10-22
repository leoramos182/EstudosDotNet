using System.ComponentModel.DataAnnotations;

namespace estudos.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Este camp odeve conter entre 3 e 60 caracteres")]
        [MaxLength(60, ErrorMessage = "Este camp odeve conter entre 3 e 60 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Este camp odeve conter entre 3 e 60 caracteres")]
        [MaxLength(60, ErrorMessage = "Este camp odeve conter entre 3 e 60 caracteres")]
        public string Password { get; set; }

        public string Role { get; set; }


    }
}
