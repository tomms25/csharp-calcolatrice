using System;



//Come visto a lezione, strutturare la classe in modo che non possa essere istanziata e che presenti i seguenti metodi `static`:
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
//Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale? Scrivetelo in un commento all’interno del codice! 
//Testate tutti i metodi della vostra classe di helper (con un esempio per ogni casistica).


namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        public static int SommaNumeri(int addendo1, int addendo2)
        {
            return addendo1 + addendo2;
        }
        public static double SommaNumeri(double addendo1, double addendo2)
        {
            return addendo1 + addendo2;
        }
        public static int DifferenzaNumeri(int num1, int num2)
        {
            return num1 - num2;
        }
        public static double DifferenzaNumeri(double num1, double num2)
        {
            return num1 - num2;
        }
        public static int ProdottoNumeri(int num1, int num2)
        {
            return num1 * num2;
        }
        public static double ProdottoNumeri(double num1, double num2)
        {
            return num1 * num2;
        }
        public static int ValoreAssoluto(int num)
        {
            if (num >= 0) return num;
            else return num * (-1);
        }
        public static double ValoreAssoluto(double num)
        {
            if (num >= 0) return num;
            else return num * (-1);
        }
        public static int MinNumeri(int num1, int num2)
        {
            if (num1 < num2) return num1;
            else return num2;
        }
        public static double MinNumeri(double num1, double num2)
        {
            if (num1 < num2) return num1;
            else return num2;
        }
        public static int MaxNumeri(int num1, int num2)
        {
            if (num1 > num2) return num1;
            else return num2;
        }
        public static double MaxNumeri(double num1, double num2)
        {
            if (num1 > num2) return num1;
            else return num2;
        }

        //Elevamento a potenza
        public static double Potenza(double numero1, int numero2)
        {
            if (numero2 == 0 && numero1 == 0)
            {
                return 1;
            }
            else if (numero1 == 0)
            {
                return 0;
            }
            else if (numero2 == 0)
            {
                return 1;
            }
            else if (numero2 < 0)
            {
                return 1 / Potenza(numero1, -numero2);
            }
            else
            {
                double result = 1;
                for (int i = 0; i < numero2; i++)
                {
                    result *= numero1;
                }
                return result;
            }
        }
    }
}

