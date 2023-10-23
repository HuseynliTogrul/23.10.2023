
using System;

namespace Shoop.Service.Extention
{
    public static class StringExtention
    {
        public static string Str(this string data)
        {
            while (string.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Wrong value! Please add value");
                data = Console.ReadLine();
            }
            return data;
        }
    }
}
