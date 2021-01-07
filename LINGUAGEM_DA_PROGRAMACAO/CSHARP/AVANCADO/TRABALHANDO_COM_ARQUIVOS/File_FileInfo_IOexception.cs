

/* FILE - FILEINFO - IOEXCEPTION*/


===>> File - FileInfo <<===

- Realiza operações com arquivos(create, copy, delete, move, open, etc) e
ajuda na criação de onjetos FileStream

-- File - static members
-- FileIndo - instance members

===>> IOException <<===

-- Super Classes das exceções

- DirectoryNotFoundException
- DriveNotFoundException
- EndOfStreamException
- FileLoadException
- FileNotFoundException
- PathTooLongException
- PipeException

/* Exemplos File e FileInfo */


string sourcePath = @"C:\Caminho"
string sourcePath = "C:\\Caminho\\"

string targetPath = "C:caminho"

try{
	
	FileInfo fileinfo = new FileInfo(sourcePath); // associa com outro caminho
	fileinfo.CopyTo(targetPath); // Copia arquivo
	
	string[] lines = File.ReadAllLines(NomaArquivo); // Le o arquivo e guardam as linhas em um vetor
	foreach(string line in lines){
		Console.WriteLine(line);
	}
}
catch (IOException e) {
	Console.Write("Erro");
	Console.Write(e.Message);
}




























