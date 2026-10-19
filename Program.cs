// int age = 21;
// if (age >= 21) {
//     Console.WriteLine("Доступ разрешён");
// }
// Console.WriteLine("Программа продолжает работу");

int age = 15;
if (age >= 18)
{
    Console.WriteLine("Доступ разрешён");
} else
{
    Console.WriteLine("Доступ запрещён");
    Console.WriteLine($"До совершеннолетия осталось {18 - age} лет");
}