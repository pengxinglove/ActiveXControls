using System;

namespace ActiveXControl
{
    /// <summary>
    /// Guid帮助类
    /// </summary>
    public class GuidHelper
    {
        static GuidHelper() { }

        public static string CreateGuid()
        {
            return Guid.NewGuid().ToString();
        }

    }
}
