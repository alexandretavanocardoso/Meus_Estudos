
/* DATETIMEKIND E PADRÃO ISO 8601 */

====>> DateTimeKind <<====

-- Define tres valores para a localidade da data

Local ==> fuso horário do sistema

Utc ==> GMT - Universal

Unspecificied ==> Nao especificado

-- Instanciando Local --

DateTime d1 = new DateTime(DateTimeKind.Local);

-- Instanciando Universal --

DateTime d1 = new DateTime(DateTimeKind.Utc);

-- convertendo Local para Utc --

myData.ToUniversalTime();

-- convertendo Utc para Local --

myDate.ToLocalTime();




====>> Padrão ISO 8601 <<====

-- Tem que estar no formato Universal

ToString("yyyy-MM-ddTHH:mm:ssZ");