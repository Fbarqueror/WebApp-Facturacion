using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IFacturaService
    {
        Task<DBEntity> Create(FacturaEntity entity);
        Task<DBEntity> Delete(FacturaEntity entity);
        Task<IEnumerable<FacturaEntity>> Get();
        Task<FacturaEntity> GetById(FacturaEntity entity);
        Task<DBEntity> Update(FacturaEntity entity);
    }

    public class FacturaService : IFacturaService
    {
        private readonly IDataAccess sql;

        public FacturaService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<FacturaEntity>> Get()
        {
            try
            {
                
                var result = sql.QueryAsync<FacturaEntity>("FacturaObtener");

                return await result;
            }
            catch (Exception)
            {
                throw;
            }


        }

        //Metodo GetById
        public async Task<FacturaEntity> GetById(FacturaEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<FacturaEntity>("FacturaObtener", new
                { entity.IdFactura });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(FacturaEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("FacturaInsertar", new
                {
                    entity.Cliente,
                    entity.UsuarioRegistro,
                    Detalle=entity.ToDT()

                }); ;

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(FacturaEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("FacturaActualizar", new
                {
                    entity.IdFactura,
                    
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(FacturaEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("FacturaEliminar", new
                {
                    entity.IdFactura,
                });

                return await result;
            }
            catch (Exception)
            {
                throw;
            }

        }

        #endregion
    }
}
