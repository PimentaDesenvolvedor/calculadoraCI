namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Type '<number1> <number2>'.");
            // var input = Console.ReadLine();
            // var inputArgs = input?.Split(' ');
            // var number1 = Convert.ToInt32(inputArgs[0]);
            // var number2 = Convert.ToInt32(inputArgs[1]);

            calculaSoma(10, 20);
        }

        private static void calculaSoma(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
    }
}