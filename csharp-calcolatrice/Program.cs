// See https://aka.ms/new-console-template for more information
using System;
using csharp_calcolatrice;

Console.WriteLine("Hello, World!");

//Somma di due numeri interi
Console.WriteLine("Inserire il primo numero:");
var addendo1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserire il secondo numero:");
var addendo2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"La somma tra {addendo1} e {addendo2} è: {CalcoliHelper.SommaNumeri(addendo1, addendo2)}");


//- Somma di due numeri double

Console.WriteLine("Inserire il primo numero:");
var addendo1Double = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Inserire il secondo numero:");
var addendo2Double = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"La somma tra {addendo1Double} e {addendo2Double} è: {CalcoliHelper.SommaNumeri(addendo1Double, addendo2Double)}");




//- Differenza tra due numeri interi
Console.WriteLine("Inserire il primo numero intero:");
var numSottrazione1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserire il secondo numero intero:");
var numSottrazione2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"La differenza tra {numSottrazione1} e {numSottrazione2} è: {CalcoliHelper.DifferenzaNumeri(numSottrazione1, numSottrazione2)}");


//- Differenza tra due numeri double

Console.WriteLine("Inserire il primo numero:");
var numSottrazione1Double = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Inserire il secondo numero:");
var numSottrazione2Double = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"La differenza tra {numSottrazione1Double} e {numSottrazione2Double} è: {CalcoliHelper.DifferenzaNumeri(numSottrazione1Double, numSottrazione2Double)}");




//- Moltiplicazione di due numeri interi

Console.WriteLine("Inserire il primo numero intero:");
var numProd1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserire il secondo numero intero:");
var numProd2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Il prodotto tra {numProd1} e {numProd2} è: {CalcoliHelper.ProdottoNumeri(numProd1, numProd2)}");


//- Moltiplicazione di due numeri double

Console.WriteLine("Inserire il primo numero:");
var numProdDouble1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Inserire il secondo numero:");
var numProdDouble2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Il prodotto tra {numProdDouble1} e {numProdDouble2} è: {CalcoliHelper.ProdottoNumeri(numProdDouble1, numProdDouble2)}");


//- Valore assoluto di un numero intero

Console.WriteLine("Inserire il numero intero di cui si vuole conoscere il valore assoluto:");
var valAssInt = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Il suo valore assoluto è: {CalcoliHelper.ValoreAssoluto(valAssInt)}");


//- Valore assoluto di un numero double

Console.WriteLine("Inserire il numero di cui si vuole conoscere il valore assoluto:");
var valAssDouble = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Il suo valore assoluto è: {CalcoliHelper.ValoreAssoluto(valAssDouble)}");



//- Minimo tra due numeri interi

Console.WriteLine("Inserire il primo numero intero da confrontare:");
var numMin1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserire il secondo numero intero da confrontare:");
var numMin2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Il minimo tra {numMin1} e {numMin2} è: {CalcoliHelper.MinNumeri(numMin1, numMin2)}");


//- Minimo tra due numeri double


Console.WriteLine("Inserire il primo numero da confrontare:");
var numMinD1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Inserire il secondo numero da confrontare:");
var numMinD2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Il minimo tra {numMinD1} e {numMinD2} è: {CalcoliHelper.MinNumeri(numMinD1, numMinD2)}");


//- Massimo tra due numeri interi

Console.WriteLine("Inserire il primo numero intero da confrontare:");
var numMax1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserire il secondo numero intero da confrontare:");
var numMax2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Il massimo tra {numMax1} e {numMax2} è: {CalcoliHelper.MaxNumeri(numMax1, numMax2)}");



//- Massimo tra due numeri double

Console.WriteLine("Inserire il primo numero da confrontare:");
var numMaxD1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Inserire il secondo numero da confrontare:");
var numMaxD2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Il massimo tra {numMaxD1} e {numMaxD2} è: {CalcoliHelper.MaxNumeri(numMaxD1, numMaxD2)}");


//Bonus

Console.WriteLine("Inserire il numero intero da elevare:");
var potBase = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserire il numero intero da usare come esponente:");
var potEsp = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Il risultato di {potBase} elevato a {potEsp} è: {CalcoliHelper.Potenza(potBase, potEsp)}");