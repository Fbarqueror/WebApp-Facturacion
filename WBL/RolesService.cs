using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
    public interface IRolesService
    {
        Task<DBEntity> Create(RolesEntity entity);
        Task<DBEntity> Delete(RolesEntity entity);
        Task<IEnumerable<RolesEntity>> Get();
        Task<RolesEntity> GetById(RolesEntity entity);
        Task<DBEntity> Update(RolesEntity entity);

        Task<IEnumerable<RolesEntity>> GetLista();
    }

    public class RolesService : IRolesService
    {
        private readonly IDataAccess sql;

        public RolesService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<RolesEntity>> Get()
        {
            try
            {

                var result = sql.QueryAsync<RolesEntity>("RolesObtener");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<RolesEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<RolesEntity>("RolesObtener");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<RolesEntity> GetById(RolesEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<RolesEntity>("RolesObtener", new
                { entity.IdRoles });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(RolesEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("RolesInsertar", new
                {
                    entity.Nombre,
                    entity.Menu_Productos,
                    entity.Menu_Usuarios,
                    entity.Menu_Roles,
                    entity.Menu_Bitacoras,

                    entity.Actualizar_Productos,
                    entity.Actualizar_Usuarios,
                    entity.Actualizar_Roles,

                    entity.Eliminar_Productos,
                    entity.Eliminar_Usuarios,
                    entity.Eliminar_Roles,

                    entity.UsuarioRegistro
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(RolesEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("RolesActualizar", new
                {
                    entity.IdRoles,
                    entity.Nombre,
                    entity.Menu_Productos,
                    entity.Menu_Usuarios,
                    entity.Menu_Roles,
                    entity.Menu_Bitacoras,

                    entity.Actualizar_Productos,
                    entity.Actualizar_Usuarios,
                    entity.Actualizar_Roles,

                    entity.Eliminar_Productos,
                    entity.Eliminar_Usuarios,
                    entity.Eliminar_Roles,

                    entity.UsuarioRegistro
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(RolesEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("RolesEliminar", new
                {
                    entity.IdRoles,
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
