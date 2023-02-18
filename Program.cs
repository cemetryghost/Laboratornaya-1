internal class Program
{
    static void Main(string[] args)
    {
        int x;
        int n;
        double sum = 0;

        Console.WriteLine("Число X должно быть меньше -1 (x < -1)");
        do
        {
            Console.Write("Введите X: ");
            x = Convert.ToInt32(Console.ReadLine());
        } while (!(x < -1));

        Console.WriteLine("Количество шагов должно быть больше 0");
        do
        {
            Console.Write("Введите N: ");
            n = Convert.ToInt32(Console.ReadLine());
        } while (!(n > 0));

        int znak = 1;
        int step = 1; 

        for (int i = 1; step <= n; i += 2)
        {
            znak *= -1;
            sum += znak * (1 / (i * Math.Pow(x, i)));
            step++;
        }

        sum = -(Math.PI / 2) + sum;

        Console.WriteLine(sum);
    }
}

