function PegaValorDoListbox(obj) {
	try {
		var Item_Selecionado = document.getElementById(obj).selectedIndex;
		if (Item_Selecionado != -1)
			return document.getElementById(obj).options[Item_Selecionado].value;
		else
			return false;
	} catch (err) {
		alert("Erro ao pegar valor do objeto " + obj + ": " + err.message);
	}
	return false;
}


function valor(o) {

	if (document.getElementById(o) != null) {
		var Tipo = document.getElementById(o).tagName;

		if (Tipo == "INPUT") {
			var SubTipo = document.getElementById(o).type;

			if (SubTipo == "checkbox") {
				return PegaValorCB(o);
			}
			if (SubTipo == "text") {
				return document.getElementById(o).value;
			}
			if (SubTipo == "number") {
				return document.getElementById(o).value;
			}

			if (SubTipo == "range") {
				return document.getElementById(o).value;
			}

			if (SubTipo == "password") {
				return document.getElementById(o).value;
			}

			if (SubTipo == "hidden") {
				if (document.getElementById(o).value == "_fw_botao_radio")
					return PegaValorRB(o);
				else
					return document.getElementById(o).value;
			}
		}

		if (Tipo == "SELECT") {
			return PegaValorDoListbox(o);
		}

		if (Tipo == "TEXTAREA") {
			return document.getElementById(o).value;
		}

		if (Tipo == "SPAN")
			return "";



		alert("Objeto " + o + " não encontrado!" + Tipo);

	}
}


function atualizarCampoExibicao() {



}

// <a href="        ('SETOR', 'codigoSetor', 'codigoSetorOrigem', 'nome',        'exibicaoCodigoSetorOrigem')">localizar</a>
function speedbutton(tabela,   campoBusca,    campoDestino,        campoExibicao, contenedorCampoExibicao) {

	$("#contenedorSpeedbutton").css("display", "block");

	ultimaURLSpeedButtonSemABusca = "/api/Speedbutton/?Tabela=" + tabela + "&CampoBusca=" + campoBusca + "&CampoDestino=" + campoDestino + "&CampoExibicao=" + campoExibicao + "&ContenedorCampoExibicao=" + contenedorCampoExibicao + "&Busca=%"

	$("#speedbutton").load(ultimaURLSpeedButtonSemABusca + valor("buscaSpeedButton"));

}

function selecionarSpeedbutton(campoBusca, valorCampoBusca, campoExibicao, valorCampoExibicao) {

	//alert("Setando " + campoBusca + " como " + valorCampoBusca);

	$("#" + campoBusca).val(valorCampoBusca);

	$("#" + campoExibicao).html(valorCampoExibicao);


	$("#contenedorSpeedbutton").css("display", "none");

}


function lista(Rota, Tabela) {

	$("#contenedorBuscaLista").load("/api/Lista/?Rota=" + Rota + "&Tabela=" + Tabela + "&Busca=%" + valor("Busca"));

}


