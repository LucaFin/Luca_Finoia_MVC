using Luca_Finoia_MVC.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Luca_Finoia_MVC.MVC.Models
{
    public class PiattoViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Descrizione { get; set; }

        [Required]
        public Tipologia Tipologia { get; set; }

        [Required]
        public double Prezzo { get; set; }
        public int? IdMenu { get; set; }
        public Menu? Menu { get; set; }
    }
}
