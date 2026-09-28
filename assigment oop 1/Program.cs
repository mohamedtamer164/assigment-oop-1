namespace assigment_oop_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // answer 1
            #region class copy 
            //    Customer customer = new Customer();
            //    Customer customer2 = customer;
            //    customer.name = "ahmed";


            //    // هنا هيطبع عادي لانه هو كدا مشاور علي نسخه واحده مفش مشاكل 
            //    Console.WriteLine(customer.name);
            //    customer2.name = "ali";

            //    Console.WriteLine(customer2.name); // ali
            //    Console.WriteLine(customer.name);// ali
            //                                     // هنا الاتنين هيطبعوا نفس القيمه عشان هما بيلغعوا القينه الاولي و الاتنين ال object بيشاورا عليها 
            #endregion

            #region struct copy
            //    DeliveryAddress address = new DeliveryAddress();
            //    DeliveryAddress address2 = address;
            //    address.city = "cairo";
            //    Console.WriteLine(address.city);// Cairo
            //    address2.city = "Giza";
            //    Console.WriteLine(address.city); // Cairo
            //    Console.WriteLine(address2.city); // Giza
            //    // struct  هنا يعتبر اي حاجه ببتخزن ف ال stack  م هي بتعمل علي نسخه تانيه و النسخه الاصليه بتفضل زي م هي مش بتتعدل عليعال 
            //    // Class لا لو عدلت ف ال حاجه بيتعدل لان هو كدا بيلغي الاول و بيشاور علي نفس الحاجه
            #endregion

            // answer 2

            //DeliveryAddress address = new DeliveryAddress();
            //address.city = "berket elsabe3";
            //// 1  هنا مثلا لو انا مش عاوز حد يغير ال data دي عشان جايه من data base  كدا اي حد يقدر يغيرها 
            //// 2 مفيش Valedatoin  اي مقدرش اعمل كود يحددلي انا عاوز ادخل اي 
            ////بيانات تتقري عادي، لكن مينفعش تتغير إلا بشروط معينة.

            //        DeliveryAddress address = new DeliveryAddress("Cairo",
            //"Tahrir Street",
            //15);
            //        DeliveryAddress address2 = address;
            //        address.GetFullAddress();
            //        address2.City = "Giza";
            //        address2.Street = "elharam";
            //        address2.BuildingNumber = 15;
            //        address.GetFullAddress();
            //        address2.GetFullAddress();


            // Create DeliveryAddress
            DeliveryAddress address = new DeliveryAddress(
                "Cairo",
                "Tahrir Street",
                15
            );

            // Create Shipment
            Shipment shipment = new Shipment(
                "SH-101",
                "Laptop",
                3,
                100,
                address
            );

            // Print shipment information
            shipment.PrintShipment();

            Console.WriteLine();

            // Test UpdateDeliveryFee
            shipment.UpdateDeliveryFee(120);

            Console.WriteLine("After updating delivery fee:");
            shipment.PrintShipment();

            Console.WriteLine();

            // Test invalid weight
            shipment.Weight = -5;

            Console.WriteLine("After invalid weight:");
            Console.WriteLine("Weight: " + shipment.Weight);

            Console.WriteLine();

            // Test invalid description
            shipment.Description = "";

            Console.WriteLine("After invalid description:");
            Console.WriteLine("Description: " + shipment.Description);
        }
    }
}
