using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartVisitor.Repositories;

namespace SmartVisitorApi.Controllers
{
    public class ProductBrandController : BaseControler
    {
        [Produces("application/json")]
        [HttpPost("[action]")]
        public IActionResult Get()
        {
            try
            {
                ProductBrandRepository Rep = new ProductBrandRepository();
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
