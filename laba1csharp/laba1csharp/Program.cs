//Разработать класс, инкапсулирующий двумерный массив. Класс должен
//содержать поля и методы, необходимые для реализации приведенного ниже
//задания к ЛР. Номер варианта задания соответствует порядковому номеру
//студента с списке группы
//Вариант 10

namespace laba1csharp
{
    public class Matrix
    {

        public int rows;
        public int columns;
        public int[,] array;

        // конструктор для ввода массива с клавиатуры
        public Matrix(int nRows, int nColumns)
        {
            rows = nRows;
            columns = nColumns;

            array = new int[nRows, nColumns];

            Console.WriteLine("Введите по строкам {0}x{1} элементов целочисленного двухмерного массива", rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    //проверка на правильность ввода
                    if (!int.TryParse(Console.ReadLine(), out array[i, j]))
                    {
                        Console.WriteLine("Неверный ввод");
                        j--;
                    }
                    else
                    {
                        //fix System.FormatException
                        if (array[i, j] > 1000000000)
                        {
                            Console.WriteLine("Неверный ввод");
                            j--;
                        }

                    }     
                }
            }
        }

        //generate random matrix
        public Matrix(int nRows, int nColumns, int min)
        {
            rows = nRows;
            columns = nColumns;
            
            array = new int[nRows, nColumns];

            Random rnd = new();

            //сгенерировать значения которые по модулю не превышают 10
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Math.Abs(rnd.Next(min, 10));
                }
            }
        }

        //вывод элементов массива
        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0, 5}", array[i, j]);
                }
                Console.WriteLine();
            }
        }


        //Среди тех столбцов целочисленной матрицы размером 3 строки, 5
        //столбцов, которые содержат только такие элементы, значения которых по
        //модулю не превышают 10, найдите столбец с минимальным произведением
        //элементов.

        private int SumColumn(int j)
        {
            int sum = 1;
            for (int i = 0; i < rows; i++)
            {
                sum *= array[i, j];
            }
            return sum;
        }

        private int IsMinColumn()
        {
            int min = SumColumn(0);
            int minIndex = 0;
            for (int j = 1; j < columns; j++)
            {
                if (SumColumn(j) < min)
                {
                    min = SumColumn(j);
                    minIndex = j;
                }
            }
            return minIndex;
        }

        static void Main(string[] args)
        {
            Matrix matrix = new(3, 5);
            Console.WriteLine("Введённая пользователем матрица: ");
            matrix.Print();
            Console.WriteLine("----------------------------------------------");


            Matrix matrix2 = new Matrix(3, 5, -6);
            Console.WriteLine("Сгенерированная матрица: ");
            matrix2.Print();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Столбец с минимальным произведением элементов: {0}", matrix2.IsMinColumn() + 1);

        }
    }
}