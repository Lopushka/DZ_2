// Первый вариант задания/

Console.Write("Введите число от 100 до 999: ");
int numder = Convert.ToInt32(Console.ReadLine());
if (numder < 100)
{
    Console.Write("\nПрочти еще раз первое сообщение!!");

}
if (numder > 999)
{
    Console.Write("\nПрочти еще раз первое сообщение!!");

}

while (numder >= 100 && numder <= 999)
{
    numder /= 10;
    var too = numder % 10;
    Console.WriteLine($"\nвторая цифра введенного числа: {too}");
    break;
}

// // новый вариант задания (самое простое решение)

// Console.Write("\nГенерирую случайное число");
// Random rnd = new Random();
// int roll = rnd.Next(100, 1000);
// Console.WriteLine($"\nСлучайное число: {roll}");
// roll /= 10;
// var too = roll % 10;
// Console.WriteLine($"\nВторая цифра случайного числа: {too}");


//  через массив
// char[] myArray = roll.ToString().ToCharArray();
// Console.WriteLine($"\nВторая цифра вашего числа это: {myArray[1]}");