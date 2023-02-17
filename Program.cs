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

        int a = 1;
        int b = 1;

        for (int i = 1; b <= n; i += 2)
        {
            a *= -1;
            sum += a * (1 / (i * Math.Pow(x, i)));
            b++;
        }

        sum = -(Math.PI / 2) + sum;

        Console.WriteLine(sum);
    }
}
