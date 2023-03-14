using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Methods
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static string Add(bool x, int y, int z)
        {
            if (x && (z + y != 1))
            {
                return $"{z + y} dollars.";
            }
            else if (x && (y + z != 1))
            {
                return $"{z + y} dollar.";
            }
            else
            {
                return $"{z + y}";

            }
        }
    }
}

        

    
