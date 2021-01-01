using System.Collections.Generic;
using Newtonsoft.Json;
using Structural.Adapter.Model;

namespace Structural.Adapter
{
    class Analytics : IAnalytics
    {
        private List<Manufacturer> _manufacturer;

        public Analytics(string json)
        {
            _manufacturer = JsonConvert.DeserializeObject<List<Manufacturer>>(json);
        }

        public string Report()
        {
            return $"Manufacturers count = {_manufacturer.Count}";
        }
    }
}
