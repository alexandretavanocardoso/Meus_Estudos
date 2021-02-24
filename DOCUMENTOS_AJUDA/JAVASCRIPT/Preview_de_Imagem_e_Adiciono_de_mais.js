<script>
	function readURL(input) {
		if (input.files && input.files[0]) {
			var reader = new FileReader();

			reader.onload = function (e) {
				var id = recuperarGuid();

				var divImagem = `
				  <div style="margin-left:12px; margin-top:12px; float:left;">
					   <img id="previewImagemLeitura_`+ id + `" width="170" height="150" src="` + e.target.result + `" /><br />
					   <div style="margin-top: 5px;"><a href="javascript:void(0)" onclick="onclick_RemoverImagem('`+ id + `')"><i class="fas fa-minus-square" style="font-size: 18px;"></i></a></div>
				 </div>`;


				$("#divImagens").append(divImagem);
			}

			reader.readAsDataURL(input.files[0]);
		}
	}

	$("#adicionarImagem").click(function () {
		$("#fileImagem").click();
	});

	$("#fileImagem").change(function () {
		readURL(this);
	});

	function onclick_RemoverImagem(id) {         
		$("#previewImagemLeitura_" + id).closest("div").remove(); 
		$('input[type=file]').val("");
	}
</script>