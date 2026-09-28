
namespace assigment_oop_1
{
    internal struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;
        // Constructor 
        public DeliveryAddress(string city,string street ,int buildingnumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingnumber;

        }
        // Encapsulatoin
        public void GetFullAddress()
        {
            Console.WriteLine($"{City},{Street},{BuildingNumber}");
        }



    }
}