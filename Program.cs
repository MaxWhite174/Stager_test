﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stager_test
{
    class MainClass
    {
        public static int Min_num(int[] args)
        {
            int tmp;
            int num1 = 0;
            for (int i = 1; i < args.Length; i++)
            {
                tmp = i;
                if (args[tmp] < args[num1]) num1 = tmp;
            }
            int num2 = 0;
            for (int j = 1; j < args.Length; j++)
            {
                tmp = j;
                if ((args[tmp] < args[num2]) && (args[tmp] != args[num1])) num2 = tmp;
            }
            //Console.WriteLine("i = "+num1+" Num1 = "+args[num1]);
            //Console.WriteLine("j = "+num2+" Num2 = "+args[num2]);
            return args[num1]+args[num2];
        }

        public static void Main(string[] args)
        {
            const int a_size = 25;
            Random rand = new Random();
            int[] Int_Array = new int[a_size];
            for(int iter = 0; iter < a_size; iter++)
            {
                Int_Array[iter] = rand.Next(-100, 100);
            }
            //int[] Int_Array = { 0, 100,50,60,-50,85,74,98,-3,8,97,45,-30,65,-55,321,5,48,5,4,3,314,84,8,0 };
            for (int i = 0; i < a_size; i++)
                Console.Write(Int_Array[i]+" ");
            Console.WriteLine();
            int result = MainClass.Min_num(Int_Array);
            Console.WriteLine("result = "+result);
        }
    }
}
