
/* DESALOCAÇÃO DE MEMORIA - GARBAGE COLLECTOR E ESCOPO LOCAL */

-- DESALOCAÇÃO - GARBAGE COLLECTOR

É um processo que automatiza o gerenciamento de memoria de um programa em execução

O garbage collector monitora os objetos alocados dinamicamente pelo programa (no heap),
desalocando aqueles que não estão mais sendo utilizados

Ele detecta que o obejto no "Heap" na memoria esta sem referencia ele desaloca

- EX.

// Iniciando a apontando as variaveis
produto p1, p2;
p1 = new Produto();
p2 = p1;

-- DESALOCAÇÃO - ESCOPO LOCAL

Quando um método é criado e temos uma validação, ele cria os escopos antes de validação
e quando chega na validção e entra nela é alocado outro bloco naquele escopo, porem logo
depois que chega no fim e finaliza a validação aquele bloco criado é desalocado

Ex. // Criando Escopo
void method1(){
	int x = 10;
	if(x > 0){ // Caso estiver certo aloca outro bloco no escopo com aquele valor
		int y = 20;
	}
	console.WriteLine(x); // quando chega aqui o bloco é desalocado
}