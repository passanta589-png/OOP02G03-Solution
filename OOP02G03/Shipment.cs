using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02G03
{
    public class Shipment
    {
        private string _trackingcode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryFee;

        public string TrackingCode
        {
            get { return _trackingcode; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                { _trackingcode = value; }
            }
        }
        public string Description

        {
            get { return _description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                { _description = value; }
            }

        }
        public decimal Weight
        {
            get { return _weight; }
            set

            {
                if (value > 0)
                { _weight = value; }
            }
        }
        public decimal DeliveryFee
        {
            get { return _deliveryFee; }

            private set
            {
                if (value >= 0)
                { _deliveryFee = value; }
            }

        }
        public DeliveryAddress destination { get; set; }

        public decimal estimatedCost
        {
            get
            {
                return _weight * 5 + _deliveryFee;
            }
        }
        public Shipment(string trackingcode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            _trackingcode = string.IsNullOrWhiteSpace(trackingcode) ? "N/A" : trackingcode;
            _description = string.IsNullOrWhiteSpace(description) ? "N/A" : description;
            _weight = weight > 0 ? weight : 1;
            _deliveryFee = deliveryFee >= 0 ? deliveryFee : 50;
            this.destination = destination;
        }
        public void updateDeliveryFee(decimal newFee)
        {
            if (newFee >= 0)
            {
                _deliveryFee = newFee;
            }

        }
        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight} kg");
            Console.WriteLine($"Delivery Fee   : {DeliveryFee} EGP");
            Console.WriteLine($"Destination    : {destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost : {estimatedCost} EGP");
        }

    }
}

