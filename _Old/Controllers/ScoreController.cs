using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PostgresSampleApp.Controllers
{
    [Route("api")]
    public class ScoreController : Controller
    {
        public string Index()
        {
            return View();
        }

    }
}
