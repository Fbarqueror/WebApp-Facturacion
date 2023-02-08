using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
    public interface IReporte_ProductoService
    {
      
        Task<IEnumerable<Reporte_ProductoEntity>> Get();
        Task<Reporte_ProductoEntity> GetById(Reporte_ProductoEntity entity);
     

        Task<IEnumerable<Reporte_ProductoEntity>> GetLista();
    }

    public class Reporte_ProductoService : IReporte_ProductoService
    {
        private readonly IDataAccess sql;

        public Reporte_ProductoService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<Reporte_ProductoEntity>> Get()
        {
            try
            {

                var result = sql.QueryAsync<Reporte_ProductoEntity>("Reporte_ProductoObtener");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<Reporte_ProductoEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<Reporte_ProductoEntity>("Reporte_ProductoObtener");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<Reporte_ProductoEntity> GetById(Reporte_ProductoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<Reporte_ProductoEntity>("Reporte_ProductoObtener", new
                { entity.IdProducto });

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
