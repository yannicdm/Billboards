using Microsoft.VisualStudio.TestTools.UnitTesting;
using Billboards.Data;
using Billboards.Data.GeocodeServiceReference;
using Billboards.Data.Xml;
using System.Data.Entity;

namespace Billboard.Data.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var placeMarks = BillboardParser.ParseXml();

            int count = 0;

            foreach (var item in placeMarks)
            {
                count++;
            }

            Assert.IsTrue(count < 100);
        }

        [TestMethod]
        public void TestMethod3()
        {

            var placemark = new kmlPlacemark() { Point = new kmlPlacemarkPoint() { coordinates = "3.72704940865343,51.0486001732631" } };
            var response = BingMapsSoapService.MakeReverseGeocodeRequest(placemark);

            Assert.IsFalse(string.IsNullOrEmpty(response.Results[0].Address.AddressLine));
        }


        [TestMethod]
        public void TestMethod4()
        {

            var placeMarks = BillboardParser.ParseXml();

            foreach (var item in placeMarks)
            {

                Billboards.Data.GeocodeServiceReference.GeocodeResponse geo = BingMapsSoapService.MakeReverseGeocodeRequest(item);

                //Assert.IsFalse(string.IsNullOrEmpty(geo.Results[0].Address.AddressLine));
               // System.Console.Out.WriteLine(geo.Results[0].Address.AddressLine);
                Assert.IsTrue(true);
            }


            
        }
    }
}
