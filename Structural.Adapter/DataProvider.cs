using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Xml.Linq;
using Structural.Adapter.Model;

namespace Structural.Adapter
{
    public static class DataProvider
    {
        private static List<Manufacturer> _manufacturers = new List<Manufacturer>
        {
            new Manufacturer { Name = "1", Address = "Wrocław"},
            new Manufacturer { Name = "2", Address = "Warszawa"},
        };

        public static XDocument GetXml()
        {
            var document = new XDocument();
            var element = new XElement("Manufacturers");
            var attributes = _manufacturers.Select(m => new XElement("Manufacturer",
                                                            new XAttribute("Name", m.Name),
                                                            new XAttribute("Address", m.Address)
                ));

            element.Add(attributes);
            document.Add(element);

            return document;
        }

        public static string GetJson()
        {
            var json = JsonSerializer.Serialize(_manufacturers);

            return json;
        }
    }
}
