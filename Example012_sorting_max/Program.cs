// Упорядочить массив по возрастанию и вывести его

Console.Clear();

int[] arr = {1, 9, 4, 3, 2, 6, 7, 4, 1};

void PrintArray (int[] arr) 
{
    int count = arr.Length; 
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine(); 
}

void SelectionSort2(int[] arr) 
{
    for (int i = 0; i < arr.Length - 1; i++) // почему length-1??
    {
        int maxNumberPosition = i; 

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxNumberPosition]) 
            {
                maxNumberPosition = j;
            }
        }

        int temp = arr[i]; 
        arr[i] =  arr[maxNumberPosition];
        arr[maxNumberPosition] = temp;
    }

}

PrintArray(arr);

SelectionSort2(arr);
PrintArray(arr);
