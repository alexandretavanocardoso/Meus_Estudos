

$("#divIcones").kendoSortable({
	filter: ".k-card",
	cursor: "move",
	placeholder: function (element) {
		return element.clone().css("opacity", 0.6);
	},
	hint: function (element) {
		return element.clone().css("width", element.width()).removeClass("k-state-selected");
	}
});