validatorSolicitacao = $("#frmSolicitacao").kendoValidator(
                {
                    messages: {
                        customRuleIniciativa: "",
                        customRuleNomeIniciativa: "",
                        customRuleDuracaoIniciativa: "",
                        customRuleObjetivo: "",
                        customRuleResultado: "",
                        customRuleMecanica: "",
                        customRuleValorEstimado: "",
                        customRuleRegiao: "",
                        customRuleParticipantes: "",
                        customRuleDataInicio: "",
                        customRuleDataFim: "",
                        customRuleDataLancamento: "",
                        customRuleDataInicioReq: "",
                        customRuleDataFimReq: "",
                        customRuleDataLancamentoReq: "",
                        customRuleValidaDatas: rMsgDataForaLimite,
                        Atrelado: "",
                        customRuleDataLancamentoValid: rMsgDataForaLimiteLanc,
                        customRuleddtModalidade: "",
                        customRuleddtCultura: "",
                        customRuleddtPilares: "",
                        customRuleddtTipoCliente: "",
                        customRuleddtFormacao: "",
                        customRuleddtPremiacao: "",
                        customRuletxtCultura: "",
                        customRuletxtTipoIncentivo: ""
                    },
                    rules: {
                        customRuleIniciativa: function (input) {
                            if (input.is("[id=cmbIniciativa]") && $(input).val() == "" && (validaAcao == "Rascunho" || validaAcao == "WorkFlow")) {
                                return false;
                            }
                            return true;
                        },
                        customRuleNomeIniciativa: function (input) {
                            if (input.is("[id=txtNomeIniciativa]") && $(input).val() == "" && (validaAcao == "Rascunho" || validaAcao == "WorkFlow")) {
                                return false;
                            }
                            return true;
                        },

                        customRuleDuracaoIniciativa: function (input) {
                            if (input.is("[id=cmbDuracao]") && $(input).val() == "" && validaAcao == "WorkFlow") {
                                return false;
                            }
                            return true;
                        },
                        customRuleObjetivo: function (input) {
                            if (input.is("[id=txtObjetivo]") && $(input).val() == "" && validaAcao == "WorkFlow") {
                                return false;
                            }
                            return true;
                        },
                        customRuleResultado: function (input) {
                            if (input.is("[id=txtResultado]") && $(input).val() == "" && validaAcao == "WorkFlow") {
                                return false;
                            }
                            return true;
                        },
                        customRuleMecanica: function (input) {
                            if (input.is("[id=txtMecanica]") && $(input).val() == "" && validaAcao == "WorkFlow") {
                                return false;
                            }
                            return true;
                        },
                        customRuleValorEstimado: function (input) {
                            if (input.is("[id=txtPremiacao]") && $(input).val() == "" && validaAcao == "WorkFlow") {
                                return false;
                            }
                            return true;
                        },
                        customRuleRegiao: function (input) {
                            if (input.is("[id=txtRegiao]") && $(input).val() == "" && validaAcao == "WorkFlow") {
                                return false;
                            }
                            return true;
                        },
                        customRuleParticipantes: function (input) {
                            if (input.is("[id=txtProdParticipantes]") && $(input).val() == "" && validaAcao == "WorkFlow") {
                                return false;
                            }
                            return true;
                        },
                        Atrelado: function (input) {
                            if (input.is("[id=cmbCampanhaAtrelada]")) {
                                if ($(input).val() == "" && rdbAtreladaSim.checked && validaAcao == "WorkFlow") {
                                    return false;
                                }
                                return true;
                            }
                            return true;
                        },
                        customRuleDataLancamento: function (input) {
                            if (input.is("[id=txtLancamento]") && !isData($(input).val()))
                                return false;
                            else
                                return true;
                        },
                        //  customRuleDataLancamentoValida: function (input) {
                        //      if ( input.is("[id=txtLancamento]") &&  && $(input).val() != ""  && !isData($(input).val())  )
                        //          return false;
                        //     else
                        //          return true;
                        //  },
                        customRuleDataInicio: function (input) {
                            if (input.is("[id=txtInicio]") && !isData($(input).val()))
                                return false;
                            else
                                return true;
                        },
                        customRuleDataFim: function (input) {
                            if (input.is("[id=txtEncerramento]") && !isData($(input).val()))
                                return false;
                            else
                                return true;
                        },
                        customRuleDataInicioReq: function (input) {
                            if (input.is("[id=txtInicio]") && txtInicio.value() == null && validaAcao == "WorkFlow")
                                return false;
                            else
                                return true;
                        },
                        customRuleDataFimReq: function (input) {
                            if (input.is("[id=txtEncerramento]") && txtEncerramento.value() == null && validaAcao == "WorkFlow")
                                return false;
                            else
                                return true;
                        },
                        customRuleDataLancamentoReq: function (input) {
                            if (input.is("[id=txtLancamento]") && txtLancamento.value() == null && validaAcao == "WorkFlow")
                                return false;
                            else
                                return true;
                        },
                        customRuleDataLancamentoValid: function (input) {
                            if (input.is("[id=txtLancamento]") && $(input).val() !== "") {
                                var data = new Date();
                                var dateStart = kendo.parseDate(formataDataOnly(data));
                                var dateEnd = kendo.parseDate($(input).val());
                                if (dateEnd < dateStart)
                                    return false;
                                else
                                    return true;
                            } else
                                return true;
                        },
                        customRuleValidaDatas: function (input) {
                            if (input.is("[id=txtEncerramento]") && txtInicio.value() !== null && txtEncerramento.value() !== null && validaAcao == "WorkFlow") {
                                var dateStart = kendo.parseDate(txtInicio.value());
                                var dateEnd = kendo.parseDate(txtEncerramento.value());
                                if (dateStart > dateEnd)
                                    return false;
                                else
                                    return true;
                            } else
                                return true;

                        },
                        customRuleddtModalidade: function (input) {
                            if (input.is("[id=ddtModalidade]") && ddtModalidade.value().length == 0 && validaAcao == "WorkFlow")
                                return false;
                            else
                                return true;
                        },
                        customRuleddtCultura: function (input) {
                            if (input.is("[id=ddtCultura]") && ddtCultura.value().length == 0 && validaAcao == "WorkFlow")
                                return false;
                            else
                                return true;
                        },
                        customRuletxtCultura: function (input) {
                            if (input.is("[id=txtCultura]") && txtCultura.value == "" && $('#li_txtCultura').css('display') !== 'none' && validaAcao == "WorkFlow")
                                return false;
                            else
                                return true;
                        },
                        customRuleddtPilares: function (input) {
                            if (input.is("[id=ddtPilares]") && ddtPilares.value().length == 0 && validaAcao == "WorkFlow")
                                return false;
                            else
                                return true;
                        },
                        customRuleddtTipoCliente: function (input) {
                            if (input.is("[id=ddtTipoCliente]") && ddtTipoCliente.value().length == 0 && (validaAcao == "Rascunho" || validaAcao == "WorkFlow"))
                                return false;
                            else
                                if (ddtTipoCliente.length == 0) {
                                    return false;
                                } else {
                                    return true;
                                }
                        },
                        customRuleddtFormacao: function (input) {
                            if (input.is("[id=ddtFormacao]") && ddtFormacao.value().length == 0 && validaAcao == "WorkFlow")
                                return false;
                            else
                                return true;
                        },
                        customRuleddtPremiacao: function (input) {
                            if (input.is("[id=ddtPremiacao]") && ddtPremiacao.value().length == 0 && validaAcao == "WorkFlow")
                                return false;
                            else
                                return true;
                        },
                        customRuletxtTipoIncentivo: function (input) {
                            if (input.is("[id=txtTipoIncentivo]") && txtTipoIncentivo.value == "" && $('#li_txtTipoIncentivo').css('display') !== 'none' && validaAcao == "WorkFlow")
                                return false;
                            else
                                return true;
                        },
                        customRuleValidaDatas: function (input) {
                            if (input.is("[id=txtEncerramento]") && txtInicio.value() !== null && txtEncerramento.value() !== null && validaAcao == "WorkFlow") {
                                var dateStart = kendo.parseDate(txtInicio.value());
                                var dateEnd = kendo.parseDate(txtEncerramento.value());
                                if (dateStart > dateEnd)
                                    return false;
                                else
                                    return true;
                            } else
                                return true;

                        }
                    }
                }).data("kendoValidator");