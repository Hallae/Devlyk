using Devlyk.Data;
using Microsoft.AspNetCore.Mvc;

namespace Devlyk.Controllers
{

    [Route("/[controller")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class DevlykerzController: ControllerBase
    {
        private readonly DataContext _context;


        public DevlykerzController(DataContext context)
        {
            _context = context;
        }



    }
}
