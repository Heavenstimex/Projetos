namespace Piramides.PiramideErros
{
    public class MeusErros() : Exception
    {
        public static void ErroDeFormato()
        {
            Console.WriteLine("Digite um valor valido.");
            Console.ReadKey();
            Console.Clear();
            Program.Menu();
        }
        public static void ErroDeAlcance()
        {
            Console.WriteLine("Digite um valor valido.");
            Console.ReadKey();
            Console.Clear();
            Program.Menu();
        }

        public static void ErroGenerico()
        {
            Console.Clear();
            Console.WriteLine("Ops, algo deu errado!! Nós estamos voltando para o Menu...");
            Thread.Sleep(2500);
            Program.Menu();
        }
        public static void ErroDeAlcanceTelaIntermediaria()
        {
            Console.WriteLine("Digite um valor valido.");
            Console.ReadKey();
            Console.Clear();
            Program.TelaIntermediaria();
        }


    }

}