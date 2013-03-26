using System.IO;
using System.Xml.Serialization;
using Billboards.Data.Xml;
using System.Reflection;


namespace Billboards.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class BillboardParser
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static kmlPlacemark[] ParseXml()
        {
        var serializer = new XmlSerializer(typeof(kml));

        string codeBase = Assembly.GetExecutingAssembly().CodeBase;
        System.UriBuilder uri = new System.UriBuilder(codeBase);
        string uriPath = System.Uri.UnescapeDataString(uri.Path);
        string path = Path.Combine(Path.GetDirectoryName(uriPath),"Xml/aanplakborden.xml");

        var reader = new StreamReader(path);
        var _kml = (kml)serializer.Deserialize(reader);

        return _kml.Document;
        }
    }
}
