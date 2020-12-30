txtCnpjCpf = $("#txtCnpjCpf").kendoMaskedTextBox({
	mask: "000,000,000-00"
}).data("kendoMaskedTextBox");

txtCep = $("#txtCep").kendoMaskedTextBox({
	mask: "00000-000"
}).data("kendoMaskedTextBox");

txtFone = $("#txtFone").kendoMaskedTextBox({
	mask: "(00) 00000-0000"
}).data("kendoMaskedTextBox");