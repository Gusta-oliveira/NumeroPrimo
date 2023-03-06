internal class Program
{
    private static void Main(string[] args)
    {
        double digit_u;
        int count, primo = 0;

        Console.WriteLine("Informe o digito: ");
        digit_u = double.Parse(Console.ReadLine());

        for (count = 1; count <= digit_u; count++)
        {
        if (digit_u % count == 0)
        {
            primo++;
        }
        }
        if (primo == 2)
        {
            Console.WriteLine("Número primo");
        }
        else
        {
            Console.WriteLine("Numero não é primo");
        }
    }
}