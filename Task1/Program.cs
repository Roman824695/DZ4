int ReadInt(string message)
{
    Console.Write(message + "->");
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadInt("Введите первое число");
int number2 = ReadInt("Введите второе число");

int[] numbers = new int[number2];


for(int i = 0; i < number2; i++)
{
    numbers[i] = number;
}

int result = 1;

for(int i = 0; i < number2; i++)
{
result = result * numbers[i];
}

Console.Write(result);