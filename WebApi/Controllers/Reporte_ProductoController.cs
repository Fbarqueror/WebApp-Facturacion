using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;
using Entity;
namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Reporte_ProductoController : ControllerBase
    {
        private readonly IReporte_ProductoService Reporte_ProductoService;

        public Reporte_ProductoController(IReporte_ProductoService Reporte_ProductoService)
        {
            this.Reporte_ProductoService = Reporte_ProductoService;
        }

        [HttpGet]
        public async Task<IEnumerable<Reporte_ProductoEntity>> Get()
        {
            try
            {
                return await Reporte_ProductoService.Get();
            }
            catch (Exception ex)
            {

                return new List<Reporte_ProductoEntity>();
            }       
        
        
        }

        [HttpGet("{id}")]
        public async Task<Reporte_ProductoEntity> Get(int id)
        {
            try
            {
                return await Reporte_ProductoService.GetById( new Reporte_ProductoEntity { IdProducto = id});
            }
            catch (Exception ex)
            {

                return new Reporte_ProductoEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }


      



    }
}
