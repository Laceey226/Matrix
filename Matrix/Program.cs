namespace Matrix
{
    internal class Program
    {
        static int sorokSzama = 10;
        static int oszlopokSzama = 6;
        static int[,] szamokMatrix = new int[sorokSzama, oszlopokSzama];
        static int[,] negyzetesMatrix = new int[10, 10];
        static Random random = new Random();
        static void F01(int[,]matrix, int min, int max)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(min, max);
                }
            }
        }
        static void F02(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j], 5}");
                }
                Console.WriteLine();
            }
        }
        static void F03()
        {
            Console.WriteLine();
            int ossz = 0;
            for (int i = 0;i < sorokSzama; i++)
            {
                for (int j = 0;j < oszlopokSzama; j++)
                {
                    ossz += szamokMatrix[i, j];
                }
            }
            Console.WriteLine($"A mátrixban lévő elemek összege: {ossz}");
        }
        static void F04()
        {
            Console.WriteLine();
            for (int i = 0; i < sorokSzama; i++)
            {
                int ossz = 0;
                for ( int j = 0; j < oszlopokSzama; j++)
                {
                    ossz += szamokMatrix[i, j];
                }
                Console.WriteLine($"{i + 1}. sor összege: {ossz}");
            }
        }
        static void F05()
        {
            Console.WriteLine();
            for (int j = 0; j < oszlopokSzama; j++)
            {
                int ossz = 0;
                for (int i = 0; i < sorokSzama; i++)
                {
                    ossz += szamokMatrix[i, j];
                }
                Console.WriteLine($"{j + 1}. oszlop összege: {ossz}");
            }
        }
        static void BalAtloOsszeg(int[,] matrix)
        {
            Console.WriteLine();
            int ossz = 0;
            Console.Write("Az átló: ");
            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, i], 5}");
                ossz += matrix[i, i];
            }
            Console.WriteLine();
            Console.WriteLine($"A mátrix bal átlójának összege: {ossz}");
        }
        static void JobbAtloOsszeg(int[,] matrix)
        {
            Console.WriteLine();
            int ossz = 0;
            Console.Write("Az átló: ");
            int j = matrix.GetLength(1) - 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, j],5}");
                ossz += matrix[i, j];
                j -= 1;
            }
            Console.WriteLine();
            Console.WriteLine($"A mátrix bal átlójának összege: {ossz}");
        }
        static void Main(string[] args)
        {
            F01(szamokMatrix, 10, 99);
            F02(szamokMatrix);
            F03();
            F04();
            F05();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            F01(negyzetesMatrix, 1, 9);
            F02(negyzetesMatrix);
            BalAtloOsszeg(negyzetesMatrix);
            JobbAtloOsszeg(negyzetesMatrix);

            Console.WriteLine();
            int[,] masolat = negyzetesMatrix;
            masolat[0, 0] = 100;
            Console.WriteLine("A másolat elemei: ");
            F02(masolat);
            Console.WriteLine();
            Console.WriteLine("A négyzetesmátrix: ");
            F02(negyzetesMatrix);
        }
    }
}
