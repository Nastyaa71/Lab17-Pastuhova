int[] scores = new int[7];
for (int i = 0; i < scores.Length; i++)
{
    Console.Write($"Результат {i + 1}: ");
    scores[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("\n»> Анализ результатов «<\n");
Console.WriteLine($"Сумма: {SumArray(scores)}");
Console.WriteLine($"Минимум: {FindMin(scores)}");
Console.WriteLine($"Максимум: {FindMax(scores)}");
Console.WriteLine($"Результатов 50 и больше: {CountAtLeast(scores, 50)}");

Console.Write("\nКакой результат найти: ");
int target = Convert.ToInt32(Console.ReadLine());
int index = FindIndex(scores, target);
if (index == -1)
{
    Console.WriteLine("Результат не найден");
}
else
{
    Console.WriteLine($"Первый индекс: {index}");
}




int SumArray(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}



int CountAtLeast(int[] numbers, int limit)
{
    int count = 0;
    foreach (int number in numbers)
    {
        if (number >= limit)
        {
            count++;
        }
    }
    return count;
}



int FindMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}



int FindMin(int[] numbers)
{
    int min = numbers[0];
    foreach (int number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
    }
    return min;
}



int FindIndex(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            return i;
        }
    }
    return -1;
}


Console.WriteLine(CountAtLeast(new int[] { 49, 50, 51 }, 50)); 
int[] test = { -10, -3, -25, -7 };
Console.WriteLine(FindMin(test)); 
Console.WriteLine(FindMax(test)); 
Console.WriteLine(FindIndex(scores, 60)); 
Console.WriteLine(FindIndex(scores, 100)); 