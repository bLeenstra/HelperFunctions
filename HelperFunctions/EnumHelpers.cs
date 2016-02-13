using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperFunctions
{
    public class EnumHelpers
    {
        public static string EnumName<T>(T value) {
            return Enum.GetName(typeof(T), value);
        }
    }
}
