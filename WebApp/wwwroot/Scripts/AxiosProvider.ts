
namespace App.AxiosProvider   {

   
    
    export const ProductoEliminar = (id) => ServiceApi.delete<DBEntity>("api/Producto/" + id).then(({ data }) => data);
    export const ProductoGuardar = (entity) => ServiceApi.post<DBEntity>("api/Producto", entity).then(({ data }) => data);
    export const ProductoActualizar = (entity) => ServiceApi.put<DBEntity>("api/Producto", entity).then(({ data }) => data);

    export const RolesEliminar = (id) => ServiceApi.delete<DBEntity>("api/Roles/" + id).then(({ data }) => data);
    export const RolesGuardar = (entity) => ServiceApi.post<DBEntity>("api/Roles", entity).then(({ data }) => data);
    export const RolesActualizar = (entity) => ServiceApi.put<DBEntity>("api/Roles", entity).then(({ data }) => data);


    export const FacturaGuardar = (entity) => ServiceApi.post<DBEntity>("api/Factura", entity).then(({ data }) => data);
    export const FacturaEliminar = (id) => ServiceApi.delete<DBEntity>("api/Factura/" + id).then(({ data }) => data);
    export const FacturaActualizar = (entity) => ServiceApi.put<DBEntity>("api/Factura", entity).then(({ data }) => data);

    export const UsuarioEliminar = (id) => ServiceApi.delete<DBEntity>("api/Usuario/" + id).then(({ data }) => data);
    export const UsuarioGuardar = (entity) => ServiceApi.post<DBEntity>("api/Usuario", entity).then(({ data }) => data);
    export const UsuarioActualizar = (entity) => ServiceApi.put<DBEntity>("api/Usuario", entity).then(({ data }) => data);

    export const Reporte_ProductoEliminar = (id) => ServiceApi.delete<DBEntity>("api/Reporte_Producto/" + id).then(({ data }) => data);
    export const Reporte_ProductoGuardar = (entity) => ServiceApi.post<DBEntity>("api/Reporte_Producto", entity).then(({ data }) => data);
    export const Reporte_ProductoActualizar = (entity) => ServiceApi.put<DBEntity>("api/Reporte_Producto", entity).then(({ data }) => data);

    export const UsuarioRegistrar = (entity) => ServiceApi.post<DBEntity>("api/Usuarios/Registrar", entity).then(({ data }) => data);
    export const UsuarioLogin = (entity) => axios.post<DBEntity>("Login", entity).then(({ data }) => data);


}




