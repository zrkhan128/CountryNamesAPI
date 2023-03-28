using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryNamesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        private static readonly List<Country> Coutries = new List<Country>
        {
           new Country{ Name="South Africa", Population=46112313}, new Country{ Name="Norway", Population=545121}   
        };

        private readonly ILogger<CountryController> _logger;

        public CountryController(ILogger<CountryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return Coutries;
        }
    }
}
