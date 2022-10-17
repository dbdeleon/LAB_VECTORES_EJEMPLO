using System;

namespace LAB_VECTORES_EJEMPLO
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros; /*declaramos vector */
            numeros = new int[5]; /*indicamos el tamaño de vector*/
            int suma = 0;
            string numero2;
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Ingrese un número");
                numero2 = Console.ReadLine();
                numeros[i] = int.Parse(numero2); 
                suma = suma + numeros[i];
            }
            Console.WriteLine("La suma total de su vector es:  "+suma);
        }
    }
}
