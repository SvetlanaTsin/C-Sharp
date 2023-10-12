/* Напишите программу, которая находит индекс элемента, 
который совпадает с тем значением, которое ввел пользователь
- в общем случае. */

Console.Clear();

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
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    //int position = 0; в обычном случае
    int position = -1; // на случай, если в массиве не окажется нужного числа. Тогда в результатах выйдет индекс -1, а такого индекса не бывает. Это значит, "такой элемент не найден"
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создали новый массив, в нем 10 элементов
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 3);
System.Console.WriteLine(pos);