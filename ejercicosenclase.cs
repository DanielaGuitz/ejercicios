using System;

class Program
{
    static void Main(string[] args)
    {
        //ENUNCIADO 1 - ejercicio 1
        Console.WriteLine("----------5 Primeros números Pares-------");
        for (int i = 2; i <= 10; i += 2)
        {
            Console.WriteLine(i);
        }

        //Ejercicio 3 

        int suma = 0;
        for (int i = 1; i <= 10; i++)
            {
            suma += i;
        }

        Console.WriteLine("-----------SUMA DE LOS PRIMEROS 10 NÚMEROS NATURALES-------------- " + suma);


        //ENUNCIADO 2 - ejercicio 1
        int resultado = 0;
        int numero;
        Console.WriteLine("Ingresa números enteros positivos");
        numero = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                suma += numero;
            }
        } while (numero >= 0);

        Console.WriteLine("La suma de los números ingresados es: " + suma);


        // Ejercicio 2
       int number = 1;

        while (true)
        {
            if (number % 7 == 0 && number % 11 == 0)
            {
                Console.WriteLine("El primer número entero positivo divisible entre 7 y 11 es: " + numero);
                break;
            }
            numero++;
        }


        //ENUNCIADO 3 - ejercicio 1
        string passwordCorrecta = "jutiapa";
        string password;

        do
        {
            Console.Write("Ingrese la contraseña: ");
            password = Console.ReadLine();

            if (password != passwordCorrecta)
            {
                Console.WriteLine("Contraseña incorrecta. Por favor, intente de nuevo.");
            }

        } while (password != passwordCorrecta);

        Console.WriteLine("¡Contraseña correcta! Bienvenido.");


        //Ejercicio 2
        Random random = new Random();
        int numeroCorrecto = random.Next(1, 101);
        int prueba = 0;
        int intento;

        Console.WriteLine("----------------------ADIVINA EL NÚMERO------------");

        do
        {
            Console.Write("Ingresa tu intento: ");
            intento = int.Parse(Console.ReadLine());
            prueba++;

            if (intento < numeroCorrecto)
            {
                Console.WriteLine("Es mayor");
            }
            else if (intento > numeroCorrecto)
            {
                Console.WriteLine("Es menor");
            }

        } while (intento != numeroCorrecto);

        Console.WriteLine("Listo! Adivinaste " + prueba + " intentos.");
    }
}
    


    



