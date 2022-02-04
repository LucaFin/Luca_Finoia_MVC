using System.ComponentModel.DataAnnotations;

namespace Luca_Finoia_MVC.MVC.Models
{
    public class UtenteLoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
