﻿using System.Reflection.Emit;

namespace Task_4___16._05._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. İstənilən iki ədəd arasındakı tək ədədlərin sayın tapın
            2. Verilmiş "Code Academy" sözündə hər hərfdən neçə dənə olduğunu tapın*/

            #region Task 1
            //Console.Write("1-ci ededi yazin: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2-ci ededi yazin: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //int counter = 0;
            //int bigNum = 0;
            //int littleNum = 0;
            //if (num1 > num2) { 
            //    bigNum = num1;
            //    littleNum = num2;
            //}
            //else
            //{
            //    bigNum = num2;
            //    littleNum = num1;
            //}


            //for (int i = littleNum + 1; i < bigNum; i++)
            //{
            //    if(i % 2 == 1)
            //        counter++;
            //}
            //Console.WriteLine($"Aralarindaki tek ededlerin sayi: {counter}");
            #endregion

            #region Task 2
            //string word = "Code Academy";
            //string lowerWord = word.ToLower();
            //int counter = 1;
            //bool flag = false;
            //for (int i = 0; i < lowerWord.Length; i++)
            //{
            //    if (lowerWord[i] == ' ')
            //        continue;
            //    else
            //    {
            //        for (int j = 0; j < lowerWord.Length; j++)
            //        {

            //            if (lowerWord[i] == lowerWord[j])
            //            {
            //                counter++;
            //                flag = true;
            //            }
            //        }

            //        Console.WriteLine(word[i] + "  =  " + counter);
            //        counter = 0;
            //    }

            //}
            #endregion


            #region Özüm üçün araşdırdım...
            //string word = "Code Academy";
            //int counter;

            //for (char ch = (char)65; ch <= 90; ch++)
            //{
            //    counter = 0;
            //    for (int i = 0; i < word.Length; i++)
            //    {
            //        if (ch == word[i] || (ch + 32) == word[i])
            //            counter++;
            //    }
            //    if (counter > 0)
            //        Console.WriteLine(ch + "=" + counter);
            //}
            #endregion




            Console.ReadKey();
        }
    }
}