// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обращаться к числу как к строке нельзя.

 int x, y;
Console.WriteLine("Введите число трёхзначное");
y = Convert.ToInt32(Console.ReadLine());
y = Math.Abs(y);
if (y>99 && y<1000) {x = y / 10 % 10;
Console.WriteLine("Вторая цифра справа: " + x); }
else {Console.WriteLine("Вы ввели не трёхзначное число");}



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Обращаться к числу как к строке нельзя.

int x, y, yx, countx;
Console.WriteLine("Введите минимум трёхзначное число");
y = Convert.ToInt32(Console.ReadLine());
y = Math.Abs(y);
if (y>99) {
yx=y;
 var count = (yx == 0) ? 1 : 0;
    while (yx != 0) {
        yx /= 10;
        count++; }
double county= Math.Pow(10, count-3);
countx = Convert.ToInt32(county);
x = y / countx % 10 ;
Console.WriteLine("Третье справа " + x); }
else 
Console.WriteLine("Третьей цифры не существует");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int x;
Console.WriteLine("Введите число  от 1 до 7, обозначающее день недели");
x = Convert.ToInt32(Console.ReadLine());
if (x>0 && x<6) {
Console.WriteLine("Будний день>"); }
else {Console.WriteLine("Выходной день");}


// Задача необязательная 2: по желанию идет за 2 необязательных

int x, y;
Console.WriteLine("Сколько программистов увидел робот?");
y = Convert.ToInt32(Console.ReadLine());
x = y % 10;
 if (y>10 && y<20) {Console.WriteLine("Робот произнесет: < " + y + " программистов! >"); }
else if (x==1)  {Console.WriteLine("Робот произнесет: < " + y + " программист! >");}
else if (x>=2 && x<=4)  {Console.WriteLine("Робот произнесет: < " + y + " программистa! >");}
else if (x>=5 && x<=9 || x==0)  {Console.WriteLine("Робот произнесет: < " + y + " программистов! >");}
else  {Console.WriteLine("Похоже, что робот не увидел программистов");}
