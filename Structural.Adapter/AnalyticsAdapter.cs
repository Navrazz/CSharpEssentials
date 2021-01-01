using System.Linq;
using System.Xml.Linq;
using Newtonsoft.Json;
using Structural.Adapter.Model;

namespace Structural.Adapter
{
    public class AnalyticsAdapter : IAnalytics
    {
        private XDocument _xmlDocument;

        public AnalyticsAdapter(XDocument xmlDocument)
        {
            _xmlDocument = xmlDocument;
        }
        public string Report()
        {
            string json = ConvertXmlToJson();

            var analytics = new Analytics(json);

            return analytics.Report();
        }

        private string ConvertXmlToJson()
        {
            var manufacturers = _xmlDocument
                                .Element("Manufacturers")
                                .Elements("Manufacturer")
                                .Select(m => new Manufacturer
                                {
                                    Name = m.Attribute("Name").Value,
                                    Address = m.Attribute("Address").Value,
                                });

            var json = JsonConvert.SerializeObject(manufacturers, Formatting.Indented);
            return json;
        }
    }
}
