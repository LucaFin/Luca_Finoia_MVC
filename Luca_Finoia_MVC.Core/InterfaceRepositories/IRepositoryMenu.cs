using Luca_Finoia_MVC.Core.Entities;

namespace Luca_Finoia_MVC.Core.InterfaceRepositories
{
    public interface IRepositoryMenu:IRepository<Menu>
    {
        public Menu GetMenu(int id);
    }
}