﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartVisitor.Repositories;

namespace SmartVisitorApi.Controllers
{
    public class WarehouseController : BaseControler
    {
        [Produces("application/json")]
        [HttpPost("[action]/{IMEI}")]
        public IActionResult Get(String IMEI)
        {
            try
            {
                WarehouseRepository Rep = new WarehouseRepository(IMEI);
                var Result = Rep.Get();
                return Ok(Result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
