using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA2NET_2b_
{
    class lastzadanie : Chetiroxygolnik
    {



        public double SHIKL()
        {
            double[] salary = new double[8];
            string str;


            for (int i = 0; i < salary.Length; i++)
            {
                Console.WriteLine("Координата " + i, " ");
                str = Console.ReadLine();
                salary[i] = Convert.ToDouble(str);

            }

            X_a = salary[0];
            Y_a = salary[1];
            X_b = salary[2];
            Y_b = salary[3];
            X_c = salary[4];
            Y_c = salary[5];
            X_d = salary[6];
            Y_d = salary[7];




            return 0;
        }


        public double Proverka()
        {



            Console.WriteLine("Размер первой стороны: ");
            this.side1 = Math.Sqrt(Math.Pow(X_b - X_a, 2) + Math.Pow(Y_b - Y_a, 2));
            Console.WriteLine(side1);
            Console.WriteLine("Размер второй стороны: ");
            this.side2 = Math.Sqrt(Math.Pow(X_d - X_b, 2) + Math.Pow(Y_d - Y_b, 2));
            Console.WriteLine(side2);
            Console.WriteLine("Размер третьей стороны: ");
            this.side3 = Math.Sqrt(Math.Pow(X_d - X_c, 2) + Math.Pow(Y_d - Y_c, 2));
            Console.WriteLine(side3);
            Console.WriteLine("Размер четвертой стороны: ");
            this.side4 = Math.Sqrt(Math.Pow(X_c - X_a, 2) + Math.Pow(Y_c - Y_a, 2));
            Console.WriteLine(side4);
            return 0;

        }
        public double GetArea1()
        {
            Console.WriteLine("Площадь: ");
            plo = side3 * side4;
            Console.WriteLine(plo);
            return 0;

        }

        public double SHIKL1()
        {
            double[] salary1 = new double[8];
            string str;


            for (int i = 0; i < salary1.Length; i++)
            {
                Console.WriteLine("Координата " + i, " ");
                str = Console.ReadLine();
                salary1[i] = Convert.ToDouble(str);

            }

            X_a = salary1[0];
            Y_a = salary1[1];
            X_b = salary1[2];
            Y_b = salary1[3];
            X_c = salary1[4];
            Y_c = salary1[5];
            X_d = salary1[6];
            Y_d = salary1[7];




            return 0;
        }


        public double Proverka1()
        {



            Console.WriteLine("Размер первой стороны: ");
            this.side1 = Math.Sqrt(Math.Pow(X_b - X_a, 2) + Math.Pow(Y_b - Y_a, 2));
            Console.WriteLine(side1);
            Console.WriteLine("Размер второй стороны: ");
            this.side2 = Math.Sqrt(Math.Pow(X_d - X_b, 2) + Math.Pow(Y_d - Y_b, 2));
            Console.WriteLine(side2);
            Console.WriteLine("Размер третьей стороны: ");
            this.side3 = Math.Sqrt(Math.Pow(X_d - X_c, 2) + Math.Pow(Y_d - Y_c, 2));
            Console.WriteLine(side3);
            Console.WriteLine("Размер четвертой стороны: ");
            this.side4 = Math.Sqrt(Math.Pow(X_c - X_a, 2) + Math.Pow(Y_c - Y_a, 2));
            Console.WriteLine(side4);
            return 0;

        }
        public double GetArea11()
        {
            Console.WriteLine("Площадь: ");
            plo1 = side3 * side4;
            Console.WriteLine(plo);
            return 0;

        }
        public double RavniLi()
        {
            if (plo == plo1)
            {
                Console.WriteLine("Одинаковые квадраты");
            }
            else
            {
                Console.WriteLine("Не Одинаковые квадраты");
            }
            return 0;
        }

       
        public double Chet1()
        {
            double[] salary1 = new double[8];
        string str;


            for (int i = 0; i<salary1.Length; i++)
            {
                Console.WriteLine("Координата " + i, " ");
                str = Console.ReadLine();
                salary1[i] = Convert.ToDouble(str);

            }

            X_a = salary1[0];
            Y_a = salary1[1];
            X_b = salary1[2];
            Y_b = salary1[3];
            X_c = salary1[4];
            Y_c = salary1[5];
            X_d = salary1[6];
            Y_d = salary1[7];




            return 0;
        }

        public double GetSizeofside1()
        {
            Console.WriteLine("Размер первой стороны: ");
            side1 = Math.Sqrt(Math.Pow(X_b - X_a, 2) + Math.Pow(Y_b - Y_a, 2));
            Console.WriteLine(side1);
            Console.WriteLine("Размер второй стороны: ");
            side2 = Math.Sqrt(Math.Pow(X_d - X_b, 2) + Math.Pow(Y_d - Y_b, 2));
            Console.WriteLine(side2);
            Console.WriteLine("Размер третьей стороны: ");
            side3 = Math.Sqrt(Math.Pow(X_d - X_c, 2) + Math.Pow(Y_d - Y_c, 2));
            Console.WriteLine(side3);
            Console.WriteLine("Размер четвертой стороны: ");
            side4 = Math.Sqrt(Math.Pow(X_c - X_a, 2) + Math.Pow(Y_c - Y_a, 2));
            Console.WriteLine(side4);
            return 0;
        }
        public double GetAreaCHET()
        {
            Console.WriteLine("Площадь: ");
            plo = side3 * side4;
            Console.WriteLine(plo);
            return 0;
        }

        public double Chet2()
        {
            double[] salary1 = new double[8];
            string str;


            for (int i = 0; i < salary1.Length; i++)
            {
                Console.WriteLine("Координата " + i, " ");
                str = Console.ReadLine();
                salary1[i] = Convert.ToDouble(str);

            }

            X_a = salary1[0];
            Y_a = salary1[1];
            X_b = salary1[2];
            Y_b = salary1[3];
            X_c = salary1[4];
            Y_c = salary1[5];
            X_d = salary1[6];
            Y_d = salary1[7];




            return 0;
        }

        public double GetSizeofside2()
        {
            Console.WriteLine("Размер первой стороны: ");
            side1 = Math.Sqrt(Math.Pow(X_b - X_a, 2) + Math.Pow(Y_b - Y_a, 2));
            Console.WriteLine(side1);
            Console.WriteLine("Размер второй стороны: ");
            side2 = Math.Sqrt(Math.Pow(X_d - X_b, 2) + Math.Pow(Y_d - Y_b, 2));
            Console.WriteLine(side2);
            Console.WriteLine("Размер третьей стороны: ");
            side3 = Math.Sqrt(Math.Pow(X_d - X_c, 2) + Math.Pow(Y_d - Y_c, 2));
            Console.WriteLine(side3);
            Console.WriteLine("Размер четвертой стороны: ");
            side4 = Math.Sqrt(Math.Pow(X_c - X_a, 2) + Math.Pow(Y_c - Y_a, 2));
            Console.WriteLine(side4);
            return 0;
        }
        public double GetAreaCHET1()
        {
            Console.WriteLine("Площадь: ");
            plo1 = side3 * side4;
            Console.WriteLine(plo1);
            return 0;
        }
        public double ProverkaNaPlochad()
        {
            if (plo > plo1)
            {
                Console.WriteLine("Площадь первого больше");
            }
            else
            {
                Console.WriteLine("Площадь второго больше");
            }
            return 0;
        }
    }
}
