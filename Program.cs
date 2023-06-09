﻿//Come visto a lezione, strutturare la classe in modo che non possa essere istanziata e che presenti i seguenti metodi static:

//-Somma di due numeri interi
//- Somma di due numeri double
//- Differenza tra due numeri interi
//- Differenza tra due numeri double
//- Moltiplicazione di due numeri interi
//- Moltiplicazione di due numeri double
//- Valore assoluto di un numero intero
//- Valore assoluto di un numero double
//- Minimo tra due numeri interi
//- Minimo tra due numeri double
//- Massimo tra due numeri interi
//- Massimo tra due numeri double

//Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale? Scrivetelo in un commento all’interno del codice! :faccia_nerd:


Console.WriteLine(CalcoliHelper.Somma(10, 2));
Console.WriteLine(CalcoliHelper.Somma(10.2, 2.12));
Console.WriteLine(CalcoliHelper.Differenza(10, 2));
Console.WriteLine(CalcoliHelper.Differenza(10.2, 2.12));
Console.WriteLine(CalcoliHelper.Moltiplicazione(10, 2));
Console.WriteLine(CalcoliHelper.Moltiplicazione(10.2, 2.12));
Console.WriteLine(CalcoliHelper.ValoreAssoluto(-22));
Console.WriteLine(CalcoliHelper.ValoreAssoluto(-22.1));
Console.WriteLine(CalcoliHelper.Minimo(10, 2));
Console.WriteLine(CalcoliHelper.Minimo(10.2, 2.12));
Console.WriteLine(CalcoliHelper.Massimo(10, 2));
Console.WriteLine(CalcoliHelper.Massimo(10.2, 2.12));

//bonus 

Console.WriteLine(CalcoliHelper.Potenza(10, 2));
Console.WriteLine(CalcoliHelper.Potenza(0, 0)); 
Console.WriteLine(CalcoliHelper.Potenza(0, 3));
Console.WriteLine(CalcoliHelper.Potenza(3, 0));
Console.WriteLine(CalcoliHelper.Potenza(3, -2));