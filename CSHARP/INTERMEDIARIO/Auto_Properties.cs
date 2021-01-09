

/* AUTO PROPERTIES  */

-- Como Usar
public Tipo Nome { get; set; }

-- Exemplo
public string Nome { get; set;}

-- Caso o Valor nao for possivel fazer o "set"
public string Nome { get; private set;}