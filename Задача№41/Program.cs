// int sum(int[] array)
// {
//     int m = 0;
//     for (int i = 0; i < array.Length; i++)
//     {   array[i] = new Random().Next(-100, 101); // [-100, 100]
//         Console.Write($" {array[i]}");
//         if (array[i] > 0) 
//         m++;       
//     }
//         Console.WriteLine();
//         return(m);
// }
// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// Console.Write($"Количество положительных чисел = {sum(array)}");


Console.Write("Введите числа через запятую и пробел: ");
int[] numbers = InputNum(Console.ReadLine()!);
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0) sum++;
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");


int[] InputNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')  count++;
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("]");
}

// Console.Clear(); 
// Console.Write("Введите количество чисел: "); 
//     int count = int.Parse(Console.ReadLine()!); 
//     int positiveCount = 0; 
//     for (int i = 0; i < count; i++) { 
//         Console.Write($"Введите число {i + 1}: "); 
//         int number = int.Parse(Console.ReadLine()!); 
//         if (number > 0) { 
//             positiveCount++; 
//         } 
//     } 
 
// Console.WriteLine($"Количество положительных чисел: {positiveCount}");