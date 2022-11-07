using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FPU_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manejo de estructuras selectivas
            string nameUser, lastName, contactNumber, city, FBProfile, email;
            byte age = 0;
            string user, password, codeAcces, passwordconfirm;

            Console.WriteLine("Ingrese su nombre y al finalizar presione ENTER");
            nameUser = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido y al finalizar presione ENTER");
            lastName = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad con digito y al finalizar presione ENTER");
            age = Convert.ToByte(Console.ReadLine());

            //if
            if (age > 18) ;

            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("Completa tu registro para obtener tu codigo de acceso");
                //Codigo para completar el perfil
                Console.WriteLine("Ingresa tu numero de telefono");
                contactNumber = Console.ReadLine();
                Console.WriteLine("Ingresa tu ciudad de residencia");
                city = Console.ReadLine();
                Console.WriteLine("Ingresa tu perfil de facebook");
                FBProfile = Console.ReadLine();
                Console.WriteLine("Ingresa tu correo electronico");
                email = Console.ReadLine();
                Console.WriteLine("Ingresa tu nombre de usuario");
                nameUser = Console.ReadLine();
                Console.WriteLine("Ingresa tu contraseña");
                password = Console.ReadLine();
                Console.WriteLine("Vuelve a ingresar tu contraseña");
                passwordconfirm = Console.ReadLine();
                Console.Write("Ingresa tu codigo de acceso");
                codeAcces = Console.ReadLine();

                if (password == passwordconfirm)
                {
                    //Numeros aleatorios
                    Random rnd = new Random();
                    codeAcces = rnd.Next(1000, 9999).ToString();
                    Console.WriteLine("Codigo de acceso: {0}");

                }
            }
            Console.WriteLine("SALIENDO DEL SISTEMA.");
            Thread.Sleep(1000);
            Console.WriteLine("SALIENDO DEL SISTEMA..");
            Thread.Sleep(1000);
            Console.Write("SALIENDO DEL SISTEMA...");
            Thread.Sleep(1000);
            Console.WriteLine("SALIENDO DEL SISTEMA....");
            Thread.Sleep(1000);


            Console.ReadKey();
        }
    }
}
