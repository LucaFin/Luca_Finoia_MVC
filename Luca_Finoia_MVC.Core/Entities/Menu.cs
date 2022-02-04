using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luca_Finoia_MVC.Core.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Piatto> Piatti { get; set; }
    }
}
