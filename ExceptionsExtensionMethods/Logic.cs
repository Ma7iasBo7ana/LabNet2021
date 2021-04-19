using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsExtensionMethods
{
    public class Logic
    {
        /// <summary>
        /// Arroja una Excepción del tipo DivideByZero
        /// </summary>
        /// <returns></returns>
        public static void  DisparoExepcion ()
        {
            Console.WriteLine("            .....____________________ , ,__");
            Console.WriteLine(" ....../ `---___________----_____|] - - - - - - - - EXCEPTION ");
            Console.WriteLine(" ...../_==o;;;;;;;;_______.");
            Console.WriteLine(" .....), ---.(_(__) /");
            Console.WriteLine(" ....// (..) ), ----");
            Console.WriteLine(" ...//___//");
            Console.WriteLine(" ..//___//");
            Console.WriteLine(" .//___//");
            throw new DivideByZeroException(); 
            
        }
            

    }
}
