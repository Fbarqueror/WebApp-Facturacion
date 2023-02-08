"use strict";
var FacturaGrid;
(function (FacturaGrid) {
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar el registro?", "Eliminar", "warning", "#3085d6", "d33")
            .then(function (result) {
            if (result.isConfirmed) {
                Loading.fire("Borrando");
                App.AxiosProvider.FacturaEliminar(id).then(function (data) {
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
    FacturaGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(FacturaGrid || (FacturaGrid = {}));
//# sourceMappingURL=Grid.js.map