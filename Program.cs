//задание1
System.Console.WriteLine("Введите пятизначное число:");
string number = System.Console.ReadLine();
if (number.Length != 5)
{
    System.Console.WriteLine("Вы ввели не пятизначное число, попробуйте ввести число снова");
}
else 
{
    if (number[0] == number [4] && number[1] == number [3])
    {
        System.Console.WriteLine(number + " -> число палиндром");
    }
    else
    {
        System.Console.WriteLine(number + " -> это число не является палиндромом");
    }
}

//Задание2
int [] aCoordinate = new int[3];

System.Console.WriteLine("Введите координату X точки А");
aCoordinate[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки А");
aCoordinate[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки А");
aCoordinate[2] = Convert.ToInt32(Console.ReadLine());

int [] bCoordinate = new int[3];

System.Console.WriteLine("Введите координату X точки B");
bCoordinate[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки B");
bCoordinate[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки B");
bCoordinate[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((aCoordinate[0] - bCoordinate[0]),2) + Math.Pow((aCoordinate[1] - bCoordinate[1]),2) + Math.Pow((aCoordinate[2] - bCoordinate[2]),2)),2));

//Задание3

System.Console.WriteLine("Введите число:");
int N = Convert.ToInt32(System.Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}