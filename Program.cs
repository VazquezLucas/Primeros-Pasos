using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Escribir una linea de texto
            Console.WriteLine("Hola Mundo");

            //Operadores aritméticos
            Console.WriteLine(7 + 5);
            Console.WriteLine(7 - 5);
            Console.WriteLine(7 * 5);
            Console.WriteLine(7.0 / 5.0);
            Console.WriteLine(9 % 3);

            //Concatenacion de string
            int edadPepito = 19;
                Console.WriteLine("Tienes una edad de " + edadPepito + " años");

            //INTERPOLACIÓN DE STRINGS
            Console.WriteLine($"Tienes una edad de {edadPepito} años");
            
            //Iniciar varias variables usando la concatenacion
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;

            Console.WriteLine(edadPersona4);
            
            //Declaracion implicita de variables

            var edadPersona = 27;

            Console.WriteLine(edadPersona);
            
            //Converciones explicita y inplisitas

            double temperatura = 34.5;

            int temperaturaMadrid;

            //Conversion explicita
            //casting

            temperaturaMadrid = (int) temperatura;

            Console.WriteLine(temperaturaMadrid);
            
            //Convercion implicita

            int habitantesCiudad = 10000000;

            long habitantesCiudad2018 = habitantesCiudad;

            //TypeConversion
            //pedir valores por consola
            Console.WriteLine("Introduce el primer número");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado de la suma es {num1 + num2}");
            
            //Constantes
            const int VALOR = 5;
            const int VALOR2 = 7;

            Console.WriteLine("El valor de la constante es: {0+1}",VALOR, VALOR2); //El {0} refleja el siguiente argumento.
            
            //Calcular area de un circulo

            const double PI = 3.1416;

            Console.WriteLine("Introduce la medida del radio");

            double radio=double.Parse(Console.ReadLine());

            //double area = radio * radio * PI;
            double area = Math.Pow(radio, 2)*PI;

            Console.WriteLine($"El área del círculo es: {area}");
            
            //Declaracion de métodos

            int sumaNumeros()
            {
                int num1 = 7;
                int num2 = 9;
                int resultado = num1+ num2;
                return resultado;
            }
            
            //Metodo con parametros

            int sumaNumeros2(int num1, int num2)
            {
                int resultado = num1 + num2;

                return resultado;
            }
            
            //Método no nos devuelva ningun valor

            void sumaNumeros3()
            {
                int num1 = 7;
                int num2 = 9;

                int resultado=num1+ num2;

                Console.WriteLine(resultado);
            }


        }
    }
}

