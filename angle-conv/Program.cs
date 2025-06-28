// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine($"Invalid syntax: use angle-conv -h for help.");
            return;
        }
        if (args[0] == "-d")
        {
            if (args.Length != 2)
            {
                Console.WriteLine($"Invalid syntax: use angle-conv -h for help.");
                return;
            }
            float result = 0;

            if (!float.TryParse(args[1], out result))
            {
                Console.WriteLine($"Invalid input: {args[1]} is not a valid number.");
                return;
            }
            float radians = result / 180f * MathF.PI;

            Console.WriteLine($"{args[1]} degrees is equals to {radians} radians.");
        }

        else if (args[0] == "-r")
        {
            if (args.Length != 2)
            {
                Console.WriteLine($"Invalid syntax: use angle-conv -h for help.");
                return;
            }
            float result = 0;
            if (!float.TryParse(args[1], out result))
            {
                Console.WriteLine($"Invalid input: {args[1]} is not a valid number.");
                return;
            }
            float degrees = result * 180f / MathF.PI;

            Console.WriteLine($"{args[1]} radians is equals to {degrees} degrees.");
        }

        else if (args[0] == "-h")
        {
            
            Console.WriteLine("Usage:\n");
            Console.WriteLine($"angle-conv -d <degrees> | Converts input to radians.");
            Console.WriteLine($"angle-conv -r <radians> | Converts input to degrees.");
        }

        else
        {
            Console.WriteLine($"Invalid syntax: use angle-conv -h for help.");
        }
    }
}