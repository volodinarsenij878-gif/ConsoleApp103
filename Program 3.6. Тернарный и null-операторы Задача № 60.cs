using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program60
{
    internal class Program
    {
        static void Main()
        {
            int? count = null;
            // 1. count?.GetHashCode() → если count == null, результат null (не будет исключения)
            // 2. ?? -1 → если слева null, берём -1
            int res = count?.GetHashCode() ?? -1;

            Console.WriteLine(res); // Вывод: -1
        }
    }
}
