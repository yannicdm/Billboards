using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Billboards.Data.Xml
{
    public partial class kmlPlacemarkPoint
    {
        char[] mask = new char[] { ',' };

        /// <summary>
        /// 
        /// </summary>
        public double Longitude
        {
            get
            {
                double lat;
                string[] coord = this.coordinates.Split(mask, 2);
                if (double.TryParse(coord[0], out lat))
                    return double.Parse(coord[0],CultureInfo.InvariantCulture);
                throw new System.FormatException("Could not parse lattitude value from PlacemarkPoint");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Lattitude
        {
            get
            {
                double lon;
                string[] coord = this.coordinates.Split(mask, 2);
                if (double.TryParse(coord[1], out lon))
                    return double.Parse(coord[1], CultureInfo.InvariantCulture);
                throw new System.FormatException("Could not parse longitude value from PlacemarkPoint");
            }
        }
    }
}
