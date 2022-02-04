using Luca_Finoia_MVC.Core.Entities;

namespace Luca_Finoia_MVC.Core.InterfaceRepositories { 
    public interface IRepositoryPiatti:IRepository<Piatto>
    {
        public Piatto GetPiatto(int id);
    }
}