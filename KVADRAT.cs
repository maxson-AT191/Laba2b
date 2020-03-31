using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA2NET_2b_
{
    class KVADRAT : Chetiroxygolnik
    {
        
        public double SizeRvadrat()
        {
            string str;
            Console.WriteLine("Введите первую координату: ");
            str = Console.ReadLine();
            this.X_a = Convert.ToInt32(str);
            Console.WriteLine("Введите вторую координату: ");
            str = Console.ReadLine();
            this.Y_a = Convert.ToInt32(str);
            Console.WriteLine("Введите третью координату: ");
            str = Console.ReadLine();
            this.X_b = Convert.ToInt32(str);
            Console.WriteLine("Введите четвертую координату: ");
            str = Console.ReadLine();
            this.Y_b = Convert.ToInt32(str);
            Console.WriteLine("Введите пятую координату: ");
            str = Console.ReadLine();
            this.X_c = Convert.ToInt32(str);
            Console.WriteLine("Введите шестую координату: ");
            str = Console.ReadLine();
            this.Y_c = Convert.ToInt32(str);
            Console.WriteLine("Введите седьмую координату: ");
            str = Console.ReadLine();
            this.X_d = Convert.ToInt32(str);
            Console.WriteLine("Введите восьмую координату: ");
            str = Console.ReadLine();
            this.Y_d = Convert.ToInt32(str);
            
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
        public double isPryamoug()
        {
            if (side1 == side3 && side2 == side4)
            {
                Console.WriteLine("Является квадратом");
                return 0;
            }
            else
                Console.WriteLine(" НЕ является квадратом");
            return 0;
        }

    }
}
