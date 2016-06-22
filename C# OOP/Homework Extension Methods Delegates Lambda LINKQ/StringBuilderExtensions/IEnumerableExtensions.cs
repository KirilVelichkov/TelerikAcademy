using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtensions
{
    public static class IEnumerableExtensions
    {
        public static object MySum<T>(this IEnumerable<T> input)
        {
            object output = null;
            string isNum = "";
            double n = 0;
            string type = input.GetType().ToString();
            if (type == "System.String[]")
            {
                foreach (var item in input)
                {
                    output += item.ToString();
                }
            }
            else
            {
                foreach (var item in input)
                {
                    isNum = item.ToString();
                    n += double.Parse(isNum);
                }
            }

            if (output == null)
            {
                return n;
            }
            else
            {
                return output;
            }
        }

        public static object MyProduct<T>(this IEnumerable<T> input)
        {
            object output = null;
            string isNum = "";
            double n = 1;
            string type = input.GetType().ToString();
            if (type == "System.String[]")
            {
                output = "Strings can't be multiplied";
            }
            else
            {
                foreach (var item in input)
                {
                    isNum = item.ToString();
                    n *= double.Parse(isNum);
                }
            }

            if (output == null)
            {
                return n;
            }
            else
            {
                return output;
            }
        }

        public static object MyAverage<T>(this IEnumerable<T> input)
        {
            object output = null;
            string isNum = "";
            double n = 0;
            double result = 0;
            string type = input.GetType().ToString();
            if (type == "System.String[]")
            {
                output = "Strings can't be divided";
            }
            else
            {
                foreach (var item in input)
                {
                    isNum = item.ToString();
                    n += double.Parse(isNum);
                }
            }
            if (output == null)
            {
                result = n / input.Count();

                return result;
            }
            else
            {
                return output;
            }
        }

        public static object MyMin<T>(this IEnumerable<T> input)
        {
            object output = null;
            return output = input.Min();
        }

        public static object MyMax<T>(this IEnumerable<T> input)
        {
            object output = null;
            return output = input.Max();
        }
    }
}
