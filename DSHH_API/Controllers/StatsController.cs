using DSHH_API.Models;
using DSHH_API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DSHH_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IStatService _service;
        //private readonly DshhContext _context;
        public StatsController(IStatService statService)
        {
            this._service = statService;
        }

        [HttpGet]
        public Stat GetInformation() 
        {
            return this._service.GetStats();
        }
    }
}
