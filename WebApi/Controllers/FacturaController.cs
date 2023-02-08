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
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaService FacturaService;

        public FacturaController(IFacturaService FacturaService)
        {
            this.FacturaService = FacturaService;
        }

        [HttpGet]
        public async Task<IEnumerable<FacturaEntity>> Get()
        {
            try
            {
                return await FacturaService.Get();
            }
            catch (Exception ex)
            {

                return new List<FacturaEntity>();
            }       
        
        
        }

        [HttpGet("{id}")]
        public async Task<FacturaEntity> Get(int id)
        {
            try
            {
                return await FacturaService.GetById( new FacturaEntity { IdFactura = id});
            }
            catch (Exception ex)
            {

                return new FacturaEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }


        [HttpPost]
        public async Task<DBEntity> Create([FromBody]FacturaEntity entity)
        {
            try
            {
                return await FacturaService.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }


       




    }
}
