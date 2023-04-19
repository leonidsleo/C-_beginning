// проект для циклических задач
Console.Clear();
//Console.SetCursorPosition(10, 4); команда которая будет рисовать
//Console.WriteLine("+"); рисуем плюсиком

int xa = 20, ya = 1, //задаем координаты точек
    xb = 1, yb = 15,
    xc = 40, yc = 15;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = ya;

int count = 0;

while(count < 10000)
{

    int what = new Random().Next(0, 3); //выбираем случайные числа от 0 до 2 включ
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; //можно указать count++;
}