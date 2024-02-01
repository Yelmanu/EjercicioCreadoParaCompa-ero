namespace EjercicioCreadoParaCompañero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario el tamaño del vector
            Console.Write("Ingrese el tamaño del vector: ");
            int tamanyo;
            bool esEnteroTamaño = false;
            do
            {
                //Controlamos que sea un entero para el tamaño
                if(Int32.TryParse(Console.ReadLine(),out tamanyo))
                {

                    break;
                }
                else
                {
                    Console.WriteLine("*ERROR* Debe introducir un numero entero para el tamaño.");
                    Console.WriteLine("Ingrese el tamaño del vector: ");
                }
            } while (!esEnteroTamaño);

            // Inicializar el vector con valores introducidos
            int[] vector = new int[tamanyo];

            for (int i = 0; i < tamanyo; i++)
            {
                bool esEntero = false;
                do
                {
                    //Controlamos que introduzca un numero entero
                    Console.WriteLine("Introduzca un valor: ");
                    if(Int32.TryParse(Console.ReadLine(), out vector[i]))
                    {
 
                        break;
                    }
                    else
                    {
                        Console.WriteLine("*ERROR*Introduzca un numero entero");
                    }
                    
                } while (!esEntero);
            }
            Array.Sort(vector);
            Array.Reverse(vector);
            Console.WriteLine("VECTOR ORDENADO DE MAYOR A MENOR");
            for (int j = 0; j < vector.Length; j++)
            {
                // Mostrar el vector después de ordenar
                Console.WriteLine(vector[j]);
            }
        }
    }
}
