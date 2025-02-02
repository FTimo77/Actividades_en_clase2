using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_en_clase2
{
    internal class Program
    {
        static int vidasUsuario = 3;
        static int vidasPc = 3;

        static void Main(string[] args)
        {
            area_circulo area_circulo = new area_circulo();
            area_circulo.area();
            Console.ReadKey();
            sumar sumar = new sumar();
            sumar.suma();
            Console.ReadKey();
            ejercicio();
            Console.ReadKey();
        }
        private static void ejercicio()
        {
            /*1.-menu opciones ->jugador
             *2.-recuperar la opcion del jugador
             *3.-generar numero aletorio 1-4 (con la clase Random Next(1,4))
             *
             * 
             */
            do
            {
                int opcionUsuario = menuOpciones();
                int randomPc = new Random().Next(1, 4);
                logicaJuego(opcionUsuario, randomPc);


                if (vidasUsuario == 0 || vidasPc == 0)
                {
                    break;
                }

            } while (true);
        }
        private static int menuOpciones()
        {
            Console.WriteLine("1..para Piedra\n" +
                "2..Papel\n" +
                "3..Tijera");
            return int.Parse(Console.ReadLine());
        }

        private static void logicaJuego(int a, int b)
        {
            // Piedra Papel Tijera   usario a   1->Piedra 2->Papel  3->Tijera
            // Pierdra Papel Tijera  pc     b   3->Tijera 1->Piedra  2->Papel
            string[] opciones = { "Piedra", "Papel", "Tijera" };
            Console.WriteLine($"usuario {opciones[a - 1]}\nPc {opciones[b - 1]}");

            string cadena = "";

            if ((a == 1 && b == 3) || (a == 2 && b == 1) || (a == 3 && b == 2))
            {
                //gano usuario
                cadena = "Usuario gana";
                vidasPc--;
            }
            else if (a == b)
            {
                //emapate
                cadena = "Empate!";
            }
            else
            {
                cadena = "Pc gana!";
                vidasUsuario--;
            }

            Console.WriteLine(cadena);

        }
    }
    internal class sumar
    {
        public void suma()
        {
            int sumaTotal = 0;
            Console.WriteLine("Introduce números enteros para sumarlos (0 para finalizar):");

            while (true)
            {
                Console.Write("Número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break;
                }
                else
                {
                    sumaTotal += numero;
                }
            }

            Console.WriteLine($"La suma total es: {sumaTotal}");

        }
    }
    internal class area_circulo
    {
        public void area()
        {
            double radio, area;
            Console.WriteLine("Introduce el radio del círculo:");
            radio = double.Parse(Console.ReadLine());
            area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine($"El área del círculo es: {area}");
        }
    }
}

