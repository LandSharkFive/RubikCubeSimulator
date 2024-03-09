namespace CubeOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cube c = new Cube();

            c.PrintCross();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == null || input.Length == 0)
                    break;


                c.Move(input);
                c.PrintCross();
            }
        }

    }
}