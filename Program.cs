//Задача 19. Напишите программу, которая принимает на вход пятизначное число (a1) и проверяет, является ли оно палиндромом

Console.Write("Введите пятизначное число: ");
int a1 = int.Parse(Console.ReadLine());

while(a1<10000 || a1>99999)
{
    Console.Write("Вы ввели не пятизначное число. Попробуйте еще раз: ");
    a1 = int.Parse(Console.ReadLine());
}

int edinici = a1%10;
int desjatki = (a1/10)%10;
int tysja4i = (a1/1000)%10;
int desjatkitysja4 = (a1/10000)%10;

if (edinici == desjatkitysja4 && desjatki == tysja4i)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}

//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double[] coordA = new double[3];
double[] coordB = new double[3];
int j;

for (j = 0; j < 3; j++)
{
    Console.WriteLine("Введите координаты точки A: ");
    coordA[j] = double.Parse(Console.ReadLine());
}

for (j = 0; j < 3; j++)
{
    Console.WriteLine("Введите координаты точки B: ");
    coordB[j] = double.Parse(Console.ReadLine());
}

double Resultat = Math.Sqrt(Math.Pow(coordB[0] - coordA[0], 2) + Math.Pow(coordB[1]  - coordA[1], 2) + Math.Pow(coordB[2]  - coordA[2], 2));


Console.WriteLine("Расстояние между векторами А и B ->  " + Resultat);

//Задача 23. Напишите программу, которая принимает на вход число (a) и выдаёт таблицу кубов чисел от 1 до a

Console.Write("Введите число: ");
double a = double.Parse(Console.ReadLine());
a = Math.Abs(a); //берем число по модудю, если ввели отрицательное число

Console.Write ("Таблица кубов числа "+a+" -> ");

for(int i=1; i<=a; i++)
{
    Console.Write(Math.Pow(i,3)+" ");
}