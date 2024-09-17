class Program
{
    static void Main(string[] args)
    {
        // Initialiser den nye klassen i main scope.
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Add(1, 1));
        Console.WriteLine(calculator.Subtract(70, 1));

        // Brukerinput addere
        Console.WriteLine("enter value a (number)");
        int addA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter value b (number)");
        int addB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(calculator.Add(addA, addB));
        
        // Brukerinput subtrahere
        Console.WriteLine("enter value a (number)");
        int subA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter value b (number)");
        int subB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(calculator.Subtract(subA, subB));

        // Extraoppgave
        
    }
}
