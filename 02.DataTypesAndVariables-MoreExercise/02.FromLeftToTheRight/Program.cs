


int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    string[] line = Console.ReadLine().Split(" ");

    long left = long.Parse(line[0]);
    long right = long.Parse(line[1]);

    long bigger = left > right ? left : right;

    long sum = 0;
    long temp = (long)Math.Abs(bigger);

    while (temp > 0)
    {
        sum += temp % 10;
        temp /= 10;
    }
    Console.WriteLine(sum);
}
