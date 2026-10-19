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

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// {
//     Console.WriteLine("Число чётное");
// }
// else
// {
//     Console.WriteLine("Число нечётное");
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// Console.WriteLine("Введите год: ");
// int year = Convert.ToInt32(Console.ReadLine());
// if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
// Console.WriteLine("Этот год високосный, в феврале 29 дней");
// else
// {
//     Console.WriteLine("Этот год не високосный, в феврале 28 дней");
// }
Console.WriteLine("Введите ваш возраст: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите тип места (плацкарт, купе, СВ): ");
string type = Console.ReadLine();
double basePrice = 0;
bool isValidSeat = true;
double discount = 0.0;

switch (type)
        {
            case "плацкарт":
                basePrice = 1000;
                break;
            case "купе":
                basePrice = 2000;
                break;
            case "св":
                basePrice = 3000;
                break;
            default:
                isValidSeat = false;
                break;
        }

if (age < 10)
        {
            discount = 0.50; // Дети до 10 лет — 50%
        }
        else if (age >= 18 && age <= 25)
        {
            discount = 0.30; // Студенты (18–25 лет) — 30%
        }
        else if (age >= 60)
        {
            discount = 0.40; // Пенсионеры (60 лет и старше) — 40%
        }

double finalPrice = basePrice * (1 - discount);

Console.WriteLine();
        Console.WriteLine($"Базовая стоимость: {basePrice}");
        Console.WriteLine($"Размер скидки: {discount * 100}");
        Console.WriteLine($"Итоговая стоимость билета: {finalPrice}");