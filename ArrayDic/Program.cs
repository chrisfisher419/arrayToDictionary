using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarr = new int[]{1, 1, 1, 3, 3, 5, 5, 6, 6, 5, 1, 55,22, 77, 89, 77, 89, 101, -5};
            arrDic(myarr);

        }

        static void arrDic(int[] arr)
        {
            Dictionary<int, int> mydic = new Dictionary<int, int>();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                
            {
                if (!mydic.ContainsKey(arr[i])) { 
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }

                        if (j == arr.Length - 1)
                        {
                           
                            mydic.Add(arr[i], count);
                            count = 0;
                        }
                        
                    }
                    
                }
            }
           mydic = mydic.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<int, int> kvp in mydic)
            {
                Console.WriteLine(kvp);
                
            }

            var keyOfMaxValue = mydic.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            var maxValue = mydic.Values.Max();
            Console.WriteLine($"Key: {keyOfMaxValue} has the greatest occurences with {maxValue} occurences");
            Console.ReadLine();


        }


    }
}
