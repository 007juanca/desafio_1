namespace desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("estimado usuario ¿cómo se llama? ");
            string nombre = Console.ReadLine();
            Console.WriteLine("colocar los ingresos de los ultimos 3 meses");

            Console.WriteLine("antepenultimo ingreso: ");
            int Ingreso1 = int.Parse(Console.ReadLine());
            Console.WriteLine("penultimo ingreso: ");
            int Ingreso2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ultimo ingreso: ");
            int Ingreso3 = int.Parse(Console.ReadLine());

            int suma = Ingreso1 + Ingreso2 + Ingreso3;
            int promedio = suma / 3;

            Console.WriteLine("señor@: " + nombre);
            Console.WriteLine("el total de ingresos es de: Q" + suma);
            Console.WriteLine("el promedio de los ultimos 3 meses es de: Q" + promedio);

            Console.Read();
        }
    }
}