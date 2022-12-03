Console.Write("\nВведите чисдо которое проверить на кратность: ");
int numder = Convert.ToInt32(Console.ReadLine());

Console.Write("\n1 кратное число: ");
int numder_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("\n2 кратное число: ");
int numder_2 = Convert.ToInt32(Console.ReadLine());

if (numder % numder_1 == 0 && numder % numder_2 == 0)
{
    Console.Write($"\nЧисло \"{numder}\" кратно числу \"{numder_1}\" и кратно числу \"{numder_2}\"");
}

else
{
    if (numder % numder_1 != 0 && numder % numder_2 == 0)
    {
        Console.Write($"\nЧисло \"{numder}\" не кратно числу \"{numder_1}\" и кратно числу \"{numder_2}\"");
    }

    if (numder % numder_1 == 0 && numder % numder_2 != 0)
    {
        Console.Write($"\nЧисло \"{numder}\" кратно числу \"{numder_1}\" и не кратно числу \"{numder_2}\"");
    }

    if (numder % numder_1 != 0 && numder % numder_2 != 0)
    {
        Console.Write($"\nЧисло \"{numder}\" не кратно числу \"{numder_1}\" и не кратно числу \"{numder_2}\"");
    }
}