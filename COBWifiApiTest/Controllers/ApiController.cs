using COBWifiApiTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBWifiApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : Controller
    {
        private readonly XirrusDbContext _dbContext;

        public ApiController(XirrusDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            XirrusData data = new XirrusData(_dbContext);
            return Ok(data.GetAll());
        }
    }

    public class XirrusData
    {
        private XirrusDbContext _dBcontext { get; set; }
        public XirrusData(XirrusDbContext context)
        {
            _dBcontext = context;
        }

        public Xirrus Get(string ID)
        {
            return _dBcontext.Xirruss.FirstOrDefault(e => e.id == ID);
        }

        public IEnumerable<Xirrus> GetAll()
        {
            return _dBcontext.Xirruss.ToList<Xirrus>();
        }
    }
}
