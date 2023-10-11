/* Напишите программу, которая найдет максимальное из 9 чисел
(не используя цикл)
*/
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

// Это мы создали метод нахождения максимального из трех чисел (в общем виде) 

int a1 = 45;
int b1 = 21;
int c1 = 33;
int a2 = 2;
int b2 = 18;
int c2 = 9;
int a3 = 14;
int b3 = 36;
int c3 = 20;

/* int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Это более длинный способ решения. Ниже более короткий, в одну строку */

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);
