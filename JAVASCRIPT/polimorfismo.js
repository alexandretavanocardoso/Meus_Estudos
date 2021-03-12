/************
    Polimorfismo
     princípio pelo qual duas ou mais classes derivadas da mesma superclasse podem invocar métodos que têm a mesma assinatura, mas comportamentos distintos.
************/

// SuperClass
function Conta(agencia, conta, saldo){
    this.agencia = agencia;
    this.conta = conta;
    this.saldo = saldo;
}
Conta.prototype.sacar = function(valor){
    if(this.saldo <= valor){
        console.log("Saldo Insuficiente");
        return;
    }
    this.saldo -= valor;
    this.verSaldo();
};
Conta.prototype.depositar = function(valor){
    this.saldo += valor;
    this.verSaldo();
};
Conta.prototype.verSaldo = function(){
    console.log(`${this.agencia}/${this.conta}/${this.saldo}`);
};

function ContaCorrente(agencia,conta,saldo,limite){
    Conta.call(this,agencia,conta,saldo);
    this.limite = limite;
}

ContaCorrente.prototype = Object.create(Conta.prototype);
ContaCorrente.prototype.constructor = ContaCorrente;

ContaCorrente.prototype.sacar = function(valor){
    if(valo > (this.saldo + this.limite)){
        console.log("Saldo Insuficiente");
        return;
    }
    this.saldo -= valor;
    this.verSaldo();
};