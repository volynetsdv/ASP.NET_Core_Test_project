using System.Collections.Generic;

namespace manufacturer_api_dotnet.Models
{
    public class RootObject<T>
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public object SearchCriteria { get; set; }
        public List<T> Results { get; set; }
    }
}