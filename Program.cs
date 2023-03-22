//Come visto a lezione, strutturare la classe in modo che non possa essere istanziata e che presenti i seguenti metodi static:

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


Console.WriteLine(CalcoliHelper.SommaInteri(10, 2));
Console.WriteLine(CalcoliHelper.SommaDecimali(10.2, 2.12));
Console.WriteLine(CalcoliHelper.DifferenzaInteri(10, 2));
Console.WriteLine(CalcoliHelper.DifferenzaDecimali(10.2, 2.12));
Console.WriteLine(CalcoliHelper.MoltiplicazioneInteri(10, 2));
Console.WriteLine(CalcoliHelper.MoltiplicazioneDecimali(10.2, 2.12));
Console.WriteLine(CalcoliHelper.ValoreAssoluto(-22));
Console.WriteLine(CalcoliHelper.ValoreAssolutoDecimale(-22.1));
Console.WriteLine(CalcoliHelper.MinimoNum(10, 2));
Console.WriteLine(CalcoliHelper.MinimoDecimale(10.2, 2.12));
Console.WriteLine(CalcoliHelper.MassimoNum(10, 2));
Console.WriteLine(CalcoliHelper.MassimoNumDecimale(10.2, 2.12));