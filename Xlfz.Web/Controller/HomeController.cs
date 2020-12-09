using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Xlfz.Data;

namespace Xlfz.Web.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly XlfzContext _db;

        public HomeController(XlfzContext db)
        {
            this._db = db;
        }

        [HttpGet]
        public string Index() {
            string name = _db.League.Where(x=> x.Id>0).FirstOrDefault().Name;
            return name;
            }
    }
}
