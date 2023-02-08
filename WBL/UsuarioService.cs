using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
    public interface IUsuarioService
    {
        Task<DBEntity> Create(UsuarioEntity entity);
        Task<DBEntity> Delete(UsuarioEntity entity);
        Task<IEnumerable<UsuarioEntity>> Get();
        Task<UsuarioEntity> GetById(UsuarioEntity entity);
        Task<DBEntity> Update(UsuarioEntity entity);

        Task<IEnumerable<UsuarioEntity>> GetLista();
    }

    public class UsuarioService : IUsuarioService
    {
        private readonly IDataAccess sql;

        public UsuarioService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<UsuarioEntity>> Get()
        {
            try
            {

                var result = sql.QueryAsync<UsuarioEntity>("UsuarioObtener");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<UsuarioEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<UsuarioEntity>("UsuarioObtener");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<UsuarioEntity> GetById(UsuarioEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<UsuarioEntity>("UsuarioObtener", new
                { entity.IdUsuario });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(UsuarioEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("UsuarioInsertar", new
                {
                    entity.Usuario,
                    entity.Nombre,
                    entity.Contrasena,
                    entity.Rol,
                    entity.Estado,
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
        public async Task<DBEntity> Update(UsuarioEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("UsuarioActualizar", new
                {
                    entity.IdUsuario,
                    entity.Usuario,
                    entity.Nombre,
                    entity.Contrasena,
                    entity.Rol,
                    entity.Estado,
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
        public async Task<DBEntity> Delete(UsuarioEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("UsuarioEliminar", new
                {
                    entity.IdUsuario,
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
