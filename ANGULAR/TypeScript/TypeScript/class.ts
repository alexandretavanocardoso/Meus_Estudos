class Space {
    constructor(public propulsor: string){}

    // Método
    jump() {
        console.log(`${this.propulsor}`)
    }
}

// Instanciando a classe
let ship = new Space('hyper')
ship.jump();

// herdando da classe "extends" e implementado interface "implements"
class milennium extends Space implements Container{
    
    cargoContainer: number;

    constructor(){
        super('hyper') // chamando a variavel base
        this.cargoContainer = 2;
    }

    // Sobre escrevendo o método
    jump(){
        if(Math.random() >= 0.5){
            super.jump()
        } else {
            console.log('falhou')
        }
    }
}

// Instanciando a classe
let falcon = new milennium()
falcon.jump()

// Criando Interface
interface Container{

    cargoContainer: number;
}

let good = (ship: Container) => ship.cargoContainer > 2

console.log(`${good (falcon)? 'yes' : 'no'}`)