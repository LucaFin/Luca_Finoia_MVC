using Luca_Finoia_MVC.Core.Entities;

namespace Luca_Finoia_MVC.Core.InterfaceRepositories
{
    public interface IRepositoryUtenti:IRepository<Utente>
    {
        public Utente GetByUsername(string username);
    }
}