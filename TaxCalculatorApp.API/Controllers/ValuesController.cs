﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaxCalculatorApp.API.Data;

namespace TaxCalculatorApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController (DataContext context)
        {
            _context = context;

        }

       // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues ()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet ("{id}")]
        public async Task<IActionResult> GetValue (int id) {
            var value = await _context.Values.FirstOrDefaultAsync(v => v.Id == id);
            return Ok(value);
        }
        
    }
}
