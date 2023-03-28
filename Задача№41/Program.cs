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


// using System;
// using System.Linq;

// /*
// System.Linq в C# предоставляет набор методов для работы с коллекциями 
// и последовательностями данных. Он включает в себя такие методы, 
// как Select, Where, OrderBy, GroupBy, Join и многие другие, 
// которые позволяют фильтровать, сортировать, группировать и соединять данные 
// в различных форматах. 

// System.Linq обеспечивает более удобный и эффективный 
// способ работы с данными, чем использование циклов и условных операторов.
// */


// class ArraysClass {
//   static void Main() {
  
//     Console.WriteLine("Введите цифры разделяя пробелом: ");
//     string count = Console.ReadLine()!; 

//     /*
//     Метод Split(' ') — Split (Англ. разделителить) 
    
//     Разбивает строку count на подстроки, используя пробел в 
//     качестве разделителя. Результатом выполнения метода будет массив строк,
//     содержащий все подстроки, полученные путем разбиения исходной 
//     строки по пробелам. 
    
//     Например, если count содержит строку "1 2 3", то результатом 
//     выполнения метода будет массив строк с элементами "1", "2" и "3".
    
//     ---------
    
//     Метод Select() принимает в качестве аргумента функцию, которая 
//     преобразует каждый элемент исходной последовательности. 
    
//     В данном случае, Int32.Parse() - это функция, которая преобразует 
//     каждый элемент в целое число. 
    
//     Метод ToArray() создает массив из результирующей последовательности. 
//     Таким образом, данный код преобразует исходную последовательность 
//     в массив целых чисел, используя функцию 
//     Int32.Parse() для преобразования каждого элемента.
//     */

//     var ints = count.Split(' ').Select(Int32.Parse).ToArray();

//     /*
//     Метод string.Join(", ", ints) — Join (Англ. соединить) 
    
//     Oбъединяет элементы указанной коллекции 
//     или массива в одну строку, используя указанный разделитель. 
//     В данном случае, метод string.Join(", ", ints) объединяет элементы 
//     массива ints в одну строку, разделяя их запятой и пробелом. 
        
//     Например, если ints содержит элементы 1, 2 и 3, то результатом 
//     выполнения метода будет строка "1, 2, 3".
//     */
    
//     Console.WriteLine("Результат: " + "[" + string.Join(", ", ints) + "]");
//     // Результат [1, 2, 3]

//   }
  
// }



