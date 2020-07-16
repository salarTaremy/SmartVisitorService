using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartVisitor.Repositories;

namespace SmartVisitorApi.Controllers
{
    public class ProductGroupController : BaseControler
    {
        [Produces("application/json")]
        [HttpPost("[action]")]
        public IActionResult Get()
        {
            try
            {
                ProductGroupRepository Rep = new ProductGroupRepository();
                var result = Rep.Get();
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
    }
}
