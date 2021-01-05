
/* POLIMORFISMO */

-- Recurso que permite que variaveis de um mesmo tipo generico possam
apontar para objetos de tipo especificos deferentes, tendo assim compor-
tamentos diferentes conforme cada tipo especifico

-- Mesmo tipo porem aponta para objetos especificos diferentes

Account acc1 = new Account(1001, "Alex", 500.0);
Account acc2 = new Saving(1002, "Anna", 500.00, 0.01);

-- Chamam os mesmos metodos, porem são diferentes
acc1.Saque(10.0);
acc2.Saque(10.0);