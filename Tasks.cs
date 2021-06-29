using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB280621
{
    class Task
    {
        public bool GetSimple(int number)
        {
            bool simple = false;
            int denom = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    denom++;
                    if (denom == 2)
                    {
                        simple = true;
                    }
                    else
                    {
                        simple = false;
                    }
                }
            }
            return simple;
        }

        public int[] GetTripleArr(int[] arr) => Array.ConvertAll(arr, x => x * 3);
        public int[] GetAntiArr(int[] arr) => Array.ConvertAll(arr, x => x * -1);
        public string GetStringArr(int[] arr) => string.Join(' ',Array.ConvertAll(arr, x => x.ToString()));

        public string GetString(string str)
        {
            char[] ch = str.ToCharArray();
            if (str.Length % 3 == 0 && str.Length>3)
            {
                ch = str.ToCharArray(str.Length / 3, (str.Length / 2) - 1);
            }
            else
            {
                ch = str.ToCharArray(str.Length / 3, str.Length / 2);
            }
            string st = String.Concat(ch);
            return st;
        }
    }
}
