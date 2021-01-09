
/* ENCAPSULAMENTO */

-- Esconde detalhes de implementação, exponde apenas operações seguras

-- Opção 1 : Implementação Manual
- Todo atributo é definido como private
- Implementa-se métodos Get e Set para cada atributo

private int _nome;

-- Le o nome
public string GetNome(){ return _nome; }

-- altera o nome
public void SetNome(string nome){ _nome = nome; }

-- chamando
var.GetNome(nome);
var.SetNome(nome);