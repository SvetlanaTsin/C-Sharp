Console.Clear();
// Console.SetCursorPosition(10, 4);
// System.Console.WriteLine("+");

int xA = 40, yA = 1,
    xB = 1, yB = 30,
    xC = 80, yC = 30;

Console.SetCursorPosition(xA, yA);
System.Console.WriteLine("+");

Console.SetCursorPosition(xB, yB);
System.Console.WriteLine("+");

Console.SetCursorPosition(xC, yC);
System.Console.WriteLine("+");

int x = xA, y = yA;

int count = 0;

while (count < 10);
{
    int what = new Random().Next(0, 3); // [0, 3) 0 1 2
    if (what == 0)
    {
        x = (x + xA) / 2;
        y = (y + yA) / 2;
    }

    if (what == 1)
    {
        x = (x + xB) / 2;
        y = (y + yB) / 2;
    }

    if (what == 2)
    {
        x = (x + xC) / 2;
        y = (y + yC) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}
