using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartVisitor.Entities.Customer;
using SmartVisitor.Repositories;

namespace SmartVisitorApi.Controllers
{
    public class CustomerTypeController : BaseControler
    {
        [Produces("application/json")]
        [HttpPost("[action]")]
        public IActionResult Get()
        {

            try
            {
                CustomerTypeRepository Rep = new CustomerTypeRepository();
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
