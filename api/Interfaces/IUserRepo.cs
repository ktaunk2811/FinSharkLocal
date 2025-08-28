using api.Models;

namespace api.Interfaces
{
    public interface IUserRepo
    {
        public List<AppUser> GetAll();
    }
}
