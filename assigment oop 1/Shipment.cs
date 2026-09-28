using System;
using System.Collections.Generic;
using System.Text;

namespace assigment_oop_1
{
    internal struct Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;

        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return trackingCode; }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }

       public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ((decimal)Weight * 5);
            }
        }
        public Shipment(
       string trackingCode,
       string description,
       double weight,
       decimal deliveryFee,
       DeliveryAddress destination)
        {
            this.trackingCode = trackingCode;

            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;

            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;

            Destination = destination;
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public void PrintShipment()
        {
            Console.WriteLine("Tracking Code: " + TrackingCode);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Delivery Fee: " + DeliveryFee);
            
            Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
        }
    }


}

