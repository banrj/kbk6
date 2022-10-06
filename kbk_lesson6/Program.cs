// Богомолов Даниил 3.1 вариант 13 исп2/1

Console.WriteLine("Введите n: ");
int number = int.Parse(Console.ReadLine());
double answer = 0;
int limit = 1;
int count = 0;
do
{
    double divider = Math.Pow(limit - 3, limit - 5) * (limit + 7);
    Console.WriteLine(Math.Pow(limit - 3, limit - 5) * (limit +7));
    Console.WriteLine("делитель" + divider);
    long dividend = 0;

    do
    {
        count += 1;
        dividend += count;
    } while (count != limit);
    limit++;

    Console.WriteLine("делимое" + dividend);
    answer += (divider / dividend);
} while (limit < number);


Console.WriteLine(answer);