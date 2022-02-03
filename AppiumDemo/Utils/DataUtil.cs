using System;

namespace AppiumDemo.Utils
{
    public class DataUtil
    {
        public static string GetSystemCurrentDate()
        {
            DateTime localDate = DateTime.Now;
            return localDate.ToString();
        }
    }
}
