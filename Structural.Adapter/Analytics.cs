using System.Collections.Generic;
using System.Text.Json;
using Structural.Adapter.Model;

namespace Structural.Adapter
{
    class Analytics : IAnalytics
    {
        private List<Manufacturer> _manufacturer;

        public Analytics(string json)
        {
            _manufacturer = JsonSerializer.Deserialize<List<Manufacturer>>(json);
        }

        public string Report()
        {
            return $"Manufacturers count = {_manufacturer.Count}";
        }
    }
}
