

/* FILESTREAM - STREAMREADER */

===>> FileStream <<===

-- Permite operação de leitura e escrita


===>> StreamReader <<===

-- Instancia a partir do FileStream

-- StreamReader implementa um TextReader que lê caracteres de um 
fluxo de bytes em uma codificação específica. TextReader representa um 
leitor que pode ler uma série seqüencial de caracteres (classe abstrata)

/* Exemplo */

string path = "Caminho";

StreamReader sr = null; // Evento particular

try{	
	sr = File.OpenText(Caminho);
	while(!sr.EndOfStream){ // Lendo todas linhas do arquivo
		string line = sr.ReadLine(); 
		Console.WriteLine(line);
	}		
}	
catch (IOException e) {
	Console.WriteLine(e.Message);
}
finally{
	// Fechando StreamReader
	if(sr != null){
		sr.Close();
	}
}