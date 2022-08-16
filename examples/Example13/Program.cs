// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void GettingPreparingOutPut(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    if(number<100)
    {
        Console.WriteLine("Третьей цифры нет");
       
    }
    else
    {
        while(number > 999)
        {
            number = number /10;
        }
        OutputLastDigit(number);
    }  
}
void OutputLastDigit(int number)
{ 
        Console.WriteLine(number%10);
}

Console.Clear();
GettingPreparingOutPut("Введите число: ");
