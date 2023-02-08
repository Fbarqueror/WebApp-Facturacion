"use strict";
var Reporte_ProductoGrid;
(function (Reporte_ProductoGrid) {
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar el registro?", "Eliminar", "warning", "#3085d6", "d33")
            .then(function (result) {
            if (result.isConfirmed) {
                Loading.fire("Borrando...");
                App.AxiosProvider.Reporte_ProductoEliminar(id).then(function (data) {
                    Loading.close();
                    if (data.CodeError == 0) {
                        Toast.fire({ title: "Se elimino correctamente", icon: "success" }).then(function () { return window.location.reload(); });
                    }
                    else {
                        Toast.fire({ title: data.MsgError, icon: "error" });
                    }
                });
            }
        });
    }
    Reporte_ProductoGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(Reporte_ProductoGrid || (Reporte_ProductoGrid = {}));
//# sourceMappingURL=Grid.js.map