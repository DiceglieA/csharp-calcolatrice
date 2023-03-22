using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class CalcoliHelper
{
    public static int SommaInteri(int num1, int num2) => num1 + num2;
    public static double SommaDecimali(double num1, double num2) => num1 + num2;

    public static int DifferenzaInteri(int num1, int num2) => num1 - num2;
    public static double DifferenzaDecimali(double num1, double num2) => num1 - num2;

    public static int MoltiplicazioneInteri(int num1, int num2) => num1 * num2;
    public static double MoltiplicazioneDecimali(double num1, double num2) => num1 * num2;

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
    public static double ValoreAssolutoDecimale(double num)
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
    public static int MinimoNum(int num1, int num2) => num1 < num2 ? num1 : num2;
    public static double MinimoDecimale(double num1, double num2) => num1 < num2 ? num1 : num2;
    public static int MassimoNum(int num1, int num2) => num1 > num2 ? num1 : num2;
    public static double MassimoNumDecimale(double num1, double num2) => num1 > num2 ? num1 : num2;

}
