using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA2NET_2b_
{
    class Chetiroxygolnik
    {
        public double X_a , Y_a , X_b , Y_b , X_c , Y_c , X_d , Y_d , side1, side2, side3, side4, dig, per, plo,plo1;

        public double SIZESCHetver()
        {
            this.X_a = -3;
            this.Y_a = 3;
            this.X_b = 5;
            this.Y_b = 3;
            this.X_c = -3;
            this.Y_c = -1;
            this.X_d = 5;
            this.Y_d = -1;
            return 0;
        }

        public double GetSizeofside()
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
        public double GetArea()
        {
            Console.WriteLine("Площадь: ");
            plo = side3 * side4;
            Console.WriteLine(plo);
            return 0;
        }
        public double GetPerimetr()
        {
            Console.WriteLine("Периметр: ");
            per = side1 + side2 + side3 + side4;
            Console.WriteLine(per);
            return 0;
        }
        public double GetDiagonal()
        {
            Console.WriteLine("Диагональ: ");
            dig = Math.Sqrt(Math.Pow(side3, 2) + Math.Pow(side4, 2));
            Console.WriteLine(dig);
            return 0;
        }


    }
}

