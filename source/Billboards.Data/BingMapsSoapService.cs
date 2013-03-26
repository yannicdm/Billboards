using Billboards.Data.Xml;
using System.Collections.Generic;
using Billboards.Model;
using AutoMapper;

namespace Billboards.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class BingMapsSoapService
    {
        static string key = "AvAGQyYnXGtblMQrHmTGgy5MwERh79ZSLNPuR7LpLVHhfzD0U5UJdcmP67HuMWZz";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="placemark"></param>
        /// <returns></returns>
        public static GeocodeServiceReference.GeocodeResponse MakeReverseGeocodeRequest(kmlPlacemark placemark)
        {
            var reverseGeocodeRequest = new GeocodeServiceReference.ReverseGeocodeRequest();

            // Set the credentials using a valid Bing Maps key
            reverseGeocodeRequest.Credentials = new GeocodeServiceReference.Credentials();
            reverseGeocodeRequest.Credentials.ApplicationId = key;

            // Set the point to use to find a matching address
            var point = new GeocodeServiceReference.Location();

            point.Latitude = placemark.Point.Lattitude;
            point.Longitude = placemark.Point.Longitude;

            reverseGeocodeRequest.Location = point;

            // Make the reverse geocode request
            var geocodeService = new GeocodeServiceReference.GeocodeServiceClient("BasicHttpBinding_IGeocodeService");
            var geocodeResponse = geocodeService.ReverseGeocode(reverseGeocodeRequest);

            return geocodeResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="billboard"></param>
        /// <returns></returns>
        public static GeocodeServiceReference.GeocodeResponse MakeReverseGeocodeRequest(Billboard billboard)
        {
            var reverseGeocodeRequest = new GeocodeServiceReference.ReverseGeocodeRequest();

            // Set the credentials using a valid Bing Maps key
            reverseGeocodeRequest.Credentials = new GeocodeServiceReference.Credentials();
            reverseGeocodeRequest.Credentials.ApplicationId = key;

            // Set the point to use to find a matching address
            var point = new GeocodeServiceReference.Location();

            point.Latitude = billboard.Lattitude;
            point.Longitude = billboard.Longitude;

            reverseGeocodeRequest.Location = point;

            // Make the reverse geocode request
            var geocodeService = new GeocodeServiceReference.GeocodeServiceClient("BasicHttpBinding_IGeocodeService");
            var geocodeResponse = geocodeService.ReverseGeocode(reverseGeocodeRequest);

            return geocodeResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="placemarks"></param>
        /// <returns></returns>
        public static IList<GeocodeServiceReference.GeocodeResponse> MakeReverseGeocodeRequest(kmlPlacemark[] placemarks)
        {
            var result = new List<GeocodeServiceReference.GeocodeResponse>();
            foreach (var placemark in placemarks)
            {
                result.Add(MakeReverseGeocodeRequest(placemark));
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="billboards"></param>
        /// <returns></returns>
        public static IList<GeocodeServiceReference.GeocodeResponse> MakeReverseGeocodeRequest(IList<Billboard> billboards)
        {
            var result = new List<GeocodeServiceReference.GeocodeResponse>();
            foreach (var billboard in billboards)
            {
               result.Add(MakeReverseGeocodeRequest(billboard));
            }
            return result;
        }
    }
}
