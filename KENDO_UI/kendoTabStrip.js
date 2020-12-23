

$("#tabstrip").kendoTabStrip({
	animation: {
		open: {
			effects: "fadeIn"
		}
	},
	activate: function () {
		$("#timelinePrincipal").data("kendoGantt").view("year");
	}
});