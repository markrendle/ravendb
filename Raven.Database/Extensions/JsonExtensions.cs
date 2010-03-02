using System.Text;
using Newtonsoft.Json.Linq;

namespace Raven.Database.Extensions
{
    public static class JsonExtensions
    {
        public static JObject ToJson(this byte[] self)
        {
            return JObject.Parse(Encoding.UTF8.GetString(self));
        }
    }
}