
/* ESTRUTURA TRY-CATCH */


-- Bloco try
	- Contém o código que representa a execução normal do tracho de código
	  pode acarretar em uma exceção
	  

-- bloco catch
	- Contém o código a ser executado caso uma exceção ocorra
	- Deve ser especificada o tipo da exceção a ser tratada (upcasting é permitido)
	
	
/* SINTAXE */

(ExceptionType e) - 'e' - apelido para exceção

try {
	
}
catch (ExceptionType e) {
	
}


try {
	
}
catch (ExceptionType e) {
	
}
catch (ExceptionType e) {
	
}


/* DEMO */

try{
	
	int n1 = A
	int n2 = 0

	int resultado = n1 / n2;

	console.Write(resultado);

} catch (DivideByZeroException) {
	
	console.Write("Divisão por 0 está errado ! " + e.Message);
	
} catch (FormatException) {
	
	console.Write("Não é Perimtido letra");
	
}




