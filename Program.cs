using System;

class Program
{
    // Объявляем делегат для функции-фильтра
    delegate bool NumberFilter(int number);
    
    // Объявляем делегат для функции суммирования
    delegate int ArraySum(int[] array, NumberFilter filter);

    static void Main()
    {
        int[] numbers = { -5, 10, -3, 8, -1, 15, 0, -7 };
        
        // 1. Использование именованных методов
        ArraySum sumCalculator = CalculateSum;
        NumberFilter positiveFilter = IsPositive;
        NumberFilter negativeFilter = IsNegative;
        
        Console.WriteLine($"Сумма положительных: {sumCalculator(numbers, positiveFilter)}");
        Console.WriteLine($"Сумма отрицательных: {sumCalculator(numbers, negativeFilter)}");
        Console.WriteLine();

        // 2. Использование анонимных методов
        ArraySum sumAnonymous = delegate(int[] arr, NumberFilter filter)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                if (filter(num)) sum += num;
            }
            return sum;
        };
        
        NumberFilter positiveAnonymous = delegate(int n) { return n > 0; };
        NumberFilter negativeAnonymous = delegate(int n) { return n < 0; };
        
        Console.WriteLine($"Сумма положительных (анонимный): {sumAnonymous(numbers, positiveAnonymous)}");
        Console.WriteLine($"Сумма отрицательных (анонимный): {sumAnonymous(numbers, negativeAnonymous)}");
        Console.WriteLine();

        // 3. Использование лямбда-выражений
        ArraySum sumLambda = (arr, filter) =>
        {
            int sum = 0;
            foreach (int num in arr) 
                if (filter(num)) sum += num;
            return sum;
        };
        
        NumberFilter positiveLambda = n => n > 0;
        NumberFilter negativeLambda = n => n < 0;
        
        Console.WriteLine($"Сумма положительных (лямбда): {sumLambda(numbers, positiveLambda)}");
        Console.WriteLine($"Сумма отрицательных (лямбда): {sumLambda(numbers, negativeLambda)}");
    }

    // Именованные функции-фильтры
    static bool IsPositive(int number) => number > 0;
    static bool IsNegative(int number) => number < 0;
    
    // Именованная функция суммирования
    static int CalculateSum(int[] array, NumberFilter filter)
    {
        int sum = 0;
        foreach (int num in array)
        {
            if (filter(num)) sum += num;
        }
        return sum;
    }
}
