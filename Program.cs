namespace EjercicioEstrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            EContexto contexto = null;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("PASEO DE ANIMALES \n");
            Console.Write($"\n[C] CHIHUAHUA \n[L] LABRADOR \n[H] HUSKY SIBERIANO  \nDigite su opcion SOLO con la inicial: ");
            string opcion = Console.ReadLine().ToLower();
            contexto = new EContexto(Fabrica.GetEstrategia(opcion));
            contexto.Ejecutar();

            Console.ReadKey();
            Main(args);
        }
    }
}