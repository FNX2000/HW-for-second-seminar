// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Output(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void OutPutDayOff(int number)
{
    switch(number)
    {
        case 1:
            Console.WriteLine("Это не выходной день");
            break;
        case 2:
            Console.WriteLine("Это не выходной день");
            break;
        case 3:
            Console.WriteLine("Это не выходной день");
            break;
        case 4:
            Console.WriteLine("Это не выходной день");
            break;
        case 5: 
            Console.WriteLine("Это не выходной день");
            break;
        case 6: 
            Console.WriteLine("Это выходной день");
            break;
        case 7: 
            Console.WriteLine("Это выходной день");
            break;
        default:
            Console.WriteLine("Вы ввели число, не соответствующее дню недели");
            break;
    }
}

Console.Clear();
int number = Output("Введите число, соответствующее дню недели: ");
OutPutDayOff(number);
