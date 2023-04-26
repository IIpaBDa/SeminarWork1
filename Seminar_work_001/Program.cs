int a = ReadInt("Введите число");
int b = ReadInt("Введите число");
int c = ReadInt("Введите число");

int ReadInt(string argument) // проверка на число
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число!");
        Console.Write(argument);
    }
    return i;
}

void Triangle(int a, int b, int c)
{
    if (a + b > c && b + c > a && c + a > b)
    {
        System.Console.WriteLine("треугольник ДА");
    }
    else
    {
        System.Console.WriteLine("Треуголник НЕТ");
    }
}

Triangle(a, b, c);



// int x = ReadInt("Введите число ");
// int ReadInt(string argument) // проверка на число
// {
//     Console.Write(argument);
//     int i;
//     while (!int.TryParse(Console.ReadLine(), out i))
//     {
//         System.Console.WriteLine("Это не число!");
//         Console.Write(argument);
//     }
//     return i;
// }

// void ConvertTo2Nnb(int x)
// {
//     string ost = "";
//     while (x > 0)
//     {
//         ost =ost + x % 2;
//         x = x / 2;
//     }
//     for (int i = ost.Length - 1; i >= 0; i--)
//     {
//         System.Console.Write(ost[i]);
//     }
// }

// ConvertTo2Nnb(x);



// System.Console.WriteLine("Введите координату X1: ");
//     double x1 = int.Parse(Console.ReadLine());

//     System.Console.WriteLine("Введите координату Y1: ");
//     double y1 = int.Parse(Console.ReadLine());

//     System.Console.WriteLine("Введите координату X2: ");
//     double x2 = int.Parse(Console.ReadLine());

//     System.Console.WriteLine("Введите координату Y2: ");
//     double y2 = int.Parse(Console.ReadLine());

//         double resalt = Math.Sqrt((x2 - x1) * (x2-x1) + (y2-y1)*(y2-y1));

//         System.Console.WriteLine($"Растояние между точками ({x1}, {y1}) и ({x2}, {y2}) состовляет: {resalt}");





//Треугольник по координатам!!!

// void Triangle(double a, double b, double c)
// {
//     if (a + b > c && b + c > a && c + a > b)
//     {
//         System.Console.WriteLine("треугольник ДА");
//     }
//     else
//     {
//         System.Console.WriteLine("Треуголник НЕТ");
//     }
// }

// double Dlin(int x1, int y1,int x2, int y2 )
// {
// /*System.Console.WriteLine("Введите координату X1: ");
//     double x1 = int.Parse(Console.ReadLine());

//     System.Console.WriteLine("Введите координату Y1: ");
//     double y1 = int.Parse(Console.ReadLine());

//     System.Console.WriteLine("Введите координату X2: ");
//     double x2 = int.Parse(Console.ReadLine());

//     System.Console.WriteLine("Введите координату Y2: ");
//     double y2 = int.Parse(Console.ReadLine());
// */
//     double resalt = Math.Sqrt((x2 - x1) * (x2-x1) + (y2-y1)*(y2-y1));

//     //System.Console.WriteLine($"Растояние между точками ({x1}, {y1}) и ({x2}, {y2}) состовляет: {resalt}");
//     return resalt;
// }


// Triangle(Dlin(1, 2, 3, 2),Dlin(2, 4, 2, 4),Dlin(3, 1, 1, 3));




// Stack<int> convertedNumber = new Stack<int>();

// Console.WriteLine("ToDO");
// int number = int.Parse(Console.ReadLine());

// while (number >= 1)
// {
// 	convertedNumber.Push(number % 2);
// 	number = number / 2;
// }
// Console.WriteLine();
// while (convertedNumber.TryPop(out int i))
// {
// 	Console.Write(i);
// }





// Queue<int> convertedNumber = new Queue<int>();

// Console.WriteLine("ToDO");
// int number = int.Parse(Console.ReadLine());

// while (number >= 1)
// {
// 	convertedNumber.Enqueue(number % 2);
// 	number = number / 2;
// }
// Console.WriteLine();
// while (convertedNumber.TryDequeue(out int i))
// {
// 	Console.Write(i);
// }





// List<string> list = new List<string>();

// list.Add("1");
// list.Add("A");
// list.Add("B");
// list.Add("C");
// list.Add("D");


// Console.WriteLine(list[0]);
// Console.WriteLine(list[1]);
// Console.WriteLine(list[2]);
// Console.WriteLine(list[3]);
// Console.WriteLine(list[4]);



// 


