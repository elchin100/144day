using System;

namespace Chararrayresult
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "audi", "bmw", "chevy", "ford" };
            char bentley = 'b';
            foreach (string item in Chararrayrusult(arr, bentley))
            {
                Console.WriteLine(item);
            }
        }
        static string[] Chararrayrusult(string[] arr, char a)
        {
            string[] result = new string[0];

            foreach (string item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == a)
                    {

                        Array.Resize(ref result, result.Length + 1);

                        result[result.Length - 1] = item;
                        
                    }

                }
            }

            return result;
        }

    }
}