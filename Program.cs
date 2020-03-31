using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA2NET_2b_
{
    class Program
    {
        static void Main(string[] args)
        {
            Chetiroxygolnik CHETIROXYGOLNIK = new Chetiroxygolnik();
            CHETIROXYGOLNIK.SIZESCHetver();
            CHETIROXYGOLNIK.GetSizeofside();
            CHETIROXYGOLNIK.GetDiagonal();
            CHETIROXYGOLNIK.GetPerimetr();
            CHETIROXYGOLNIK.GetArea();
            

            KVADRAT kVADRAT = new KVADRAT();
            kVADRAT.SizeRvadrat();
            kVADRAT.Proverka();
            kVADRAT.isPryamoug();
            Console.WriteLine("Вводим значения квадрата №1:");
            lastzadanie lastzadanie = new lastzadanie();
            lastzadanie.SHIKL();
            Console.WriteLine("Значение сторон квадрата №1:");
            lastzadanie.Proverka();

            lastzadanie.GetArea1();
            Console.WriteLine("Вводим значения квадрата №2:");
            lastzadanie.SHIKL1();
            Console.WriteLine("Значение сторон квадрата №2:");
            lastzadanie.Proverka1();
            lastzadanie.GetArea11();
            Console.WriteLine("Равны ли квадраты:");
            lastzadanie.RavniLi();
            Console.WriteLine("Вводим значения прямоугольникам №1:");
            lastzadanie.Chet1();
            Console.WriteLine("Значение сторон прямоугольникам  №1:");
            lastzadanie.GetSizeofside1();

            lastzadanie.GetAreaCHET();
            Console.WriteLine("Вводим значения прямоугольникам №2:");
            lastzadanie.Chet2();
            Console.WriteLine("Значение сторон прямоугольникам  №2:");
            lastzadanie.GetSizeofside2();
            lastzadanie.GetAreaCHET1();
            Console.WriteLine("Чья площадь больше: ");
            lastzadanie.ProverkaNaPlochad();
        }
    }
}
