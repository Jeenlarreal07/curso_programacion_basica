/*1.  Número Par o Impar:*/
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero entero:");
        int numero = Convert.ToInt32(Console.ReadLine());
        VerificarParImpar(numero);
    }

    static void VerificarParImpar(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine($"El numero {numero} es par.");
        }
        else
        {
            Console.WriteLine($"El numero {numero} es impar.");
        }
    }
}
/*2.  Positivo, Negativo o Cero: */
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero entero:");
        int numero = Convert.ToInt32(Console.ReadLine());
        VerificarPositivoNegativoCero(numero);
    }

    static void VerificarPositivoNegativoCero(int numero)
    {
        if (numero > 0)
        {
            Console.WriteLine($"El numero {numero} es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine($"El numero {numero} es negativo.");
        }
        else
        {
            Console.WriteLine("El numero es cero.");
        }
    }
}
/*3.  Calculadora Simple con switch: */
using System;
class Program   
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer numero:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la operacion (+, -, *, /):");
        char operacion = Convert.ToChar(Console.ReadLine());

        RealizarOperacion(num1, num2, operacion);
    }

    static void RealizarOperacion(double num1, double num2, char operacion)
    {
        switch (operacion)
        {
            case '+':
                Console.WriteLine($"El resultado de {num1} + {num2} es: {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"El resultado de {num1} - {num2} es: {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"El resultado de {num1} * {num2} es: {num1 * num2}");
                break;
            case '/':
                if (num2 != 0)
                {
                    Console.WriteLine($"El resultado de {num1} / {num2} es: {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                }
                break;
            default:
                Console.WriteLine("Operación no válida. Por favor ingrese una operación válida (+, -, *, /).");
                break;
        }
    }
}
/*4.  Categoría de Edad: */
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la edad:");
        int edad = Convert.ToInt32(Console.ReadLine());
        VerificarCategoriaEdad(edad);
    }

    static void VerificarCategoriaEdad(int edad)
    {
        if (edad >= 0 && edad <= 12)
        {
            Console.WriteLine("La persona es un Niño.");
        }
        else if (edad >= 13 && edad <= 17)
        {
            Console.WriteLine("La persona es un Adolescente.");
        }
        else if (edad >= 18 && edad <= 59)
        {
            Console.WriteLine("La persona es un Adulto.");
        }
        else if (edad >= 60)
        {
            Console.WriteLine("La persona es un Adulto Mayor.");
        }
        else
        {
            Console.WriteLine("Edad no válida. Por favor ingrese una edad válida.");
        }
    }
}
/*5.  Tabla de Multiplicar: */
using System;   
class Program
{
    static void Main(string[] args)
    {
        ImprimirTablaMultiplicar(7);
    }

    static void ImprimirTablaMultiplicar(int numero)
    {
        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}