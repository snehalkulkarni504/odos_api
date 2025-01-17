using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO.Compression;
using ODOS.Interfaces;
using ODOS.Models;


namespace ODOS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ODOSController : ControllerBase
    {
        private readonly ILogger<ODOSController> _logger;
        private readonly IODOSInterface _interface;
        public ODOSController(ILogger<ODOSController> logger, IODOSInterface Interface)
        {
            _interface = Interface ?? throw new ArgumentNullException(nameof(Interface));
            this._logger = logger;
        }

        [HttpGet]
        [Route("/Get")]
        public async Task<IActionResult> contractmaster()
        {
            return contractmaster;
        }
    }
}
