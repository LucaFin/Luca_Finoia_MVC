using System.ComponentModel.DataAnnotations;

namespace Luca_Finoia_MVC.MVC.Models
{
    public class MenuViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<PiattoViewModel>? Piatti { get; set; }
    }
}
