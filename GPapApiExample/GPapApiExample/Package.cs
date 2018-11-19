using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPapApiExample
{
    public class Package
    {
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string MethodPayment { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Barrio { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string AddressDelivery { get; set; }
        public string AddressDelivery2 { get; set; }
        public string Product { get; set; }
        public int Cantidad { get; set; }
        public double Quantity { get; set; }
        public string Transport { get; set; }
        public double LittlePackages { get; set; }
        public double MediumPackages { get; set; }
        public double BigPackages { get; set; }
        public string Comments { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string LongitudeDelivery { get; set; }
        public string LatitudeDelivery { get; set; }
        public string FechaRuta { get; set; }
        public bool PaidOrigin { get; set; }
        public string Bill { get; set; }
        public bool ToGAM { get; set; }
        public string PhoneDelivery { get; set; }
        public string PhoneDelivery2 { get; set; }
        public string ProvinciaDelivery { get; set; }
        public string CantonDelivery { get; set; }
        public string DistritoDelivery { get; set; }
    }
}
