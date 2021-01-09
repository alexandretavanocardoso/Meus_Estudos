

/* MULTICAST DELEGATES  */

-- Delegates que guardam referencia para mais de um método

-- para adicionar um referencia, pode ser uasr o operador +=

-- A chamada Invoke executa todos os metodos na ordem em que foram adicionados

-- Seu uso faz sentido para metodos void


Ex.

public static void ShowMax(double X, double y){
	
}

public static void ShowSum(double X, double y){
	
}

double a = 12;
double b = 12;

BinaryNumericOperation op = CalculationService.ShowSum;
op += CalculationService.ShowMax;

op.Invoke(a,b)

