int number1 = int.Parse(Console.ReadLine());
char calculateOperator = char.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

double result = Calculate(number1, calculateOperator, number2);
Console.WriteLine(result);

 static double Calculate( int number1, char calculateOperator, int number2)
{
    double result = 0;
    switch (calculateOperator) {
        case '+':
            result= number1 + number2;
            break;
        case '-':
            result = number1 - number2;
            break;
        case '*':
            result = number1 * number2;
            break;
        case '/':
            result = number1 / number2;
            break;

    }
    return result;
}