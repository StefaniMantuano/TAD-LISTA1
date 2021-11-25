using System;
using System.Collections;

namespace StefaniaMantuano3b._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();
            int opcion;
            do
            {
                Console.Clear();
                opcion = menu();
                switch (opcion)

                {
                    case 1:
                        Agregar(ref pila);
                        break;

                    case 2:
                        Eliminar(ref pila);
                        break;

                    case 3:
                        Limpiar(ref pila);
                        break;

                    case 4:
                        Imprimir(pila);
                        break;

                    case 5: break;
                    default:
                        mensaje("Error: La opcion no es valida, intente de nuevo");
                        break;
                }
            }
            while (opcion != 5);
            mensaje("El programa a finalizado");
        }

        //Agregar un nuevo elemento a la pila
        static void Agregar (ref Stack pila1)
        {
            Console.Write("\n>Ingrese valor: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                if (valor > 80 || valor <= 0)
                {
                    mensaje("solo números de 1 al 80");
                }
                else
                {
                    pila1.Push(valor);
                    Imprimir (pila1);
                }
            }
            catch {
                mensaje("Error: Solo números del 1 al 80");
            }
        }

        //Elimina los elementos de una pila
        static void Limpiar(ref Stack pila1)
        {
            pila1.Clear();
            Imprimir(pila1);
        }

        //Elimina elemento de la pila 
        static void Eliminar(ref Stack pila1)
        {
            if (pila1.Count > 0)
            {
                int valor = (int)pila1.Pop();
                mensaje("Elemento " + valor + " eliminado");
            }
            else
            {
                Imprimir(pila1);
            }
        }
        //Muestra menú y retorna
        static int menu()
        {
            //Console.Clear();
            Console.WriteLine("\n            Stack Menu\n");
            Console.WriteLine(" 1.- Agregar elemento");
            Console.WriteLine(" 2.- Eliminar elemento");
            Console.WriteLine(" 3.- Vaciar Pila");
            Console.WriteLine(" 4.- Ver pila");
            Console.WriteLine(" 5.- Termina programa");
            Console.Write(" JJ:> Ingresa tu opción: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                return valor;
            }
            catch
            {
                return 0;
            }
        }
        //Muestra mensaje del programa al usuario 
         static void mensaje(String texto)
        {
            if (texto.Length > 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine(" JJ:> {0}", texto);
                Console.WriteLine("   ");
                Console.WriteLine("\n    JJ:>Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        // Imprime pila 
        static void Imprimir(Stack pila1)
        {
            if (pila1.Count > 0)
            {
                Console.WriteLine("");
                foreach (int dato in pila1)
                {
                    Console.WriteLine(" | |");
                    if (dato < 10)
                        Console.WriteLine(" | 0{0} |", dato);
                    else
                        Console.WriteLine(" | {0} |", dato);
                    Console.WriteLine(" |______|");
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar ...");
                Console.ReadKey();
            }
            else
            {
                mensaje("La Pila esta vacia");
            }
        }
    }
}
