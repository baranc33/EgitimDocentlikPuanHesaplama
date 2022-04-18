using WebMvc.Models;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Core.Serviecs;

namespace WebMvc.Controllers
{
    public class AdminController : BaseController
    {

        private readonly IMessageService _myMessageService;

        public AdminController(UserManager<MyUser> userManager, RoleManager<MyRole> roleManager, IMessageService myMessageService) : base(userManager, null, roleManager)
        {
            _myMessageService=myMessageService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }










        [HttpGet]
        [Authorize(Roles = "UltraAdmin")]
        public IActionResult Message()
        {
            IQueryable<MyMessage> list = _myMessageService.Where(x => x.Description.Length>1).OrderByDescending(x => x.Id);

            return View(list);
        }

        [HttpGet]
        [Authorize(Roles = "UltraAdmin")]
        public async Task<IActionResult> MessageUpdate(string id)
        {
            IEnumerable<MyMessage> list = await _myMessageService.GetAllAsync();

            return View(list);
        }
    }
}
