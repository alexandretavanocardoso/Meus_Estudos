
/* ENUMERAÇÃO */

-- Um tipo que serve para especificar de forma literal um conjunto de 
costantes relacionadas

-- Palavra chave em C#: enum
	-- É um tipo valor
	

/* Exemplo - Ciclo de vida de um pedido */

-- Pendente 1°
-- Processando 2°
-- Enviado 3°
-- Entregue 4°
	 
	// Nome do enums
enum StatusPedido : int // Tipo de Valor {
	PedidoPendente = 0,
	ProcessoPedido = 1,
	PedidoEnviado = 2,
	PedidoEntregue = 3
}
	
class Pedido{
	
	public int id {get; set;}
	public DateTime momentoPedido {get; set;}
	public StatusPedido statusPedido {get; set;} 
	/* StatusPedido - Tipo Enum que foi criado */
}

// Usando

Pedido pedido = new Pedido() {
	id = 1,
	momentoPedido = DateTime.Now,
	statusPedido = StatusPedido
}


/* Representação UML */

-- Estereótipo = <<palavra>>

















