
/* MODIFICADOR DE PARAMETROS PARAMS */

-- Mostra que voce quer uma função que possa receber uma quantidade infinita de valores

class Calculator{
	
	public static int sum(params int[] numbers){
		
		int sum = 0;
		
		for(int i = 0; i < numbers.Length; i++){
			sum += numbers[i]
		}
		
		return sum;
	}

}

// Chamando
int s1 Calculator.sum(2, 3);

Console.Write(s1);