using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02G03
{
    public class ExpressShipment : Shipment
    {
        private decimal extraFee;

        public decimal ExtraFee
        {
            get => extraFee;
            set
            {
                if (value < 0) throw new ArgumentException("Extra fee cannot be negative.");
                extraFee = value;
            }
        }

        public new decimal estimatedCost => DeliveryFee + (Weight * 5) + ExtraFee;

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public new void PrintShipment()
        {
            Console.WriteLine("Express Shipment\n");
            base.PrintShipment();
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {estimatedCost} EGP");
        }
    }
}
