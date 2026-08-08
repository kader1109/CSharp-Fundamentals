using System.Runtime.Intrinsics.X86;

long number = long.Parse(Console.ReadLine());
number = Math.Abs(number);

int evenSum = GetSumOfEvenDigits(number);
int oddSum = GetSumOfOddDigits(number);

long result = GetMultipleOfEvenAndOdds(evenSum, oddSum);

Console.WriteLine(result);

static long GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
{
    return evenSum * oddSum;
}

static int GetSumOfEvenDigits(long number)
{
    int sum = 0;

    while (number > 0)
    {
        int digit = (int)(number % 10);

        if (digit % 2 == 0)
        {
            sum += digit;
        }

        number /= 10;
    }

    return sum;
}

static int GetSumOfOddDigits(long number)
{
    int sum = 0;

    while (number > 0)
    {
        int digit = (int)(number % 10);

        if (digit % 2 != 0)
        {
            sum += digit;
        }

        number /= 10;
    }

    return sum;
}
