using System;

namespace rezultlaba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Brunch first_instance = new Brunch();
            first_instance.Digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите кол-во элементов, а после сами элементы");
            int[] arr = new int[first_instance.Digit];
            int position = 0;
            while (position < first_instance.Digit)
            {
                arr[position] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("1=+ 2=- 3=обьединениe 4 = пересечение 5=разность ");
            int digit = Convert.ToInt32(Console.ReadLine());
            switch (digit)
            {
                case 1:
                    {
                        int i = 0;
                        int[] newarr1 = new int[first_instance.Digit];
                        for (i = 0; i < first_instance.Digit;)
                        {
                            newarr1[i] = arr[i];
                        }
                        Console.WriteLine("введите элемент");
                        newarr1[first_instance.Digit] = first_instance.Adder();
                        //вывод
                        foreach (int number in newarr1)
                        {
                            Console.WriteLine(newarr1[number]);
                        }
                        break;
                    }
                case 2:
                    {
                        int differ2;
                        int[] newarr2 = new int[first_instance.Digit - 1];
                        Console.WriteLine("выберите индекс элемента для удаления");
                        differ2 = first_instance.Delete();
                        for (int i = 0; i < first_instance.Digit - 1;)
                        {
                            if (i != differ2 - 1)
                                newarr2[i] = arr[i];
                            else
                                newarr2[i] = arr[i + 1];
                        }
                        foreach (int number in newarr2)
                        {
                            Console.WriteLine(newarr2[number]);
                        }
                        break;
                    }
                case 3:
                    {
                        Brunch second3_instance = new Brunch();
                        second3_instance.Digit = Convert.ToInt32(Console.ReadLine());
                        int[] arr3 = new int[second3_instance.Digit];
                        position = 0;
                        while (position < second3_instance.Digit)
                        {
                            arr3[position] = Convert.ToInt32(Console.ReadLine());
                        }
                        int differ3 = 0;
                        for (int i = 0; i < first_instance.Digit; i++)
                        {
                            for (int j = 0; j < second3_instance.Digit; j++)
                            {
                                if (arr[i] == arr3[j])
                                {
                                    differ3++;
                                }
                            }
                        }
                        int rezult3 = first_instance.Digit + differ3;
                        int[] newarr3 = new int[rezult3];
                        {
                            for (int i = 0; i < first_instance.Digit; i++)
                            {
                                newarr3[i] = arr[i];
                            }
                            for (int i = first_instance.Digit; i < rezult3; i++)
                            {
                                for (int j = 0; j < second3_instance.Digit; j++)
                                {
                                    if (arr3[j] != arr[i])
                                    {
                                        newarr3[i] = arr3[j];
                                    }
                                }
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        int sum = 0;
                        Brunch second4_instance = new Brunch();
                        second4_instance.Digit = Convert.ToInt32(Console.ReadLine());
                        int[] arr4 = new int[second4_instance.Digit];
                        position = 0;
                        while (position < second4_instance.Digit)
                        {
                            arr[position] = Convert.ToInt32(Console.ReadLine());
                        }
                        for (int i = 0; i < first_instance.Digit; i++)
                        {
                            for (int j = 0; j < second4_instance.Digit; j++)
                            {
                                if (arr[i] == arr4[j])
                                {
                                    sum++;
                                }
                            }
                        }
                        int[] newarr4 = new int[sum];
                        for (int i = 0; i < first_instance.Digit; i++)
                        {
                            for (int j = 0; j < second4_instance.Digit; j++)
                            {
                                if (arr[i] == arr4[j])
                                {
                                    newarr4[i] = arr[i];
                                }
                            }
                        }
                        break;
                    }
                case 5:
                    Brunch second5_instance = new Brunch();
                    int[] arr5 = new int[second5_instance.Digit];
                    position = 0;
                    while (position < second5_instance.Digit)
                    {
                        arr[position] = Convert.ToInt32(Console.ReadLine());
                    }
                    int differ5 = 0;
                    for (int i = 0; i < first_instance.Digit; i++)
                    {
                        for (int j = 0; j < second5_instance.Digit; j++)
                        {
                            if (arr[i] == arr5[j])
                            {
                                differ5++;
                            }
                        }
                    }
                    int rezult5 = first_instance.Digit - differ5;
                    int[] newarr5 = new int[rezult5];
                    {
                        for (int i = 0; i < first_instance.Digit; i++)
                        {
                            newarr5[i] = arr[i];
                        }
                        for (int i = first_instance.Digit; i < rezult5; i++)
                        {
                            for (int j = 0; j < second5_instance.Digit; j++)
                            {
                                if (arr5[j] != arr[i])
                                {
                                    newarr5[i] = arr5[i];
                                }
                            }
                        }
                    }
                    {
                        break;
                    }
            }
        }
    }
}
