﻿// Упорядочить массив по возрастанию и вывести его

Console.Clear();

int[] arr = {1, 9, 4, 3, 2, 6, 7, 4, 1};

void PrintArray (int[] arr) // создаем метод, который выведет наш массив. В качестве аргумента - наш массив
{
    int count = arr.Length; // создаем счетчик для цикла

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{arr[i]} "); // пробегаем по всем значениям массива и выводим их
    }
    System.Console.WriteLine(); // после вывода массива будет пустая строка
}

void SelectionSort(int[] arr) // создаем метод, который упорядочит массив
{
    for (int i = 0; i < arr.Length - 1; i++) // почему length-1??
    {
        int minNumberPosition = i; // мы запоминаем позицию, на которой находится мин элемент

        for (int j = i + 1; j < arr.Length; j++) // запускаем этот цикл для неотсортированной части массива, она начинается с i+1
        {
            if (arr[j] < arr[minNumberPosition]) // сравниваем текущий элемент с тем, который мы считаем минимальным
            {
                minNumberPosition = j; // если текущий элемент меньше, то записываем его позицию как позицию мин элемента
            }
        }

        int temp = arr[i]; // во временную переменную мы кладем значение текущего элемента
        arr[i] =  arr[minNumberPosition]; // а в текущее значение кладем минимальное значение
        arr[minNumberPosition] = temp; // туда, где раньше был мин элемент, кладем временную переменную (где записан текущий элемент)
    }

}

PrintArray(arr);

SelectionSort (arr);
PrintArray(arr);