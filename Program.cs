// int age = 21;
// if (age >= 21) {
//     Console.WriteLine("Доступ разрешён");
// }
// Console.WriteLine("Программа продолжает работу");

// int age = 15;
// if (age >= 18)
// {
//     Console.WriteLine("Доступ разрешён");
// } else
// {
//     Console.WriteLine("Доступ запрещён");
//     Console.WriteLine($"До совершеннолетия осталось {18 - age} лет");
// }

// int age = 60;
// if (age < 13)
// {
//     Console.WriteLine("Ребёнок");
// } else if (age < 18)
// {
//     Console.WriteLine("Подросток");
// }
// else if (18 <= age && age <= 59)
// {
//     Console.WriteLine("Взрослый");
// }
// else
// {
//     Console.WriteLine("Пенсионер");
// }

// int age = 16;
// double height = 1.45;
// bool isAdult = true;
// if (age >= 14 && height >= 1.5)
// {
//     Console.WriteLine("Можно кататься");
// }
// else if (age < 14 && height < 1.5)
// {
//     Console.WriteLine("Пока нельзя");
// } 

// else if (isAdult == true)
// {
//     Console.WriteLine("Можно кататься с сопровождающим");
// }

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}