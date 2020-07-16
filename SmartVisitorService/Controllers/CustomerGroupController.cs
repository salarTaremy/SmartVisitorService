using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SmartVisitor.Entities.Customer;
using SmartVisitor.Repositories;

namespace SmartVisitorApi.Controllers
{
    public class CustomerGroupController : BaseControler
    {
        [Produces("application/json")]
        [HttpPost("[action]")]
        public IActionResult Get()
        {
            try
            {
                CustomerGroupRepository Rep = new CustomerGroupRepository();
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
