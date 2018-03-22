using System;
using System.Linq;

namespace MDC.Domain.Tools
{
    public class GuidSqlite
    {
        private static Random random = new Random();
        public static string getGuid(int length=10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}