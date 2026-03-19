namespace matrici5
{
    internal class Program
    {
        static int somma(int[,] M)
        {
            int somma = 0;

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    somma = somma + M[i, j];
                }
            }

            return somma;
        }
        static int[] riempimentoVR(int[,] matrice)
        {
            int[] Vr = new int[matrice.GetLength(0)];

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Vr[i] = Vr[i] + matrice[i, j];
                }
            }

            return Vr;
        }
        static int[] riempimentoVC(int[,] matrice)
        {
            int[] Vc = new int[matrice.GetLength(1)];

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Vc[j] = Vc[j] + matrice[i, j];
                }
            }

            return Vc;
        }
        static int[,] es5(int[,] matrice)
        {
            int[,] MF = new int[matrice.GetLength(0), matrice.GetLength(1)];
            int s = somma(matrice);
            int[] righe = riempimentoVR(matrice);
            int[] colonne = riempimentoVC(matrice);

            for (int i = 0; i < MF.GetLength(0); i++)
            {
                for(int j = 0; j < MF.GetLength(1); j++)
                {
                    MF[i,j] = s - righe[i] - colonne[j] + matrice[i, j];
                }
            }

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for(int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write(MF[i, j] + " ");
                }
                Console.WriteLine();
            }

            return MF;
        }
        static void Main(string[] args)
        {
            int[,] M = { { 2, 5, 9, 1 },
                         { 6, 4, 7, 2 },
                         { 2, 3, 4, 5 },
                         { 1, 9, 3, 1 }
            };

            for(int i = 0; i < M.GetLength(0); i++)
            {
                for (int J = 0; J < M.GetLength(1); J++)
                {
                    Console.Write(M[i, J] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.Write("colonne: ");
            for (int i = 0; i < riempimentoVC(M).Length; i++)
            {
                Console.Write(riempimentoVC(M)[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("righe: ");
            for (int i = 0; i < riempimentoVR(M).Length; i++)
            {
                Console.WriteLine(riempimentoVR(M)[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("la somma tot è: " + somma(M));

            Console.WriteLine();

            es5(M);
        }
    }
}
