//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

int[] CreateArrayInt(int size)
{
    int[] array = new int[size];
    Console.WriteLine($"Введите {size} любых целых чисел:");
    int user = 0;
    for (int i = 0; i < size; i++)
    {
        user = Convert.ToInt32((Console.ReadLine()));
        array[i] = user;
    }
    return array;
}

//метод выводит на печать массив.
void PrintArray(int[] array)
{
    //Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (i < array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
        }
    }
    //Console.Write("] ");
}

//метод ищет числа больше нуля.
int SearchNumbers (int [] arr)
{
int result = 0;
for (int i = 0; i <= arr.Length-1; i++)
{
   if (arr[i]>0) result++;
}
return result;
}

Console.WriteLine("Сколько числе вы хотите ввести?");
int m = Convert.ToInt32((Console.ReadLine()));
int[] array = CreateArrayInt(m);
PrintArray(array);
Console.WriteLine($" -> чисел больше нуля: {SearchNumbers(array)}");
