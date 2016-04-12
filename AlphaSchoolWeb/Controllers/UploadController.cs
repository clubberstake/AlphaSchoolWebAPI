﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AlphaSchoolWeb.Model;
using Newtonsoft.Json;


// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaSchoolWeb.Controllers
{
    [Route("api/[controller]")]
    public class UploadController : Controller
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "wrong";
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            var Up = new List<Upload>()
            {
                new Upload()
                {
                    FilePath = "http://localhost:8000/#/studentHomepage"
                }
        };
            return JsonConvert.SerializeObject(Up);
        }
    }
}
