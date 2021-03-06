﻿using ApiNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiNetCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CodeController : ControllerBase
    {
        //Variável com o endereço onde está o fonte no github
        public readonly String _url = "https://github.com/claitonamaral/ApiNetCore";

        // GET: showmethecode
        [HttpGet("showmethecode")]
        public String GetShowMeTheCode()
        {
            Code code = new Code();
            code.url = _url;
            return code.url;
        }
    }
}
