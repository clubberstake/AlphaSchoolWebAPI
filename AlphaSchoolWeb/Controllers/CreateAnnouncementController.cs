﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using AlphaSchoolWeb.Model;
using AlphaSchoolWeb.Request;
using System.Text;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaSchoolWeb.Controllers
{
    [Route("api/[controller]")]
    public class CreateAnnouncementController : Controller
    {
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var courseList = new List<Course>()
            {
                new Course()
                {
                    CourseName = "Math",
                    Grade = 1,
                    ID = "101"
                },
                new Course()
                {
                    CourseName = "English",
                    Grade = 2,
                    ID = "201"
                },
                new Course()
                {
                    CourseName = "Science",
                    Grade = 3,
                    ID = "303"
                }
            };

            return JsonConvert.SerializeObject(courseList);
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]CreateAnnouncementRequest createAnnouncementRequest)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(createAnnouncementRequest.AnnouncementText);
            sb.AppendLine(createAnnouncementRequest.DateTime.ToLocalTime().ToString());
            sb.AppendLine(createAnnouncementRequest.CourseId);
            sb.AppendLine(createAnnouncementRequest.Attachment);
            return sb.ToString();
        }

    }
        
    }

