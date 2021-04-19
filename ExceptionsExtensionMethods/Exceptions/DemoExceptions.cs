using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsExtensionMethods.Exceptions
{
    class DemoExceptions
    {
        /// <summary>
        /// Recibe como parametro un entero, el cual intenta dividir por 0, en caso de no lograrlo se captura la Excepción.
        /// </summary>
        /// <param name="numero"></param>
        public static void SimpleException (int numero)
        {
            try
            {
                int res = numero / 0;
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex.Message);
            }
           
            finally
            {
                Console.WriteLine("La operación ha terminado");
            }

        }
        /// <summary>
        /// Se ingresan dos números, lo cual verifica que se hayan ingresado en el formato correspondiente
        /// </summary>
        public static void IngresoDeDosNumeros()
        {
            decimal numero1, numero2;
            try
            {
                Console.WriteLine("Ingrese un numero:");
                numero1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero:");
                numero2 = decimal.Parse(Console.ReadLine());
                Dividir(numero1, numero2);
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Seguro que ingresaste una letra o dejaste vacio el campo");
                Console.WriteLine(ex.Message);
                
            }
            
        }
        /// <summary>
        /// Realiza una división entre dos números, de no ser posible captura la Excepción.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        public static void Dividir(decimal numero1, decimal numero2)
        {

            try
            {
                decimal res = numero1 / numero2;
                Console.WriteLine($"Resultado:{res}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo Chuck Norris divide por cero!");
                Console.WriteLine(ex.Message);
            }           
            
        }
        /// <summary>
        /// Arroja una Excepción simple
        /// </summary>
        /// <param name="mensaje"></param>
        public static void ThrowCustomException (string mensaje)
        {
            throw new CustomException(mensaje);
        }
        /// <summary>
        /// Solicita el ingreso de un número
        /// </summary>
        /// <returns></returns>
        public static int IngresoDeUnNumero ()
        {
        comienzo:
            
            Console.ForegroundColor = ConsoleColor.Gray;
            int number,contador=0;
            Console.WriteLine("ingrese un numero, el mismo se intentera dividir por 0:");
            while (!int.TryParse(Console.ReadLine(), out number))
            {

                Console.Clear();
                Console.WriteLine("ingrese un numero, el mismo se intentera dividir por 0:");
                Console.ForegroundColor = ConsoleColor.Red;
                if (contador == 0)
                {
                    Console.WriteLine("Solo puedes ingresar numeros, no me hagas repetirlo");
                    Console.WriteLine("Ingrese solamente números, por el amor de Dios");
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Te lo adverti...");                    
                    Console.WriteLine("╔═════════════════════════════════╗");
                    Console.WriteLine("║                                 ║");
                    Console.WriteLine("║      EL CONEJO DE LA MUERTE     ║");
                    Console.WriteLine("║                                 ║");
                    Console.WriteLine("╚═════════════════════════════════╝");
                    Console.WriteLine();
                    Console.WriteLine("_**_**");
                    Console.WriteLine("_**___**");
                    Console.WriteLine("_**___**_________****");
                    Console.WriteLine("_**___**_______**___****");
                    Console.WriteLine("_**__**_______*___**___**");
                    Console.WriteLine("__**__*______*__**__***__**");
                    Console.WriteLine("___**__*____*__**_____**__*");
                    Console.WriteLine("____**_**__**_**________**");
                    Console.WriteLine("____**___**__**");
                    Console.WriteLine("___*_-__* -----");
                    Console.WriteLine("__*_____________*");
                    Console.WriteLine("_*____0_____0____*");
                    Console.WriteLine("_*_______@_______*");
                    Console.WriteLine("_*_______________*");
                    Console.WriteLine("___*_____v_____*");
                    Console.WriteLine("_____**_____**");
                    Console.WriteLine();
                    Console.WriteLine("No hagas enojar al conejo.....");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Por favor, portate bien, intentemoslo nuevamente");
                    goto comienzo;
                }
                
                Console.ForegroundColor = ConsoleColor.Gray;
                contador++;
            }
            return number; 
        }
    }
}
