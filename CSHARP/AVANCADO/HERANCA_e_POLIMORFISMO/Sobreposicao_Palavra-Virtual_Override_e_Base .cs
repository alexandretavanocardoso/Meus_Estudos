
/* Sobreposição, Palavra Virtual, Override e Base */

====>> Sobreposição <<====

-- É a implementação de um método de uma superclasse na subclasse

-- Para um método comum ser sobreposto, deve incluir nele o prefixo " virtual "

-- Ao sobrescrever um método, devemos incluir nele o prefixo " override "

====>> Palavra Virtual <<====

-- Indica que pode ser sobrescrito nas superclasses

// Ex. 
public virtual nomeClasse(){
	
}

====>> Override <<====

-- Sobrescreve na superclasse

// Ex.
public override nomeClasse(){
	
}

====>> Base <<====

-- Chama a implementação da superclasse

public override nomeClasse(double desconto){
	
	base.nomeClasse(desconto); 
	balanco -= 2.0; // a variavel dsconto vale 2
}
