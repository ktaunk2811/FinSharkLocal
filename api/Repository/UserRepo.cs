using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ApplicationDBContext _context;

        public UserRepo(ApplicationDBContext context)
        {
            _context = context;
        }

        public List<AppUser> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}
