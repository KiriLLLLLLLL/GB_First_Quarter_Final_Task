// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


void FillArray (string[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = Console.ReadLine();
    }
}

void PrintArray (string[] collection)
{
    int position = 0;
    while (position < collection.Length)
    {
        Console.Write($"{collection[position]}  ");
        position++;
    }
}

string[] FindElements (string[] collection)
{
    int count = 0;

    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i].Length <= 3) count++;
    }

    string[] newArray = new string[count];
    int j = 0;

    for (int i = 0; i < collection.Length; i++)
    {

        if (collection[i].Length <= 3)
        {
            newArray[j] = collection[i];
            j++;
        }

    }
    return newArray;
}



Console.WriteLine("Введите длинну массива:");
int count = int.Parse(Console.ReadLine());
string[] array = new string[count];
Console.WriteLine($"Введите элементы массива, не более {count}");

FillArray(array);
Console.WriteLine();
string[] newArray = FindElements(array);
PrintArray(newArray);