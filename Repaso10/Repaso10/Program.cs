using System;

namespace Repaso10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string ingreso = "";
                do
                {
                    Console.WriteLine("Ingresar un caracter");
                    ingreso = Console.ReadLine();
                    if (ingreso == "") Console.WriteLine("Algo, no vacío");
                } while (ingreso == "");

                if (int.TryParse(ingreso, out int x))
                {
                    Console.WriteLine("eso fue un número");
                }
                else if (ingreso == "a" || ingreso == "e" || ingreso == "i" || ingreso == "o" || ingreso == "u")
                {
                    Console.WriteLine("eso fue una vocal");
                }
                else
                {
                    Console.WriteLine("eso fue una consonante");
                }
            }
        }
    }
}
