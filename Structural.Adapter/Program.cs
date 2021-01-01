using System;

namespace Structural.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

            var jsonDocument = DataProvider.GetJson();
            var analytics = new Analytics(jsonDocument);

            Console.WriteLine("Report from json");
            Console.WriteLine(analytics.Report());

            var xmlDocument = DataProvider.GetXml();
            // var analytics = new Analytics(xmlDocument); - Analytics works only with Json - we need adapter
            var analyticsAdapter = new AnalyticsAdapter(xmlDocument);

            Console.WriteLine("Report from xml");
            Console.WriteLine(analyticsAdapter.Report());
        }
    }
}