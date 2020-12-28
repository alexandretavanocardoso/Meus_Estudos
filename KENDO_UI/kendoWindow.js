divPopupEditar = $("#divPopupEditar").kendoWindow({
	actions: ["Close"],
	draggable: true,
	modal: true,
	resizable: false,
	title: "Editar Cliente",
	width: 400,
	height: 150,
	visible: false
}).data("kendoWindow").center();


$("#divPopupExcluir").data("kendoWindow").center().toFront();
$("#divPopupExcluir").data("kendoWindow").open();
$("#divPopupExcluir").data("kendoWindow").close();