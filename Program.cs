// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

string[] arrayOne = new string[] {"77", "rain", "people", "account", "45", "one", "two", "three","1234", "to","45897"};
string[] arrayTwo = new string[arrayOne.Length];

void SecondArray(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if (arrayOne[i].Length <= 3)
        {
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Clear();
SecondArray(arrayOne, arrayTwo);
Console.Write("Исходный массив -> ");
PrintArray(arrayOne);
Console.Write("Образованный из исходного массив -> ");
PrintArray(arrayTwo);

