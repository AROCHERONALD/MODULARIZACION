using System;

class Program
{
    //Codigo para la calculadora básica
    static void Calculadora()
    {
        double num1, num2;
        string operacion;
        Console.WriteLine("Ingresa el primer número:");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Entrada no válida. Intenta de nuevo.");
        }

        Console.WriteLine("Ingresa el segundo número:");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Entrada no válida. Intenta de nuevo.");
        }

        Console.WriteLine("Selecciona la operación: suma, resta, multiplicación, división");
        operacion = Console.ReadLine().ToLower();

        switch (operacion)
        {
            case "suma":
                Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
                break;
            case "resta":
                Console.WriteLine($"El resultado de la resta es: {num1 - num2}");
                break;
            case "multiplicación":
                Console.WriteLine($"El resultado de la multiplicación es: {num1 * num2}");
                break;
            case "división":
                if (num2 != 0)
                    Console.WriteLine($"El resultado de la división es: {num1 / num2}");
                else
                    Console.WriteLine("Error: No se puede dividir por 0.");
                break;
            default:
                Console.WriteLine("Operación no válida.");
                break;
        }
    }

    // Codigo para validar la contraseña
    static void ValidarContraseña()
    {
        string contraseña;
        do
        {
            Console.WriteLine("Introduce la contraseña:");
            contraseña = Console.ReadLine();
        } while (contraseña != "1234");
        Console.WriteLine("Acceso concedido.");
    }

    // Codigo para verificar si un número es primo
    static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }

    // Codigo para la suma de números pares
    static void SumarPares()
    {
        int suma = 0, numero;
        Console.WriteLine("Ingresa números enteros. Ingresa 0 para terminar.");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out numero) && numero == 0) break;
            if (numero % 2 == 0) suma += numero;
        }
        Console.WriteLine($"La suma de los números pares es: {suma}");
    }

    // Codigo para convertir entre Celsius y Fahrenheit
    static void ConvertirTemperatura()
    {
        Console.WriteLine("Selecciona la conversión: 1) Celsius a Fahrenheit, 2) Fahrenheit a Celsius");
        int opcion = int.Parse(Console.ReadLine());
        double temperatura;
        if (opcion == 1)
        {
            Console.WriteLine("Ingresa la temperatura en Celsius:");
            temperatura = double.Parse(Console.ReadLine());
            Console.WriteLine($"{temperatura}°C = {(temperatura * 9 / 5) + 32}°F");
        }
        else
        {
            Console.WriteLine("Ingresa la temperatura en Fahrenheit:");
            temperatura = double.Parse(Console.ReadLine());
            Console.WriteLine($"{temperatura}°F = {(temperatura - 32) * 5 / 9}°C");
        }
    }

    // Codigo para contar vocales
    static void ContarVocales()
    {
        Console.WriteLine("Introduce una frase:");
        string frase = Console.ReadLine().ToLower();
        int vocales = 0;
        foreach (char c in frase)
        {
            if ("aeiou".Contains(c)) vocales++;
        }
        Console.WriteLine($"Número de vocales: {vocales}");
    }

    // Codigo para calcular el factorial
    static void CalcularFactorial()
    {
        Console.WriteLine("Ingresa un número para calcular su factorial:");
        int numero = int.Parse(Console.ReadLine());
        long factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    // Codigo para el juego de adivinanza
    static void JuegoAdivinanza()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int intento;
        do
        {
            Console.WriteLine("Adivina el número entre 1 y 100:");
            intento = int.Parse(Console.ReadLine());
            if (intento < numeroSecreto) Console.WriteLine("Demasiado bajo.");
            else if (intento > numeroSecreto) Console.WriteLine("Demasiado alto.");
        } while (intento != numeroSecreto);
        Console.WriteLine("¡Adivinaste el número!");
    }

    // Codigo para intercambiar dos números por referencia
    static void Intercambiar(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    // Codigo para mostrar la tabla de multiplicar
    static void TablaMultiplicar()
    {
        Console.WriteLine("Ingresa un número para mostrar su tabla de multiplicar:");
        int numero = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }

    // Menú principal
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calculadora básica");
            Console.WriteLine("2. Validación de contraseña");
            Console.WriteLine("3. Números primos");
            Console.WriteLine("4. Suma de números pares");
            Console.WriteLine("5. Conversión de temperatura");
            Console.WriteLine("6. Contador de vocales");
            Console.WriteLine("7. Cálculo de factorial");
            Console.WriteLine("8. Juego de adivinanza");
            Console.WriteLine("9. Paso por referencia");
            Console.WriteLine("10. Tabla de multiplicar");
            Console.WriteLine("0. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: Calculadora(); break;
                case 2: ValidarContraseña(); break;
                case 3:
                    Console.WriteLine("Ingresa un número:");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine(EsPrimo(num) ? "Es primo." : "No es primo.");
                    break;
                case 4: SumarPares(); break;
                case 5: ConvertirTemperatura(); break;
                case 6: ContarVocales(); break;
                case 7: CalcularFactorial(); break;
                case 8: JuegoAdivinanza(); break;
                case 9:
                    Console.WriteLine("Ingresa dos números:");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Antes: {num1}, {num2}");
                    Intercambiar(ref num1, ref num2);
                    Console.WriteLine($"Después: {num1}, {num2}");
                    break;
                case 10: TablaMultiplicar(); break;
                case 0: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción no válida."); break;
            }
        } while (opcion != 0);
    }
}


