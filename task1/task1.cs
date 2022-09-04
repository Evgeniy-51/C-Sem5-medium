// // Задача 1 Реализовать алгоритм, который выводит на экран возрастающую
// последовательность случайных чисел от 1 до 1000. Как только сумма цифр
// очередного числа в последовательности достигнет 26, остановить генерацию,
// вывести на экран сообщение «Stop».

Console.Clear();

int sumCounter(int num)
{
    int sum = 0;
    while (num != 0)
    {
        int dig = num % 10;
        sum += dig;
        num = num / 10;
    }
    return sum;
}

Random rnd = new Random();
int minLim = 1;
int sum = 0;
string line = "";

while (minLim <= 1000)
{
    int num = rnd.Next(minLim, 1000);
    line += num.ToString() + " ";
    sum = sumCounter(num);

    if (sum >= 26)
    {
        System.Console.WriteLine(line + "Stop");
        minLim = 9999;
    }
    else
    {
        minLim = num + 1;
    }
}
