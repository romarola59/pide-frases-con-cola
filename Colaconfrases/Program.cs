using System;
using System.Collections;

namespace Colaconfrases
{
    public class Program
    {
        public static void Main()
        {
            ///Crea un programa que pida frases al usuario, hasta que introduzca una frase vacia.
            ///En ese momento mostrara todas las ,frases ingresadas

            string frase;
            int cont = 0;

            Queue miCola = new Queue();  // genera la cola de nombre miCola y la inicia como cola

            do
            {
                Console.WriteLine("Ingrese la frase: ");
                frase = Convert.ToString(Console.ReadLine());
                miCola.Enqueue(frase);
                cont = cont + 1;
            }
            while (frase != " ");

              Console.WriteLine("Las frases infresadas son: ");

            for (byte i = 0; i < cont + 1; i++) // arma el buclne para recorrer la cola
            {
                frase = (string)miCola.Dequeue(); // desencola la cola con Dequeue
                Console.WriteLine(frase);         // imprime por pantalla

            }
            Console.ReadKey();










        }







    }
}
