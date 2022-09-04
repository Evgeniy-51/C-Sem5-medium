// // Михаил интересуется созданием простых чисел. Его интересуют
// простые числа с некоторыми характеристиками:
// • число сгенерировано случайным образом;
// • его квадрат не оканчивается на 1;
// • сумма его цифр лежит в диапазоне от 10 до 20
// Сгенерировать пять простых чисел, удовлетворяющих пожеланиям
// Михаила, и вывести их на экран.

Console.Clear();

Random rnd = new Random();

bool isPrime(int num)  // проверка на простое
{
    if (num == 2) return true;

    for (int i = 2; i < Math.Sqrt(num); i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}

int createNum()  // создание числа
{
    int num = rnd.Next(2, 1000);
    int tempNum = num;
    int digSum = 0;

    while (tempNum != 0)
    {
        int dig = tempNum % 10;
        digSum += dig;
        tempNum = tempNum / 10;
    }
    return (isPrime(num) && (num * num) % 10 != 1 && digSum >= 10 && digSum <= 20) ? num : createNum();
}

string res = "";
for (int i = 0; i < 5; i++)
{
    res += createNum().ToString() + "  ";
}

Console.WriteLine(res);