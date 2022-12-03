Console.Write("Give my a namber: ");
int numder = Convert.ToInt32(Console.ReadLine());
if (numder <= 99)
{
    Console.Write("\n3 digits not included");
}
else
{
    if (numder >= 100 && numder < 1000)
    {
        var thee = numder % 10;
        Console.Write($"\nthird digit of the number: {thee} ");
    }

    if (numder >= 1000)
    {
        string fake_number = numder.ToString();  // кривой способ
        Console.Write($"\nthird digit of the number: {fake_number[2]}");
    }

    // array
    // if( numder >=100)  
    // { 
    //  char[] myArray = numder.ToString().ToCharArray();
    //  Console.WriteLine($"\nthird digit of the number: {myArray[2]}");
    // }

}
