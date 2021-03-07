using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace C_1_base
{
    public static class YourTasksHere
    {


        #region Задача 1
        /*
         * На вход подаются два катета прямоугольного тругольника требуется найти площадь этого тругольника
        */

        public static double SquerOfTrungle(uint a, uint b)
        {
            double square = (a * b) / 2.0;
            return square;
        }
        #endregion


        #region Задача 2
        /*
         * На вход подаются длины трех отрезков, верните true, если они могут образовать тругольник, в обратном случае верните false
         * 
         * Условие существования треугольника - a меньше или равно b + c, должно выполняться для любой a 
        */

        public static bool isTrungle(uint a, uint b, uint c)
        {
            bool trungle = false;
            if (a <= b + c && b <= a + c && c <= b + a) trungle = true;
            return trungle;
        }
        #endregion


        #region Задача 3
        /*
         * На вход подается два числа, если числа имеют одинаковые знаки, необходимо вывести сумму, иначе разность, взятую по модулю
        */

        public static int Arifmetika(int a, int b)
        {
            int sum = a + b, sub = Math.Abs(a - b);
            if ((a > 0 && b > 0) || (a < 0 && b < 0)) return sum;
            return sub;
        }
        #endregion


        #region Задача 4
        /*
         * На вход подается число, необходимо найти и вернуть факториал этого числа (гарантируется, что входное число больше или равно 1)
        */

        public static int Fuc(int a)
        {
            if (a == 0)
                return 1;
            return a * Fuc(a - 1);
        }
        #endregion


        #region Задача 5
        /*
         * На вход подается число n, необходимо создать массив длинной n и проинициализрSовать его значениями n, n-1 ... 1 (гарантируется, что n >= 1)
        */

        public static int[] ArrayCreate(int n)
        {
            int[] Array = new int[n];
            for (int i = 0; i < n; i++)
                Array[i] = n - i;
            return Array;
        }
        #endregion


        #region Задача 6
        /*
         * На вход подается массив чисел, необходимо вернуть индекс первого вхождения наибольшего элемента массива
        */


        public static int MaxSearch(int[] array)
        {
            int Max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > Max)
                    Max = i;
            }
            return Max;
        }
        #endregion


        #region Задача 7
        /*
         * На вход подается массив чисел, необходимо вернуть его полную копию
        */

        public static int[] ArrayCopy(int[] array)
        {
            int[] array2 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                array2[i] = array[i];
            return array2;
        }
        #endregion


        #region Задача 8
        /*
         * Реализуйте рекурсивную функцию нахождения чисел Фибоначи (a(n) = a(n-1) + a(n-2), где a(1) - 1, a(2) - 2)
        */

        public static int Fibonachi(int n)
        {
            if (n == 1 || n == 0) 
                return 1;
            else 
                return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        #endregion


        #region Задача 9
        /*SS
         * На вход подается массив, необходимо найти наибольшее значение в нем (рекомендуется использовать функцию из задания 6),
         * а так же вернуть полную копию входного массива с помощью модификатора out (рекомендуется использовать функцию из задания 7)
        */

        public static int HardArray(int[] intput, out int[] output)
        {
            int Max = intput[0];
            int[] intput2 = new int[intput.Length];
            output = intput2;
            for (int i = 0; i < intput.Length; i++)
                {
                    if (intput[i] > Max)
                        Max = intput[i];
                }
            for (int j = 0; j < intput.Length; j++)
                output[j] = intput[j];
            return Max;
        }
        #endregion


        #region Задача 10
        /*
         * Вы создаете боевую систему для компьютерной игры
         * Вам необходимо написать метод, который расчитывает результаты боя
         * На каждом ходу игроки наносят урон противнику равный их силе
         * Бой заканчивается, когда у одного из игроков (или у обоих) здоровье опуститься до 0 или ниже
        */

        public static void Fight(ref int health1, int power1, ref int health2, int power2)
        {
            while(true)
            {
                if (health1 < 1 || health2 < 1)
                    break;
                health1 = health1 - power2;
                health2 = health2 - power1;
            }
        }
        #endregion
    }
}
