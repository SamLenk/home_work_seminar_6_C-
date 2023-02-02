// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

/*Console.Write("Введите последовательность чисел через пробел: ");
int[] numS = Array.ConvertAll(Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

int count = 0;
    for (int i = 0; i < numS.Length; i++)
    {
        if (numS[i] > 0)
        {
            count++;
        }
    }
Console.WriteLine($"[{String.Join(", ", numS)}] ->{count}");    */


//Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив,
// но отсортированный по возрастанию(от меньшего числа к большему).

Console.Write("Введите последовательность чисел через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

SortArray (array);
Console.WriteLine($"[{String.Join(", ", array)}]");

void SortArray (int [] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        for (int j = i + 1; j <  array.Length; j++)
        {
            if (array[j] < array[i])
            {
                int temp = array[i]; 
                array[i] = array[j];
                array[j] = temp; 
            }
        }
        
    }
}