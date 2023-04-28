// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Введите размер массива --> ");
int size = Convert.ToInt32(Console.ReadLine());

int[] createArray = CreateArray(size);
PrintArray(createArray);
int howNumberMoreZero = HowNumberMoreZero(createArray);
Console.WriteLine();
Console.WriteLine($"Чисел больше 0 = {howNumberMoreZero}");

int[] CreateArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int HowNumberMoreZero(int[] arr)
{
    int number = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) number++;
    }
    return number;
}