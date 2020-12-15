USE [TRIPPER_UPPER_BD]
GO
/****** Object:  StoredProcedure [dbo].[ProcRecuperarCadastroServico]    Script Date: 24/11/2020 17:04:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ProcRecuperarCadastroServico]
(
  @UsuarioId          INT=NULL, 
  @EmpresaId   INT=NULL,
  @Filtro VARCHAR=NULL
)
AS
BEGIN

    SELECT    AC.AtividadeCategoriaId,
            AC.AtividadeGrupoId, 
            AG.AtividadeGrupo, 
            AC.EmpresaId, 
            E.Empresa,
            AC.ProjetoId ,
            P.Projeto,
            AC.DocumentoFluxoId ,
            DF.DocumentoFluxo,
            AC.SolicitanteTipoId ,
            ST.SolicitanteTipo, 
            AC.ServicoContratoId,
            SC.ServicoContrato,
            AC.AtividadeValidacaoTipoId, 
            AVT.AtividadeValidacaoTipo,
            AC.AtividadeClassificacaoId,
            ACL.AtividadeClassificacao,
            AC.AtividadeCategoria,
            AC.AtividadeCategoriaSigla,

            AC.UsuarioAtendimento,
			CASE
				WHEN AC.UsuarioAtendimento = 0 THEN 'Não'
				ELSE 'Sim'
			END as UsuarioAtendimentoTexto,
            AC.Visitante,
			CASE
				WHEN AC.Visitante = 0 THEN 'Não'
				ELSE 'Sim'
			END as VisitanteTexto,
            AC.Endereco,
			CASE
				WHEN AC.Endereco = 0 THEN 'Não'
				ELSE 'Sim'
			END as EnderecoTexto,
            AC.EnderecoGeral,
			CASE
				WHEN AC.EnderecoGeral = 0 THEN 'Não'
				ELSE 'Sim'
			END as EnderecoGeralTexto,
            AC.Item,
			CASE
				WHEN AC.Item = 0 THEN 'Não'
				ELSE 'Sim'
			END as ItemTexto,
            AC.Ativo,
			CASE
				WHEN AC.Ativo = 0 THEN 'Não'
				ELSE 'Sim'
			END as AtivoTexto,
            AC.EditarDataAberturaFechamento,
			CASE
				WHEN AC.EditarDataAberturaFechamento = 0 THEN 'Não'
				ELSE 'Sim'
			END as EditarDataAberturaFechamentotexto,
            AC.EncerrarPorSolicitante,
			CASE
				WHEN AC.EncerrarPorSolicitante = 0 THEN 'Não'
				ELSE 'Sim'
			END as EncerrarPorSolicitanteTexto,
            AC.GuiaItemOS,
			CASE
				WHEN AC.GuiaItemOS = 0 THEN 'Não'
				ELSE 'Sim'
			END as GuiaItemOSTexto,
            AC.GuiaAcao,
			CASE
				WHEN AC.GuiaAcao = 0 THEN 'Não'
				ELSE 'Sim'
			END as GuiaAcaoTexto,
            AC.GuiaCobranca,
			CASE
				WHEN AC.GuiaCobranca = 0 THEN 'Não'
				ELSE 'Sim'
			END as GuiaCobrancaoTexto,
            AC.GuiaItem,
			CASE
				WHEN AC.GuiaItem = 0 THEN 'Não'
				ELSE 'Sim'
			END as GuiaItemTexto,
            AC.GuiaOutroItem,
			CASE
				WHEN AC.GuiaOutroItem = 0 THEN 'Não'
				ELSE 'Sim'
			END as GuiaOutroItemTexto,
            AC.GuiaTarefa,
			CASE 
				WHEN AC.GuiaTarefa = 0 THEN 'Nâo'
				ELSE 'Sim'
			END as GuiaTarefaTexto,
            AC.GuiaInspecao,
			CASE
				WHEN AC.GuiaInspecao = 0 THEN 'Não'
				ELSE 'Sim'
			END as GuiaInspecaoTexto,
            AC.GuiaPedido,
			CASE
				WHEN AC.GuiaPedido = 0 THEN 'Não'
				ELSE 'Sim'
			END as GuiaPedidoTexto,
            AC.ExigirDescricaoDetalhada,
			CASE
				WHEN AC.ExigirDescricaoDetalhada = 0 THEN 'Não'
				ELSE 'Sim'
			END as ExigirDescricaoDetalhadaTexto,
            AC.ExibirWEB,
			CASE
				WHEN AC.ExibirWEB = 0 THEN 'Não'
				ELSE 'Sim'
            END as ExibirWEBTexto,
			AC.ValidarSolicitante,
			CASE
				WHEN AC.ValidarSolicitante = 0 THEN 'Não'
				ELSE 'Sim'
            END as ValidarSolicitanteTexto,
            AC.ValidarApontamentoHoras,
			CASE
				WHEN AC.ValidarApontamentoHoras = 0 THEN 'Não'
				ELSE 'Sim'
            END as ValidarApontamentoHorasTexto,
            AC.Prioridade,
			CASE
				WHEN AC.Prioridade = 0 THEN 'Não'
				ELSE 'Sim'
            END as PrioridadeTexto,
            AC.ExibirSLA,
			CASE
				WHEN AC.ExibirSLA = 0 THEN 'Não'
				ELSE 'Sim'
            END as ExibirSLATexto
    FROM AtividadeCategoria AC
    INNER JOIN Empresa E ON (AC.EmpresaId = E.EmpresaId)
    INNER JOIN atividadeGrupo AG  on(AC.AtividadeGrupoId = AG.AtividadeGrupoId)
    INNER JOIN Projeto P on(AC.ProjetoId = P.ProjetoId)
    INNER JOIN DocumentoFluxo DF on(AC.DocumentoFluxoId = DF.DocumentoFluxoId)
    INNER JOIN SolicitanteTipo ST on(AC.SolicitanteTipoId = ST.SolicitanteTipoId)
    INNER JOIN ServicoContrato SC on(AC.ServicoContratoId = SC.ServicoContratoId)
    LEFT JOIN AtividadeValidacaoTipo AVT on(AC.AtividadeValidacaoTipoId = AVT.AtividadeValidacaoTipoId)
    LEFT JOIN AtividadeClassificacao ACL on(AC.AtividadeClassificacaoId = ACL.AtividadeClassificacaoId)
    WHERE (@EmpresaId IS NULL OR AC.EmpresaId = @EmpresaId) and (@Filtro IS NULL OR AC.AtividadeCategoria like '%' + @Filtro + '%')
END