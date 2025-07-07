// See https://aka.ms/new-console-template for more information
using OperadoresAritmeticos.Models;

Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multplicar(15, 45);
calc.Dividir(2, 2);
calc.Potencia(3, 3);

// Funções trigonométricas com auxilio da classe Math

calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

// Ação de incremento ou decremento de variável

int numeroIncremento = 10;

Console.WriteLine(numeroIncremento);

Console.WriteLine("Incremetando o 10");
//numeroIncremento = numeroIncremento + 1;
numeroIncremento++;

Console.WriteLine(numeroIncremento);

int numeroDecremento = 10;

Console.WriteLine(numeroDecremento);

Console.WriteLine("Decremetando o 10");
//numeroDecremento = numeroDecremento - 1;
numeroDecremento--;

Console.WriteLine(numeroDecremento);

calc.RaizQuadrada(9);