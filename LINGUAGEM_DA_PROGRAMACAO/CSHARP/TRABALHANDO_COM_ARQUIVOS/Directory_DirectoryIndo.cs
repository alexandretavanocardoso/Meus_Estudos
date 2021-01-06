

/* DIRECTORY - DIRECTORYINFO */

-- Operações com pastas (create, enumerate, get files)

-- Directory - static members

-- DirectoryIndo - instance members

/* Exemplo */

string pah = "Caminho"


try{
	
	// Listar Subpastas a partir de uma pasta original
	IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // tem algumas sobrecargas
	foreach(string s in folders){
		Console.WriteLine(s);
	}
	
	// Listar Arquivos a partir de uma pasta original
	IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // tem algumas sobrecargas
	foreach(string s in files){
		Console.WriteLine(s);
	}
	
	// Criar Pasta
	Directory.createDirectory("CaminhoCompletoDaNovaPasta");
}
catch (IOException e) {
	Console.Write("Erro");
	Console.Write(e.Message);
}
