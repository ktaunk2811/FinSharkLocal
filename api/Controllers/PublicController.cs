using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/public")]
    public class PublicController: ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserRepo _userRepo;

        public PublicController(UserManager<AppUser> userManager,IUserRepo userRepo) {
            _userManager = userManager;
            _userRepo = userRepo;
        }
        [HttpGet]
        public string HealthCheck()
        {
            return "OK";
        }

        [HttpGet("allusers")]
        public IActionResult GetAllUsers()
        {
            var users = _userRepo.GetAll();
            var alluserdto = users.Select(c => c.UsertoAllUserDto());

            if(users== null || users.Count == 0)
                return NotFound();
            return Ok(alluserdto);

        }

    }
}
