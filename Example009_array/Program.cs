/* Напишите программу, которая найдет в массиве элемент со значением, 
которое совпадает с тем значением, которое ввел пользователь. 
Напр., "найти 12"- "12 находится на 5 месте". 
*/
int[] array = { 2, 4, 18, 5, 9, 18 };

int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index); 
        break; 
    } 
    index++;
}

