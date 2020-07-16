using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartVisitorApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BaseControler: Controller 
    {
        public BaseControler()
        {

        }
    }
}
