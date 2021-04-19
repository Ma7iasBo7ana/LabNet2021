using System;
using ExceptionsExtensionMethods.Exceptions;

namespace ExceptionsExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PUNTO 1");
            //Se dispara una Excepción simple, como parametro llama a un metodo que devuelve un número el cual intenta dividir por cero.
            DemoExceptions.SimpleException(DemoExceptions.IngresoDeUnNumero());
            Console.WriteLine("PUNTO 2: Ingrese dos numeros para dividir");
            //Se solicitan dos numeros a traves del metodo, una vez rerecibidos realiza la división
            DemoExceptions.IngresoDeDosNumeros();
            Console.ReadKey();
            Console.WriteLine("PUNTO 3: Disparo de Excepción");
            //Se dispara una Excepción y es agarrada por la presentación indicando cual es su mensaje y tipo.
            try
            {
                Logic.DisparoExepcion();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje de la Excepción:{ex.Message}");
                Console.WriteLine($"Tipo de Excepción: {ex.GetType()}");
            }
            Console.ReadKey();
            Console.WriteLine("PUNTO 4: Excepción personalizada");
            //Se dispara una Excepción customizada a la cual se le puede ingresar un mensaje personalizado al inicio de la misma.
            try
            {
                DemoExceptions.ThrowCustomException("MENSAJE PERSONALIZADO");
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Esto es una Excepcion del tipo {ex.GetType()}");
            }
            Console.ReadKey();
        }              
    }
}
