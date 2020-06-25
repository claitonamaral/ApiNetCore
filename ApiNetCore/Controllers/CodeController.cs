using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ApiNetCore.Models;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiNetCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CodeController : ControllerBase
    {
        // GET: showmethecode
        [HttpGet("showmethecode")]
        public String GetShowMeTheCode()
        {
            return "";   
        }
    }
}
