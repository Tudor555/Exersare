using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] t = Console.ReadLine().Split(' ');
            //int[] v = new int[t.Length];
            //for (int i = 0; i < t.Length; i++)
            //    v[i] = int.Parse(t[i]);
            //InsertionSort(v);
            //printarray(v);
            //Afisarematrice();
            //Pb2734();
            //Pb159();
            //Pb486();
            //Pb553();
            //Pb490();
            //Pb491();
            //Pb2858();
            //Pb832();
            //Pb506();
            //Pb58();
            Set2P6();
        }
        private static void Set2P6()
        {
            Console.WriteLine("6.Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. ");
            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            int cresc = 1;
            int y = Int32.MinValue;
            Console.WriteLine("\nIntroduceti secventa de numere:");  //nu folosim vectori in aceasta problema
            for (int i = 0; i < n; i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());  //unul sub altul

                if (y > x) cresc = 0;
                y = x;

            }
            if (cresc == 1) Console.WriteLine("Secventa este crescatoare.");
            else Console.WriteLine("Secventa nu este crescatoare.");
        }
        private static void Pb58()
        {
            string[] t = Console.ReadLine().Split();
            int a = int.Parse(t[0]);
            int b = int.Parse(t[1]);
            Console.WriteLine(CMMDC(a,b));
        }
        private static int CMMDC(int a, int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;

        }
        private static void Pb506()
        {
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);                
            }
            bool adev = false;
            for (int i = 0; i < n; i++)
            {
                
                if (IsPrime(v[i]) == true)
                    adev = true;
            }
            if (adev == true)
                Console.WriteLine("DA");
            else
                Console.WriteLine("NU");
        }
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }   
        private static void Pb832()
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 5)
                Console.WriteLine("corigent");
            else
                Console.WriteLine("promovat");
        }
        private static void Pb2858()
        {
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            int sum = 0;int sum2 = 0;int sum3 = 0;
            int count = 0;
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] % 2 == 0)
                    sum += v[i];
                if (i % 2 == 0)
                    sum2 += v[i];
                if (v[i] % 10 == 0)
                    count++;
                if (i % 2 == 0 && v[i] % 3 == 0)
                    sum3 += v[i];
            }
            for (int i = n-1; i >= 0; i--)
                Console.Write(v[i]+" ");
            Console.WriteLine("\n"+sum);
            Console.WriteLine(sum2);
            Console.WriteLine(count);
            Console.WriteLine(sum3);
        }
        private static void Pb491()
        {
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            bool exista = false;
            int primul=0;
            int ultimul=0;
            int count=0 ;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for(int i=0;i<n;i++)
                if (v[i]%2==0)
                {
                    primul = i;
                    exista= true;
                    break;
                }
            for(int i=n-1;i>=0;i--)
                if (v[i]%2==0)
                {
                    ultimul = i;
                    break;
                }
            if (exista == false)
                Console.WriteLine("Nu exista!!");
            else
            {
                for (int i = primul; i <= ultimul; i++)
                    count += v[i];
                Console.WriteLine(count);
            }
        }
        private static void Pb490()
        {
            int n=int.Parse(Console.ReadLine());
            string[]t=Console.ReadLine().Split(' ');
            int[]v=new int[n];
            int imin = 0; int imax=0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int min = v[0]; int max = v[0];
            for (int i = 0; i < n; i++)
            {
                if (v[i] > max)
                {
                    max = v[i];
                    imax = i;
                }
                if (v[i]<min)
                {
                    min = v[i];
                    imin = i;
                }
            }
            if(imin > imax)
            {
                int aux = imin;
                imin= imax;
                imax= aux;
            }
            for(int i=imin;i<=imax;i++)
                Console.Write(v[i]+" ");
        }
        private static void Pb553()
        {
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split();
            int[] v = new int[n];
            int imin = 0;int imax = 0;
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(t[i]);                   
            }
            int min = v[0];int max = v[0];
            for (int i = 0; i < n; i++)
            {
                if (v[i] > max) 
                {
                    max = v[i];
                    imax = i;
                }
                if (min > v[i])
                {
                    min = v[i];
                    imin = i;
                }
            }
            Console.WriteLine(imin + " " + imax);
        }
        private static void Pb486()
        {
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split();
            int[] v = new int[n];            
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(t[i]);                   
            }
            int min = v[0];int max = v[0];
            for (int i = 0; i < n; i++)
            {
                if (v[i] > max) max = v[i];
                if (min > v[i]) min = v[i];
            }   
            Console.WriteLine(min + " " +max);
        }
        private static void Pb159()
        {
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[2*n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i]%2==0)
                {
                    for(int j=n;j>i+1;j--)
                        v[j] = v[j - 1];
                    v[i + 1] = 2 * v[i];
                    i++;n++;
                    
                }
            }
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        private static void Pb2734()
        {
            int n=int.Parse(Console.ReadLine());
            string[] t=Console.ReadLine().Split(' ');
            int[]v=new int[n];
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for(int i=0;i<n;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if (v[i] == v[j])
                    {
                        for(int k=j+1;k<n;k++)
                            v[k-1] = v[k];
                        n--;
                        i--;
                    }
                }
            }
            for(int i=0;i<n;i++)
                Console.Write(v[i]+" ");
        }
        private static void InsertionSort(int[] v)
        {
            int aux;
            for (int i = 1; i < v.Length; i++)  //indexare de la 1
            {
                for (int k = i; k > 0 && v[k] < v[k - 1]; k--)  
                {
                    aux = v[k]; v[k] = v[k - 1]; v[k - 1] = aux;
                }
            }
        }
        private static void printarray(int[]v)
        {
            for(int i = 0; i<v.Length;i++)      //afisare vector
            {
                Console.Write(v[i] + " ");
            }
        }
        private static void Afisarematrice()
        {
            string[] t = Console.ReadLine().Split(',');  //citire matrice
            int n = int.Parse(t[0]);
            int[,] a = new int[n, n];  //matrice patratica de ordin n
            int[,] b = new int[n, n];
            int i; int j;
            for (i = 0; i < n; i++)
            {
                t = Console.ReadLine().Split(' ');
                for (j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(t[j]);  //introducere matrice
                }
            }
            Console.WriteLine();
            string s;                         //afisare matrice
            for (i = 0; i < n; i++)          //o afiseaza la fel
            {
                s = " ";
                for(j=0;j<n;j++)
                    s+= a[i, j]+" ";
                Console.WriteLine(s);
            }
        }
    }
}
