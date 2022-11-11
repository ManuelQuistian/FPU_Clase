using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2AC2_C_ManuelQuistian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameUser, codeAcces;
            byte password, passwordConfirm;
            int Color, letterColor, Tamano;

            Console.WriteLine("Ingrese su nombre de usuario");
            nameUser = Console.ReadLine();

            Console.Write("Ingrese su contraseña");
            password = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Veulva a ingresar su contraseña");
            passwordConfirm = Convert.ToByte(Console.ReadLine());

            if (password == passwordConfirm) ;
            {
                Random rnd = new Random();
                codeAcces = rnd.Next(1000, 9999).ToString();
                Console.Write("Codigo de acceso: {0}");
            }

            Console.WriteLine("Acontinuacion aparecera en consola el numero para cambiar el color de consola");
            Console.WriteLine("Por favor, elija el numero para cambiar el color de la consola 1=VERDE 2=ROJO 3= GRIS");
            Color = Convert.ToInt32(Console.ReadLine());

            if (Color == 1)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
            }
            if (Color == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
            }
            if (Color == 3)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
            }

            Console.WriteLine("Acontinuacion aparecera en  consola el numero para cambiar el color de la letra");
            Console.WriteLine("Por favor, elija el numero para cambiar el color de la letra 1=BLUE 2=BLACK 3=CYAN");
            letterColor = Convert.ToInt32(Console.Read());

            if (letterColor == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
            }

            if (letterColor == 2)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
            }

            if (letterColor == 3)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
            }

            Console.WriteLine("Acontinuacion aparecera en consola el numero para cambiar el tamaño de la consola");
            Console.WriteLine("Por favor, elija el numero para cambiar el tamaño de la consola 1=CHICO 2=MEDIANO 3=GRANDE");

            if (Tamano == 1)
            {
                Console.SetWindowSize(60, 30);
            }
            if (Tamano == 2)
            {
                Console.SetWindowSize(110, 50);
            }
            if (Tamano == 3)
            {
                Console.SetWindowSize(200, 70);
            }
            Console.ReadKey();
        }
    }
}
