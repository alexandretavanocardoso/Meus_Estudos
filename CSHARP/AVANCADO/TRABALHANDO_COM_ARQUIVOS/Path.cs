

/* PATH */

-- Realiza operações com string que contém informaçõs de arquivos ou pastas


string path = "CaminhosDoArquivo";

Console.WriteLine(Path.Operação)

/* Exemplo */

Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar) // Caracter de Separação
Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
Console.WriteLine("PathSeparator: " + Path.PathSeparator) // Caracter entre path diferentes
Console.WriteLine("GetFileName: " + Path.GetFileName(path)) // Pega o nome do arquivo 
Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path)) // Pega o nome do arquivo sem a extensão
Console.WriteLine("GetExtension: " + Path.GetExtension(path)) // Somente a extensão
Console.WriteLine("GetFullPath: " + Path.GetFullPath(path)) // Caminho Inteiro do arquivo
Console.WriteLine("GetTempPath: " + Path.GetTempPath()) // pasta tempararia do sistema