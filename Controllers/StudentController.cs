
using NguyenVanChien_5951071006.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenVanChien_5951071006.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var weatherInfList = new List<StudentInfo>();



            var weatherInfo = new StudentInfo
            {
                Hoten = "Nguyen Van Chien",
                MaSoSv = "5951071006",
                Lop = "CQ.CNTT.K59",
                NgaySinh = new DateTime(2000, 08, 12)
            };
            weatherInfList.Add(weatherInfo);


            return weatherInfList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                Hoten = "Nguyen Van Chien",
                MaSoSv = "5951071006",
                Lop = "CQ.CNTT.K59",
                NgaySinh = new DateTime(2000, 08, 12)
            };
        }

        // POST: api/Student
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}

