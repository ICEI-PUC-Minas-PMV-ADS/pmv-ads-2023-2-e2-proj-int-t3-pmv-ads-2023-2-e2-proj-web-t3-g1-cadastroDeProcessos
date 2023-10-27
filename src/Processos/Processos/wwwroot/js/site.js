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

function foco(o) {
	document.getElementById(o).focus();
}



function PegaValorCB(o) {

	if (document.getElementById(o).checked) {
		return "S";
	} else {
		return "N";
	}

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



function dashboardsetores(SQL, Destino) {


	$.get("/api/processosetor/?SQL=" + SQL, function (data) {

		$("#" + Destino).html(data);

	});



}
function atualizarCampoExibicao(SQL, Destino) {


	$.get("/api/sql/?SQL=" + SQL, function (data) {

			$("#" + Destino).html(data);

	});

	

}

// <a href="        ('SETOR', 'codigoSetor', 'codigoSetorOrigem', 'nome',        'exibicaoCodigoSetorOrigem')">localizar</a>
function speedbutton(tabela,   campoBusca,    campoDestino,        campoExibicao, contenedorCampoExibicao) {


	$("#contenedorSpeedbutton").css("display", "block");

	ultimaURLSpeedButtonSemABusca = "/api/Speedbutton/?Tabela=" + tabela + "&CampoBusca=" + campoBusca + "&CampoDestino=" + campoDestino + "&CampoExibicao=" + campoExibicao + "&ContenedorCampoExibicao=" + contenedorCampoExibicao + "&Busca=%"

	$("#speedbutton").load(ultimaURLSpeedButtonSemABusca + valor("buscaSpeedButton"));

}


function fecharSpeedbutton() {
	$("#contenedorSpeedbutton").css("display", "none");
}


function selecionarSpeedbutton(campoBusca, valorCampoBusca, campoExibicao, valorCampoExibicao) {

	//alert("Setando " + campoBusca + " como " + valorCampoBusca);

	$("#" + campoBusca).val(valorCampoBusca);

	$("#" + campoExibicao).html(valorCampoExibicao);


	$('#buscaSpeedButton').val('');


	$("#contenedorSpeedbutton").css("display", "none");

}


function lista(Rota, Tabela) {

	$("#contenedorBuscaLista").load("/api/Lista/?Rota=" + Rota + "&Tabela=" + Tabela + "&Busca=%" + valor("Busca"));

}


function atualizarSetoresUsuario(cpfUsuario) {

	$("#contenedorSetoresUsuario").load("/api/setoresusuario/?cpfUsuario=" + cpfUsuario);

}

function vincularUsuarioSetor(cpfUsuario, codigoSetor) {

	if (valor("setor_" + codigoSetor) == "S") {

		$.get("/api/setorusuariomanutencao/?cpfUsuario=" + cpfUsuario + "&codigoSetor=" + codigoSetor + "&Acao=Adicionar", function (data) {
			atualizarSetoresUsuario(cpfusuario);
		});

	} else {

		$.get("/api/setorusuariomanutencao/?cpfUsuario=" + cpfUsuario + "&codigoSetor=" + codigoSetor + "&Acao=Remover", function (data) {
			atualizarSetoresUsuario(cpfusuario);
		});

	}

}


function atualizarMovimentacoes(codigoProcesso) {

	$("#contenedorMovimentacao").load("/api/listamovimentacao/?codigoProcesso=" + codigoProcesso);

}


function carregarFluxoProcesso(codigoTipoProcesso) {

	$("#contenedorFluxoProcesso").load("/api/fluxoProcesso/?codigoTipoProcesso=" + codigoTipoProcesso);

}

function entrar() {

	if (valor("cpfUsuario") == "") {

		foco("cpfUsuario");
		return;

	}

	if (valor("senha") == "") {

		foco("senha");
		return;

	}



	$.get("/api/login/?cpfUsuario=" + valor("cpfUsuario") + "&senha=" + valor("senha"), function (data) {

		if (data.startsWith("001 - ")) {
			document.location = "/";
		} else {

			$("#lsi").html("Par login / senha inválidos");

		}


	});

}

function sair() {

	$.get("/api/sair/", function (data) {
		document.location = "/";
	});

}


function consultarProcesso() {

	$("#contenedorConsultaPublica").load("/api/consultapublica/?cpfCnpjInteressado=" + valor("cpfCnpjInteressado") + "&codigoProcesso=" + valor("codigoProcesso"));


}