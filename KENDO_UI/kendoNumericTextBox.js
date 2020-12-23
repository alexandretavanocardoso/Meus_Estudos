

txtLatitude = $("#txtLatitude").kendoNumericTextBox({
	decimals: 8,
	min: 0,
	format: "n8",
	spinners: false,
	value: (dataItem != null ? dataItem.Latitude : null)
}).data("kendoNumericTextBox");