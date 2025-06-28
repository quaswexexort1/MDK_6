public static class Matrix
{
    public static double NormOfMatrixCalculator__M(double[,] matrix)
    {
        int rows = matrix.GetLength(0);                    
        int cols = matrix.GetLength(1);                   
        double maximumSummaStolbov = 0;                   

                                                            
        for (int j = 0; j < cols; j++)
        {
            double SummaStolbov = 0;                             

                                                               
            for (int i = 0; i < rows; i++)
            {
                SummaStolbov += Math.Abs(matrix[i, j]);          
            }

            maximumSummaStolbov = Math.Max(maximumSummaStolbov, SummaStolbov); 
        }
         
        return maximumSummaStolbov;                                
    }

    public static double NormOfMatrixCalculator__L(double[,] matrix)
    {
        int rows = matrix.GetLength(0);                                         
        int cols = matrix.GetLength(1);                                   

        double MaximumSummaStrok = 0;                                      

        // Перебираем строки матрицы
        for (int i = 0; i < rows; i++)
        {
            double SummaStrok = 0;                                      

                                                                         
            for (int j = 0; j < cols; j++)
            {
                SummaStrok += Math.Abs(matrix[i, j]);                    
            }

            MaximumSummaStrok = Math.Max(MaximumSummaStrok, SummaStrok);
        }

        return MaximumSummaStrok;                                        
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

