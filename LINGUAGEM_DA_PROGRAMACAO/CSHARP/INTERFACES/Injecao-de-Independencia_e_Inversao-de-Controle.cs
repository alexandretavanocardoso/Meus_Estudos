
/* INVERSÃO DE CONTROLE E INJEÇÃO DE INDEPENDENCIA */

/* INJEÇÃO DE INDEPEDENCIA */

-- Quando informa o objeto por meio de uns construtor

-- Uma forma de realizar a inversão de controle: um componente externo instancia a dependencia
, que é então injetada no obejto "pai". Pode ser implementada de várias formas{
	
	Construtor
	Objeto de instanciação(builder ou factory)
	Container / Framework
}

Ex.

class program{
	static void Main(string[] args ){
		
		RentalService rentalService = new RentalService(hour, day, new BrazilTaxServeci())
		
	}
}

class RentalService{
	
	private ITaxService _taxService;
	
	public RentalService( ITaxService taxservice ){
		
	}
	
}

/* INVERSAO DE CONTROLE */

-- Padrao de desenvolvimento de realizar a inversão que consiste em retirar
da classe a responsabilidade de instanciar sua dependencias