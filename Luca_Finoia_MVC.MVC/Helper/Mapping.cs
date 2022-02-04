using Luca_Finoia_MVC.Core.Entities;
using Luca_Finoia_MVC.MVC.Models;

namespace Luca_Finoia_MVC.MVC.Helper
{
    public static class Mapping
    {
        public static MenuViewModel ToMenuViewModel(this Menu menu)
        {
            List<PiattoViewModel> piattoViewModels = new List<PiattoViewModel>();
            foreach(var item in menu.Piatti)
            {
                piattoViewModels.Add(item?.ToPiattoViewModel());
            }
            return new MenuViewModel
            {
                Id = menu.Id,
                Name = menu.Name,
                Piatti = piattoViewModels
            };
        }

        public static Menu ToMenu(this MenuViewModel menu)
        {
            List<Piatto> piatti = new List<Piatto>();
            if (menu.Piatti != null)
            {
                foreach (var item in menu.Piatti)
                {
                    piatti.Add(item?.ToPiatto());
                }
            }
            return new Menu
            {
                Id = menu.Id,
                Name = menu.Name,
                Piatti = piatti
            };
        }

        public static PiattoViewModel ToPiattoViewModel(this Piatto piatto)
        {
            return new PiattoViewModel
            {
                Id = piatto.Id,
                Name = piatto.Name,
                Descrizione = piatto.Descrizione,
                Tipologia = piatto.Tipologia,
                Prezzo = piatto.Prezzo,
                IdMenu = piatto.IdMenu,
            };
        }

        public static Piatto ToPiatto(this PiattoViewModel piatto)
        {
            return new Piatto
            {
                Id = piatto.Id,
                Name = piatto.Name,
                Descrizione = piatto.Descrizione,
                Tipologia = piatto.Tipologia,
                Prezzo = piatto.Prezzo,
                IdMenu = piatto.IdMenu,
            };
        }
    }
}
