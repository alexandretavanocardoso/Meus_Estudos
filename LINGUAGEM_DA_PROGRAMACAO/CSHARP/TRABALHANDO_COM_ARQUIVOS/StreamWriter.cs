

/* STREAMWRITER */

-- Capaz de escrever caracteres

string sourcePath = "Caminho";
string targetPath = "Caminho2";


try{
	
	string[] lines = File.ReadAllLines(sourcePath);
	
	using (StreamWriter sw = File.AppendText(targetPath)){// Abre o arquivo para escrita
		foreach(string line in lines){
			sw.WriteLine(line.ToUpper());
		}
	} 
	
}
catch (IOException e) {
	Console.Write("Erro");
	Console.Write(e.Message);
}
