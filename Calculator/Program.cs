using System;

namespace BasicCalculatorApp
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return double.NaN; 
            }
            return a / b;
        }

        public double Modulus(double a, double b)
        {
            return a % b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\nCalculadora Básica");
                Console.WriteLine("Seleccione una operación:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Módulo");
                Console.WriteLine("6. Salir");

                if (!int.TryParse(Console.ReadLine(), out int option))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    continue;
                }

                if (option == 6)
                {
                    Console.WriteLine("Saliendo de la calculadora...");
                    keepRunning = false;
                    continue;
                }

                if (option < 1 || option > 5)
                {
                    Console.WriteLine("Por favor, seleccione una opción válida (1-6).");
                    continue;
                }

                Console.WriteLine("Ingrese el primer número:");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Número inválido, intente de nuevo.");
                    continue;
                }

                Console.WriteLine("Ingrese el segundo número:");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Número inválido, intente de nuevo.");
                    continue;
                }

                double result = 0;
                switch (option)
                {
                    case 1:
                        result = calculator.Add(num1, num2);
                        Console.WriteLine($"Resultado de la suma: {result}");
                        break;
                    case 2:
                        result = calculator.Subtract(num1, num2);
                        Console.WriteLine($"Resultado de la resta: {result}");
                        break;
                    case 3:
                        result = calculator.Multiply(num1, num2);
                        Console.WriteLine($"Resultado de la multiplicación: {result}");
                        break;
                    case 4:
                        result = calculator.Divide(num1, num2);
                        if (!double.IsNaN(result))
                        {
                            Console.WriteLine($"Resultado de la división: {result}");
                        }
                        break;
                    case 5:
                        result = calculator.Modulus(num1, num2);
                        Console.WriteLine($"Resultado del módulo: {result}");
                        break;
                }
            }
        }
    }
}

