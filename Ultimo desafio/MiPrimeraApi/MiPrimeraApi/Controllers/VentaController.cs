﻿using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.Controllers.DTOS;
using MiPrimeraApi.Model;
using MiPrimeraApi.Repository;
namespace MiPrimeraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VentaController : ControllerBase
    {
        [HttpPut]
        public bool CargarVenta([FromBody] PostVenta Venta) {
            return VentaHandler.CargarVenta(new Venta
            {
                Id = Venta.Id,
            }); 
        }
        
        
           
        
    }

}
