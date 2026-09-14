using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02G03
{
    internal struct DeliveryAddress
    {
        public string city { get; set; }
        public string street { get; set; }
        public int buildingNumber { get; set; }

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            city = city;
            street = street;
            buildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"{buildingNumber} {street}, {city}";
        }

    }
}
