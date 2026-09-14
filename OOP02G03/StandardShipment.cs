using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02G03
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddres destination)
            : base(trackingCode, description, weight, deliveryFee, destination) { }

        public new void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            base.PrintShipment();
            Console.WriteLine($"Estimated Cost: {estimatedCost} EGP");
        }

    }
}
