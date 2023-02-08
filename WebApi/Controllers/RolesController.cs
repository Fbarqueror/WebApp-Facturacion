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
    public class RolesController : ControllerBase
    {
        private readonly IRolesService RolesService;

        public RolesController(IRolesService RolesService)
        {
            this.RolesService = RolesService;
        }

        [HttpGet]
        public async Task<IEnumerable<RolesEntity>> Get()
        {
            try
            {
                return await RolesService.Get();
            }
            catch (Exception ex)
            {

                return new List<RolesEntity>();
            }       
        
        
        }

        [HttpGet("{id}")]
        public async Task<RolesEntity> Get(int id)
        {
            try
            {
                return await RolesService.GetById( new RolesEntity { IdRoles = id});
            }
            catch (Exception ex)
            {

                return new RolesEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }


        [HttpPost]
        public async Task<DBEntity> Create(RolesEntity entity)
        {
            try
            {
                return await RolesService.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }


        [HttpPut]
        public async Task<DBEntity> Update(RolesEntity entity)
        {
            try
            {
                return await RolesService.Update(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpDelete("{id}")]
        public async Task<DBEntity> Delete(int id)
        {
            try
            {
                return await RolesService.Delete(new RolesEntity() { IdRoles = id });
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }





    }
}
