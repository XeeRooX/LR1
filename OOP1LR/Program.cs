using System;




namespace OOP1LR
{
    class Program
    {
       // const int n = 10;
        static void Main(string[] args)
        {
            // Колличество строк и столбцов 
            const int n = 10;
            // Задаются чмсла начиная с 1
            
            int[,] arr = new int[n,n];
            Sort(ref arr);
            // Выводим массив
            Print(arr);
          
            
        }
        static void Sort(ref int[,] arr) {
            int n = (int)Math.Sqrt(arr.Length);
            int num = 1;
            // Сначала зваолним периметр массива по часовой стрелке
            for (int y = 0; y < n; y++)
            {
                arr[0, y] = num;
                num++;
            }
            for (int x = 1; x < n; x++)
            {
                arr[x, n - 1] = num;
                num++;
            }
            for (int y = n - 2; y >= 0; y--)
            {
                arr[n - 1, y] = num;
                num++;
            }
            for (int x = n - 2; x > 0; x--)
            {
                arr[x, 0] = num;
                num++;
            }
            // Периметр заполнен и теперь когда есть обо что "опереться" заполняем следующим образом
            // Объявим координаты следующей ячейки
            int c = 1;
            int d = 1;

            while (num < n * n)
            {
                // Идем вправо
                while (arr[c, d + 1] == 0)
                {
                    arr[c, d] = num;
                    num++;
                    d++;
                }
                // Идем вниз
                while (arr[c + 1, d] == 0)
                {
                    arr[c, d] = num;
                    num++;
                    c++;
                }
                // Идем влево
                while (arr[c, d - 1] == 0)
                {
                    arr[c, d] = num;
                    num++;
                    d--;
                }
                while (arr[c - 1, d] == 0)
                {
                    arr[c, d] = num;
                    num++;
                    c--;
                }
            }
            // При заполнении остается незапоненная ячейка. Избавимся от нее с помощью циклов
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] == 0)
                        arr[i, j] = num;
                }
            }
        }
        static void Print(int[,] arr)
        {
            int n =(int) Math.Sqrt(arr.Length);
            Console.WriteLine(arr.Rank);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
  
}
