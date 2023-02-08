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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService UsuarioService;

        public UsuarioController(IUsuarioService UsuarioService)
        {
            this.UsuarioService = UsuarioService;
        }

        [HttpGet]
        public async Task<IEnumerable<UsuarioEntity>> Get()
        {
            try
            {
                return await UsuarioService.Get();
            }
            catch (Exception ex)
            {

                return new List<UsuarioEntity>();
            }       
        
        
        }

        [HttpGet("{id}")]
        public async Task<UsuarioEntity> Get(int id)
        {
            try
            {
                return await UsuarioService.GetById( new UsuarioEntity { IdUsuario = id});
            }
            catch (Exception ex)
            {

                return new UsuarioEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }


        [HttpPost]
        public async Task<DBEntity> Create(UsuarioEntity entity)
        {
            try
            {
                return await UsuarioService.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }


        [HttpPut]
        public async Task<DBEntity> Update(UsuarioEntity entity)
        {
            try
            {
                return await UsuarioService.Update(entity);
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
                return await UsuarioService.Delete(new UsuarioEntity() { IdUsuario = id });
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }





    }
}
