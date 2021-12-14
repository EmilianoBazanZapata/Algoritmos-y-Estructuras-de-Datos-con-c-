using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sub(5, 1));
            Console.WriteLine(Mult(5, 5));
            Console.WriteLine(Div(7, 3));
            Console.WriteLine(Pot(2, 3));
            Console.WriteLine(Fac(5));
            Console.WriteLine(VerifyPrime(7));
            Console.WriteLine(PerfectNumber(6));
            Console.WriteLine(FriendNumber(220, 284));
            Console.WriteLine(GuayNumber(10));
        }
        //crear un algoritmo que me permita restar 2 numeros enteros, sin utilizar la resta como tal
        static string Sub(int a, int b)
        {
            int FinalValue = 0;
            string FinalString = a + " - " + b + " es igual a : ";
            while (a > b)
            {
                b++;
                FinalValue++;
            }
            return FinalString + FinalValue;
        }
        //crear un algoritmo que me permita multiplicar 2 numeros enteros, sin utilizar la multiplicacion como tal
        static string Mult(int a, int b)
        {
            int FinalValue = 0;
            string FinalString = a + " x " + b + " es igual a : ";
            while (a > 0)
            {
                a--;
                FinalValue += b;
            }
            return FinalString + FinalValue;
        }
        //crear un algoritmo que permita dividir 2 numeros, sin utilizar la division
        static string Div(float a, float b)
        {
            int FinalValue = 0;
            string FinalString = a + " / " + b + " es igual a : ";
            while (a >= b)
            {
                a -= b;
                FinalValue++;
            }
            return FinalString + FinalValue + " y el resto es : " + a;
        }
        //crear un algoritmo que permita potenciar un numero tantas veces sea necesario, sin utilizar la potencia
        static string Pot(float a, float b)
        {
            float FinalValue = 1;
            string FinalString = a + " potenciado " + b + " es igual a : ";
            while (b > 0)
            {
                b--;
                FinalValue *= a;
            }
            return FinalString + FinalValue;
        }
        //crear un algoritmo que permita calcular el factorial de un numero en particular
        static string Fac(float a)
        {
            float FinalValue = 1;
            string FinalString = " el factorial de " + a + " es igual a : ";
            for (int i = 1; i <= a; i++)
            {
                FinalValue *= i;
            }
            return FinalString + FinalValue;
        }
        //crear un algoritmo para saber si es primo
        static string VerifyPrime(int number)
        {
            bool Prime = true;
            //aqui solo verifico hasta la mitad de las posibilidades
            //ya que no tiene sentido verificar todo el arreglo
            for (int i = 2; i < number / 2 && Prime; i++)
            {
                if (number % i == 0)
                {
                    Prime = false;
                }
            }
            string value = Prime ? " Is Prime" : " Is Not Prime";
            return number + value;
        }
        //crear algoritmo para saber si un numero es perfecto
        public static string PerfectNumber(int number)
        {
            int FinalValue = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) FinalValue += i;
            }
            string value = number == FinalValue ? " Is Perfect Number" : " Is Not Perfect Number ";
            return number + value;
        }
        //crear algoritmo para saber si un numero es amigo del otro
        public static string FriendNumber(int NumberA, int NumberB)
        {
            int FinalValueA = 0;
            int FinalValueB = 0;
            for (int i = 1; i <= NumberA / 2; i++)
            {
                if (NumberA % i == 0) FinalValueA += i;
            }
            for (int i = 1; i <= NumberB / 2; i++)
            {
                if (NumberB % i == 0) FinalValueB += i;
            }
            string val = FinalValueA == NumberB && FinalValueB == NumberA ? " Are Friends" : " Not Are Friends";
            return NumberA + " and " + NumberB + val;
        }
        //crear un algoritmo para saber si un numero es guay o no
        public static string GuayNumber(int number)
        {
            int FinalValue = 0;
            bool Guay = false;
            for (int i = 1; i < number && Guay == false; i++)
            {
                FinalValue += i;
                if (FinalValue == number) Guay = true;
            }
            var val = Guay == true ? " Is Guay" : " Not is Guay";
            return number + val;
        }

    }
}