

/* BLOCO USING */

-- Usado no lugar do "finally" para arquivos

string path = "caminho";

using (FileStream fs = new FileStream(path, ModoDeAbertura)){
	
}


using (FileStream fs = new FileStream(path, ModoDeAbertura)){

	using (StreamReader sr = new StreamReader(fs)){
	
	}
	
}

-- Para tratar as exceções

try 
{
	using (FileStream fs = new FileStream(path, ModoDeAbertura)){

		using (StreamReader sr = new StreamReader(fs)){ 
		
		
		}
	
	}
	
} catch (IOException) {
	// mensagem
}

	