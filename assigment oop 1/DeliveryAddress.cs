
namespace assigment_oop_1
{
    internal struct DeliveryAddress
    {
        private string  City;
        private string Street;
        // Encapsulatoin
        public string city
        {
            get { return city; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    city = value;
            }
        }
    }


}
