using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docker.Common.Base.Extensions
{
    public static class ExceptionExtensions
    {

        public static string GetAllMessages(this Exception ex)
        {
            if (ex == null)
            {
                throw new ArgumentNullException("ex");
            }

            StringBuilder sb = new StringBuilder();

            while (ex != null)
            {
                if (!string.IsNullOrWhiteSpace(ex.Message))
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(" ");
                    }

                    sb.Append(ex.Message);
                }

                ex = ex.InnerException;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Remove double quotes at the begining and ending of the string
        /// Example: "<xml>input</xml>xml>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string RemoveDouleQuotes(this string data)
        {
            data = data.StartsWith("\"") ? data.Remove(0, 1) : data;
            data = data.EndsWith("\"") ? data.Remove(data.Length - 1, 1) : data;

            return data;
        }

    }
}
