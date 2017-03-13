using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSK_ps23
{
    class Program
    {
        static void Main(string[] args)
        {
            String M = "CRYPTOGRAPHY";
            String K = "BREAKBREAKBR";
            String C = "";
            int n = 4, k0 = 3;
            int k1 = 7;
            int[] k = { 3, 4, 1, 5, 2 };
            bool b = true;
            while (b)
            {
                Console.WriteLine("Choose exercise: 1e | 1d | 2e | 2d | 31e | 31d | 32e | 32d | 4e | 4d | 5e | 5d | q");
                switch (Console.ReadLine())
                {
                    case "1e":
                        Console.Write("Enter  M: ");
                        M = Console.ReadLine().ToUpper();
                        Console.Write("Enter  n: ");
                        n = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("       C: " + exercise1encode(M, n) + "\n\n\n");
                        break;
                    case "1d":
                        System.IO.StreamReader file1 =
                            new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\result1.txt");
                        C = file1.ReadLine();
                        n = Int32.Parse(file1.ReadLine());
                        file1.Close();
                        Console.WriteLine("Loaded C: " + C);
                        Console.WriteLine("Loaded n: " + n);
                        Console.Write("Enter  n: ");
                        n = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("       M: " + exercise1decode(C, n) + "\n\n\n");
                        break;
                    case "2e":
                        Console.Write("Enter M:     ");
                        M = Console.ReadLine().ToUpper();
                        Console.Write("Enter key[]: ");
                        K = Console.ReadLine();
                        Console.WriteLine("       C:    " + exercise2encode(M, K) + "\n\n\n");
                        break;
                    case "2d":
                        System.IO.StreamReader file2 =
                            new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\result2.txt");
                        C = file2.ReadLine();
                        K = file2.ReadLine();
                        file2.Close();
                        Console.WriteLine("Loaded C:     " + C);
                        Console.WriteLine("Loaded key[]: " + K);
                        Console.Write("Enter  key[]: ");
                        K = Console.ReadLine();
                        Console.WriteLine("       M:     " + exercise2decode(C, K) + "\n\n\n");
                        break;
                    case "31e":
                        Console.Write("Enter M:   ");
                        M = Console.ReadLine().ToUpper();
                        Console.Write("Enter KEY: ");
                        K = Console.ReadLine().ToUpper();
                        Console.WriteLine("      C:   " + exercise31encode(M, K) + "\n\n\n");
                        break;
                    case "31d":
                        System.IO.StreamReader file3 =
                            new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\result31.txt");
                        C = file3.ReadLine();
                        K = file3.ReadLine();
                        file3.Close();
                        Console.WriteLine("Loaded C:   " + C);
                        Console.WriteLine("Loaded KEY: " + K);
                        Console.Write("Enter  KEY: ");
                        K = Console.ReadLine();
                        Console.WriteLine("       M:   " + exercise31decode(C, K) + "\n\n\n");
                        break;
                    case "32e":
                        Console.Write("Enter M:   ");
                        M = Console.ReadLine().ToUpper();
                        Console.Write("Enter KEY: ");
                        K = Console.ReadLine().ToUpper();
                        Console.WriteLine("      C:   " + exercise32encode(M, K) + "\n\n\n");
                        break;
                    case "32d":
                        System.IO.StreamReader file32 =
                            new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\result32.txt");
                        C = file32.ReadLine();
                        K = file32.ReadLine();
                        file32.Close();
                        Console.WriteLine("Loaded C:   " + C);
                        Console.WriteLine("Loaded KEY: " + K);
                        Console.Write("Enter  KEY: ");
                        K = Console.ReadLine();
                        Console.WriteLine("       M:   " + exercise32decode(C, K) + "\n\n\n");
                        break;
                    case "4e":
                        Console.Write("Enter M:  ");
                        M = Console.ReadLine().ToUpper();
                        Console.Write("Enter k0: ");
                        k0 = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter k1: ");
                        k1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("      C:  " + exercise4encode(M, k0, k1) + "\n\n\n");
                        break;
                    case "4d":
                        System.IO.StreamReader file4 =
                           new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\result4.txt");
                        C = file4.ReadLine();
                        k0 = Int32.Parse(file4.ReadLine());
                        k1 = Int32.Parse(file4.ReadLine());
                        file4.Close();
                        Console.WriteLine("Loaded C:  " + C);
                        Console.WriteLine("Loaded k0: " + k0);
                        Console.WriteLine("Loaded k1: " + k1);
                        Console.Write("Enter  k0: ");
                        k0 = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter  k1: ");
                        k1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("       M:  " + exercise4decode(C, k0, k1) + "\n\n\n");
                        break;
                    case "5e":
                        Console.Write("Enter M: ");
                        M = Console.ReadLine().ToUpper();
                        Console.Write("Enter K: ");
                        K = Console.ReadLine().ToUpper();
                        Console.WriteLine("      C: " + exercise5encode(M, K) + "\n\n\n");
                        break;
                    case "5d":
                        System.IO.StreamReader file5 =
                            new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\result5.txt");
                        C = file5.ReadLine();
                        K = file5.ReadLine();
                        file5.Close();
                        Console.WriteLine("Loaded C: " + C);
                        Console.WriteLine("Loaded K: " + K);
                        Console.Write("Enter  K: ");
                        K = Console.ReadLine();
                        Console.WriteLine("       M: " + exercise5decode(C, K) + "\n\n\n");
                        break;
                    case "q":
                        b = false;
                        break;

                }
            }
            Console.ReadKey();
        }

        #region 1
        static String exercise1encode(String M, int n)
        {
            String C = "";
            int i, j, numberOfTops = 0; // numberOfTops is helpfull for second loop and extra top


            for (i = 0; (n - 1) * 2 * i < M.Length; i++)
            {
                C = String.Concat(C, M[(n - 1) * 2 * i]);
                numberOfTops++;
            }

            for (i = 1; i < n - 1; i++) // for all midfielder rows
            {
                for (j = 0; j <= numberOfTops; j++) // for all tops + 1 extra top
                {
                    if ((((n - 1) * 2 * j - i) >= 0) && (((n - 1) * 2 * j - i) < M.Length))
                    {
                        C = String.Concat(C, M[(n - 1) * 2 * j - i]);
                    }

                    if (((n - 1) * 2 * j + i) < M.Length)
                    {
                        C = String.Concat(C, M[(n - 1) * 2 * j + i]);
                    }
                }
            }

            for (i = 0; (n - 1) * 2 * i + n - 1 < M.Length; i++)
            {
                C = String.Concat(C, M[(n - 1) * 2 * i + n - 1]);
            }
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + @"\result1.txt"))
            {
                file.WriteLine(C);
                file.WriteLine(n);
            }

            return C;
        }
        static String exercise1decode(String Cx, int n)
        {
            StringBuilder M = new StringBuilder(Cx);
            StringBuilder C = new StringBuilder(Cx);
            int i, j, numberOfTops = 0, specialIndex = 0; // numberOfTops is helpfull for second loop and extra top


            for (i = 0; (n - 1) * 2 * i < C.Length; i++)
            {
                M[(n - 1) * 2 * i] = C[specialIndex++];
                numberOfTops++;
            }

            for (i = 1; i < n - 1; i++) // for all midfielder rows
            {
                for (j = 0; j <= numberOfTops; j++) // for all tops + 1 extra top
                {
                    if ((((n - 1) * 2 * j - i) >= 0) && (((n - 1) * 2 * j - i) < M.Length))
                    {
                        M[(n - 1) * 2 * j - i] = C[specialIndex++];
                    }

                    if (((n - 1) * 2 * j + i) < M.Length)
                    {
                        M[(n - 1) * 2 * j + i] = C[specialIndex++];
                    }
                }
            }

            for (i = 0; (n - 1) * 2 * i + n - 1 < M.Length; i++)
            {
                M[(n - 1) * 2 * i + n - 1] = C[specialIndex++];
            }

            return M.ToString();
        }
        #endregion

        #region 2
        static String exercise2encode(String M, String key)
        {
            String C = "";
            int[] k = new int[key.Length];
            int d = k.Length, i, j;
            for (int a = 0; a < key.Length; a++)
            {
                k[a] = Int32.Parse(key[a].ToString());
            }


            for (i = 0; i < Math.Ceiling(M.Length / Double.Parse(d.ToString())); i++) // for all rows
            {
                for (j = 0; j < d; j++) // for all columns
                {
                    if (k[j] - 1 + d * i < M.Length)
                    {
                        C = String.Concat(C, M[k[j] - 1 + d * i]);
                    }
                }
            }
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + @"\result2.txt"))
            {
                file.WriteLine(C);
                file.WriteLine(key);
            }

            return C;
        }
        static String exercise2decode(String C, String key)
        {
            int[] k = new int[key.Length];
            for (int a = 0; a < key.Length; a++)
            {
                k[a] = Int32.Parse(key[a].ToString());
            }

            StringBuilder M = new StringBuilder(C);
            int d = k.Length, i, j, specialIndex; // i had to use specialIndex instead j in loop, because in last row if we had empty box, j is incremented anyway and then is readed out of bound

            for (i = 0, specialIndex = 0; i < Math.Ceiling(C.Length / Double.Parse(d.ToString())); i++) // for all rows
            {
                for (j = 0; j < d; j++) // for all columns
                {
                    if (k[j] - 1 + d * i < C.Length)
                    {
                        M[k[j] - 1 + d * i] = C[specialIndex++];
                    }
                }
            }

            return M.ToString();
        }
        #endregion

        #region 31
        static String exercise31encode(String Mx, String K)
        {
            int i, j, k;
            String C = "";
            StringBuilder M = new StringBuilder(Mx);

            for (i = 65; i <= 90; i++) // through all letter in alphabet
            {
                for (j = 0; j < K.Length; j++) // for all letter in key
                {
                    if (K[j] == i) // if letter is in key
                    {
                        for (k = 0; j + k * K.Length < M.Length; k++) // for all rows of M under concrete letter
                        {
                            C = String.Concat(C, M[j + k * K.Length]);
                        }
                    }
                }
            }
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + @"\result31.txt"))
            {
                file.WriteLine(C);
                file.WriteLine(K);
            }

            return C;
        }
        static String exercise31decode(String C, String K)
        {
            int i, j, k, specialIndex = 0;
            StringBuilder M = new StringBuilder(C);

            for (i = 65; i <= 90; i++) // through all letter in alphabet
            {
                for (j = 0; j < K.Length; j++) // for all letter in key
                {
                    if (K[j] == i) // if letter is in key
                    {
                        for (k = 0; j + k * K.Length < M.Length; k++) // for all rows of M under concrete letter
                        {
                            M[j + k * K.Length] = C[specialIndex++];
                        }
                    }
                }
            }

            return M.ToString();
        }
        #endregion

        #region 32
        static String exercise32encode(String Mx, String K)
        {
            int i, j, k, m, specialIndex = 0, i2, j2;
            int[] kk = new int[K.Length];
            String C = "";
            StringBuilder M = new StringBuilder(Mx);
            List<char[]> tab = new List<char[]>(); // list of arrays
            char[] t;

            // here i determine key
            for (i = 65; i <= 90; i++) // through all letter in alphabet
            {
                for (j = 0; j < K.Length; j++) // for all letter in key
                {
                    if (K[j] == i)
                    {
                        kk[j] = ++specialIndex;
                    }
                }
            }



            // here i determine list of arrays
            for (i = 0, specialIndex = 0; specialIndex < Mx.Length; i++) // until word is not ended
            {
                for (j = 0; j < K.Length; j++) // find apprpriate column
                {
                    if (kk[j] == i + 1)
                    { break; }
                }

                if (M.Length - specialIndex >= j + 1) // if we have enough letters to make full array, do it
                {
                    t = new char[j + 1];
                }
                else // or make smaller array
                {
                    t = new char[M.Length - specialIndex];
                }

                for (m = 0; m < j + 1 && specialIndex < M.Length; m++) // fill the array
                {
                    t[m] = M[specialIndex++];
                }
                tab.Add(t);

                if ((i + 1 == K.Length) || ((specialIndex + 1) > M.Length))
                {
                    //reading arrays
                    for (i2 = 0; i2 < K.Length; i2++) // for all columns
                    {
                        for (j2 = 0; j2 < K.Length; j2++) // find appropriate column
                        {
                            if (kk[j2] == i2 + 1)
                            { break; }
                        }

                        foreach (var tt in tab) // for all arrays check if has letter in this column
                        {
                            if (tt.Length >= j2 + 1)
                            {
                                C = String.Concat(C, tt[j2]);
                            }
                        }

                    }

                    int dl = tab.Count;

                    tab.RemoveRange(0, dl);

                    i = -1;
                }
            }


            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + @"\result32.txt"))
            {
                file.WriteLine(C);
                file.WriteLine(K);
            }

            return C;
        }
        static String exercise32decode(String Cx, String K)
        {
            int i, j, k, m, specialIndex = 0, i2, j2, readIndex = 0;
            int[] kk = new int[K.Length];
            String M = "";
            StringBuilder C = new StringBuilder(Cx);
            List<char[]> tab = new List<char[]>(); // list of arrays
            char[] t;

            // here i determine key
            for (i = 65; i <= 90; i++) // through all letter in alphabet
            {
                for (j = 0; j < K.Length; j++) // for all letter in key
                {
                    if (K[j] == i)
                    {
                        kk[j] = ++specialIndex;
                    }
                }
            }


            // here i determine list of arrays
            for (i = 0, specialIndex = 0; specialIndex < C.Length; i++) // until word is not ended
            {
                for (j = 0; j < K.Length; j++) // find apprpriate column
                {
                    if (kk[j] == i + 1)
                    { break; }
                }

                if (C.Length - specialIndex >= j + 1) // if we have enough letters to make full array, do it
                {
                    t = new char[j + 1];
                }
                else // or make smaller array
                {
                    t = new char[C.Length - specialIndex];
                }

                for (m = 0; m < j + 1 && specialIndex < C.Length; m++) // fill the array
                {
                    specialIndex++;
                }

                tab.Add(t);


                if ((i + 1 == K.Length) || ((specialIndex + 1) > C.Length))
                {
                    //written arrays
                    for (i2 = 0; i2 < K.Length; i2++) // for all columns
                    {
                        for (j2 = 0; j2 < K.Length; j2++) // find appropriate column
                        {
                            if (kk[j2] == i2 + 1)
                            { break; }
                        }

                        foreach (var tt in tab) // for all arrays check if has letter in this column
                        {
                            if (tt.Length >= j2 + 1)
                            {
                                tt[j2] = C[readIndex++];
                            }
                        }

                    }

                    //read word - one by one all letters from all arrays
                    foreach (var tt in tab)
                    {
                        foreach (var l in tt)
                        {
                            M = String.Concat(M, l);
                        }
                    }

                    int dl = tab.Count;
                    tab.RemoveRange(0, dl);
                    i = -1;
                }
            }



            return M;
        }
        #endregion

        #region 4
        static String exercise4encode(String M, int k0, int k1)
        {
            String C = "";
            String tab = "";
            int i;

            for (i = 0; i < 26; i++)
            {
                tab = String.Concat(tab, (char)(65 + i));
            }

            for (i = 0; i < M.Length; i++)
            {
                C = String.Concat(C, tab[(tab.IndexOf(M[i]) * k1 + k0) % 26]);
            }
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + @"\result4.txt"))
            {
                file.WriteLine(C);
                file.WriteLine(k0);
                file.WriteLine(k1);
            }

            return C;

        }
        static String exercise4decode(String C, int k0, int k1)
        {
            String M = "";
            String tab = "";
            int i, pow = 11, a, b;

            for (i = 0; i < 26; i++)
            {
                tab = String.Concat(tab, (char)(65 + i));
            }

            for (i = 0; i < C.Length; i++)
            {
                a = makeModuloFromMinus(tab.IndexOf(C[i]) + (26 - k0), 26);
                b = makeModulo(k1, pow, 26);
                M = String.Concat(M, tab[((a * b) % 26)]);
            }

            return M;
        }

        private static int makeModulo(int k1, int pow, int n)
        {
            int i;
            int x = k1 % n;
            int result = x;

            for (i = 1; i < pow; i++)
            {
                result = (result * x) % n;
            }

            return result;
        }

        private static int makeModuloFromMinus(int x, int n)
        {
            while (x < 0)
            {
                x += n;
            }
            return x;
        }
        #endregion

        #region 5
        static String exercise5encode(String M, String Kx)
        {
            StringBuilder C = new StringBuilder(M); ;
            int i, indexOfK;
            String K = Kx;

            if (K.Length < M.Length)
            {
                for (i = K.Length, indexOfK = -1; i < M.Length; i++)
                {
                    K = String.Concat(K, Kx[(++indexOfK) % Kx.Length]);
                }
            }

            for (i = 0; i < M.Length; i++) // for all letters in Mx
            {
                C[i] = (char)(65 + (M[i] + K[i]) % 26);
            }
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + @"\result5.txt"))
            {
                file.WriteLine(C);
                file.WriteLine(Kx);
            }

            return C.ToString();
        }
        static String exercise5decode(String C, String Kx)
        {
            StringBuilder M = new StringBuilder(C); ;
            int i, pom, indexOfK;

            String K = Kx;

            if (K.Length < M.Length)
            {
                for (i = K.Length, indexOfK = -1; i < M.Length; i++)
                {
                    K = String.Concat(K, Kx[(++indexOfK) % Kx.Length]);
                }
            }

            for (i = 0; i < C.Length; i++) // for all letters in Mx
            {
                pom = C[i] - K[i] % 65;
                if (pom < 65) { pom += 26; }
                M[i] = (char)(pom);
            }

            return M.ToString();
        }
        #endregion
    }
}
