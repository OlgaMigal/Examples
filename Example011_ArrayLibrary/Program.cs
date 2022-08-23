// Взять метод, передать в него массив, 
// и заполнить массив нужным количеством элементов.

//1. создаём метод заполнения массива псевдослучайными значениями от 1 до 10

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
// 2. Создаём метод печати массива

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}
//3. Создаём метод нахождения индекса того элемента массива, который совпадёт с нашим числом
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int position = -1;
    int index = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

//5. Запускаем метод заполнения для массива array и печатаем его,
// затем переходим на новую строку.
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

//6. Выводим на печать индекс совпавшего элемента
int pos = IndexOf(array, 4);
Console.WriteLine("Индекс совпавшего элемента = " + pos);