namespace Matrix
{
    internal class Program
    {
        static int sorokSzama = 10;
        static int oszlopokSzama = 6;
        static int[,] szamokMatrix = new int[sorokSzama, oszlopokSzama];
        static Random random = new Random();
        static void F01()
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    szamokMatrix[i, j] = random.Next(10, 100);
                }
            }
        }
        static void F02()
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    Console.Write(szamokMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            F01();
            F02();


        }
    }
}
