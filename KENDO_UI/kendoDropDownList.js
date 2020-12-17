cmbTesteIniciativa = $("#cmbTesteIniciativa").kendoDropDownList({
	optionLabel: "Selecione o Teste",
	dataTextField: "descricao",
	dataValueField: "codigo",
	filter: "contains",
	dataSource: {
		schema: {
			data: "Data",
			model: {
				id: "codigo"
			}
		},
		transport: {
			read: {
				url: "../../adm/servicos/workflowServico.svc/RecuperarTipoIniciativaCombo",
				contentType: "application/json; charset=utf-8",
				dataType: "jsonp",
				type: "POST"
			}
		}
	}
}).data("kendoDropDownList");