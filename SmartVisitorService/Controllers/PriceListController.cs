using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartVisitor.Repositories;

namespace SmartVisitorApi.Controllers
{
    public class PriceListController : BaseControler
    {
        [Produces("application/json")]
        [HttpPost("[action]/{IMEI}")]
        public IActionResult Get( string IMEI)
        {
            try
            {
                PriceListRepository Rep = new PriceListRepository(IMEI);
                var Result = Rep.Get();
                return Ok(Result);
            }
            catch (Exception e)
            {
                return BadRequest( e);
            }
        }
    }
}
