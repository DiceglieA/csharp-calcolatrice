using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
public class CalcoliHelper
{
    public static int Somma(int num1, int num2) => num1 + num2;
    public static double Somma(double num1, double num2) => num1 + num2;

    public static int Differenza(int num1, int num2) => num1 - num2;
    public static double Differenza(double num1, double num2) => num1 - num2;

    public static int Moltiplicazione(int num1, int num2) => num1 * num2;
    public static double Moltiplicazione(double num1, double num2) => num1 * num2;

    public static int ValoreAssoluto(int num)
    {
        if (num < 0)
        {
            return num * -1;
        }
        else
        {
            return num;
        }
    }
    public static double ValoreAssoluto(double num)
    {
        if (num < 0)
        {
            return num * -1;
        }
        else
        {
            return num;
        }
    }
    public static int Minimo(int num1, int num2) => num1 < num2 ? num1 : num2;
    public static double Minimo(double num1, double num2) => num1 < num2 ? num1 : num2;
    public static int Massimo(int num1, int num2) => num1 > num2 ? num1 : num2;
    public static double Massimo(double num1, double num2) => num1 > num2 ? num1 : num2;

    //Question
    //Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale?
    //    Il principio del polimorfismo

   
}
