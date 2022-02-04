using Luca_Finoia_MVC.Core.Entities;
using Luca_Finoia_MVC.Core.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luca_Finoia_MVC.RepositoryEF.RepositoryEF
{
    public class RepositoryMenuEF : IRepositoryMenu
    {
        private readonly MasterContext ctx;

        public RepositoryMenuEF(MasterContext context)
        {
            ctx = context;
        }
        public Menu Add(Menu item)
        {
            ctx.Menu.Add(item);
            ctx.SaveChanges();
            return item;
        }

        public bool Delete(Menu item)
        {
            ctx.Menu.Remove(item);
            ctx.SaveChanges();
            return true;
        }

        public List<Menu> GetAll()
        {
            return ctx.Menu.Include(x=>x.Piatti).ToList();
        }

        public Menu GetMenu(int id)
        {
            return ctx.Menu.Include(x => x.Piatti).FirstOrDefault(x=>x.Id==id);
        }

        public Menu Update(Menu item)
        {
            ctx.Menu.Update(item);
            ctx.SaveChanges();
            return item;
        }
    }
}
