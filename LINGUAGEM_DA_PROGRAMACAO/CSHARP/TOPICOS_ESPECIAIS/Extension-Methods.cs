
/* EXTENSION METHODS */

-- Métodos que estendem a funcionalidade de um tipo, sem precisar aletrar o codigo fonte 
deste tipo, nem herdar desse tipo

-- Como fazer um extension methods
	- Cria classe estatica
	- Na classe, criar um metodo estatico
	- O primeiro parametro do metodo deverá ter o prefixo this, seguido da declaração
	de um parametro do tipo que se deseja estender. Esta sera uma referencia para o
	proprio objeto
	
static class NomeExtensions {
	
	public static string NomeMetodo(this Tipo thisObj){
		
		// Comando
	}
	
}