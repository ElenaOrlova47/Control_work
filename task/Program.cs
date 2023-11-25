//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

String[] CreateArray()
{
    Console.Write("Enter array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i += 1)
    {
        Console.Write($"Enter {i + 1} array element: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i += 1)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
string[] ResultArray(string[] array)
{
    int k = 0;
    int z = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i].Length <= 3) k += 1;
    }
    string[] arrayRes = new string[k];
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i].Length <= 3)
        {
            arrayRes[z] = array[i];
            z += 1;
        }
    }
    return arrayRes;
}