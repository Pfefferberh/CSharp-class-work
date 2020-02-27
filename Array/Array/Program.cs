using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Початковий вклад в банку рівний 1000 грн.Через кожен місяць розмір вкладу збільшується 
//на Р процентів від наявної суми(Р - дійсне число, 0 < P< 25). Значення Р программа повинна 
//отримувати від користувача.По даному Р программа повинна визначити, через скільки місяців розмір 
//вкладу перевищить 1100 грн.та вивести знайдену кількість місяців К(ціле число) та підсумковий розмір вкладу S(дійсне число).  



namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            float P;
            float Vidsotok;
            int dep =1000;
            float S = dep;
            Console.Write("Enter % :\n");
            P =Convert.ToInt32(Console.ReadLine());
            //if (P < 0 && P > 25)
            //{
                ConsoleColor er= Console.BackgroundColor;
                Console.WriteLine("ERROR{0}",er); 
            //}
            //else
            //{
            //    for (int i = 0; i < 12; i++)
            //    {
            //        Vidsotok = S * (P / 100);
            //        S = S + Vidsotok;
            //        if (S >= 1100)
            //        {
            //            Console.Write("Months : {0}\nPidsumok : {1}\n", i, Convert.ToInt32(S));
            //            break;
            //        }
            //    }
            //}
            
        }
    }
}
