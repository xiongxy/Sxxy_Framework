
using Newtonsoft.Json;

namespace Sxxy_Framework.Common.ConvertHelper
{
  public  class ByteConvertHelper
    {
        /// <summary>
        /// 将对象转换为byte数组
        /// </summary>
        /// <param name="obj">被转换对象</param>
        /// <returns>转换后byte数组</returns>
        public static byte[] ObjectToBytes(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(json);
            return bytes;
        }

        /// <summary>
        /// 将byte数组转换成对象
        /// </summary>
        /// <param name="bytes">被转换byte数组</param>
        /// <returns>转换完成后的对象</returns>
        public static object BytesToObject(byte[] bytes)
        {
            string json = System.Text.Encoding.UTF8.GetString(bytes);
            return JsonConvert.DeserializeObject<object>(json);
        }

        /// <summary>
        /// 将byte数组转换成对象
        /// </summary>
        /// <param name="bytes">被转换byte数组</param>
        /// <returns>转换完成后的对象</returns>
        public static T BytesToObject<T>(byte[] bytes)
        {
            string json = System.Text.Encoding.UTF8.GetString(bytes);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
