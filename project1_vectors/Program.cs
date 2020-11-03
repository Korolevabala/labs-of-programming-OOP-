using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;

namespace project1
{
    class Program
    { 
        static void Main(string[] args)
        {
            double x,y,z;
            Console.WriteLine("Создание векторов");
            Console.WriteLine("Введите координату х");
            Console.WriteLine("введите координату у");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите координату z ");
            z = Convert.ToDouble(Console.ReadLine());
            Vector vec1 = new Vector(x,y,z); // создание 1 вектора
            bool flame =true; int digit;int digit_2=1; //обьявление переменных
            while(true) //бесконечный цикл
            {
                Console.WriteLine("Введите координату х");
                x= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите координату у");
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите координату z ");
                z = Convert.ToDouble(Console.ReadLine());
               Vector vec2 = new Vector(x,y,z);
               Console.WriteLine("Желаете завершить действие с векторами?");
                if(flame==true)
                {
                    Console.WriteLine("Если вы хотите сложить-1 \n вычесть-2 скаляр-3 длина-4 косинус-5");
                    digit = Convert.ToInt32(Console.ReadLine());
                    switch(digit)
                    {
                        case 1:
                        vec1.Adder(vec2);   
                        break;
                        case 2:
                        vec1.Subtraction(vec2);
                        break;
                        case 3:
                        Console.WriteLine(vec1.AB(vec2));
                        break;
                        case 4:
                        Console.WriteLine("Введите номер обьекта который будет рассматриваться");
                        digit_2 = Convert.ToInt32(Console.ReadLine());
                        if(digit_2==1)
                        {
                            Console.WriteLine(vec1.Leng());
                        }
                        else{
                            Console.WriteLine(vec2.Leng());
                        }
                        break;
                        case 5:
                        Console.WriteLine(vec1.Cosinus(vec2));
                        break;

                    }
                }
                else
                {
                    break;
                }
            }
        }
    }

}