public static class Matrix
{
    public static double NormOfMatrixCalculator__M(double[,] matrix)
    {
        int rows = matrix.GetLength(0);                              // Количество строк в матрице
        int cols = matrix.GetLength(1);                             // Количество столбцов в матрице

        double maximumSummaStolbov = 0;                           // Инициализируем максимальную сумму столбца

                                                                  // Перебираем столбцы матрицы
        for (int j = 0; j < cols; j++)
        {
            double SummaStolbov = 0;                               // Инициализируем сумму элементов текущего столбца

                                                                // Перебираем строки в текущем столбце
            for (int i = 0; i < rows; i++)
            {
                SummaStolbov += Math.Abs(matrix[i, j]);           // Добавляем модуль элемента к сумме столбца
            }

            maximumSummaStolbov = Math.Max(maximumSummaStolbov, SummaStolbov); // Обновляем максимальную сумму, если текущая больше
        }
         
        return maximumSummaStolbov;                                 // Возвращаем максимальную сумму столбца
    }

    public static double NormOfMatrixCalculator__L(double[,] matrix)
    {
        int rows = matrix.GetLength(0);                                            // Количество строк в матрице
        int cols = matrix.GetLength(1);                                       // Количество столбцов в матрице

        double MaximumSummaStrok = 0;                                         // Инициализируем максимальную сумму строки

        // Перебираем строки матрицы
        for (int i = 0; i < rows; i++)
        {
            double SummaStrok = 0;                                           // Инициализируем сумму элементов текущей строки

                                                                            // Перебираем столбцы в текущей строке
            for (int j = 0; j < cols; j++)
            {
                SummaStrok += Math.Abs(matrix[i, j]);                     // Добавляем модуль элемента к сумме строки
            }

            MaximumSummaStrok = Math.Max(MaximumSummaStrok, SummaStrok); // Обновляем максимальную сумму, если текущая больше
        }

        return MaximumSummaStrok;                                          // Возвращаем максимальную сумму строки
    }
}

public class abc
{
    public static void Main()
    {
        double[,] matrix =
        {
            { 1, 2, -3 },
            { -4, 5, 6 }
        };

        double normM = Matrix.NormOfMatrixCalculator__M(matrix);
        double normL = Matrix.NormOfMatrixCalculator__L(matrix);

        Console.WriteLine("||A||__M = " + normM); // Вывод: ||A||__M = 9
        Console.WriteLine("||A||__L = " + normL); // Вывод: ||A||__L = 15
    }
}

