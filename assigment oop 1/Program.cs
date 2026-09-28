namespace assigment_oop_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // answer 1
            #region class copy 
            Customer customer = new Customer();
            Customer customer2 = customer;
            customer.name = "ahmed";


            // هنا هيطبع عادي لانه هو كدا مشاور علي نسخه واحده مفش مشاكل 
            Console.WriteLine(customer.name);
            customer2.name = "ali";

            Console.WriteLine(customer2.name); // ali
            Console.WriteLine(customer.name);// ali
                                             // هنا الاتنين هيطبعوا نفس القيمه عشان هما بيلغعوا القينه الاولي و الاتنين ال object بيشاورا عليها 
            #endregion

            #region struct copy
            DeliveryAddress address = new DeliveryAddress();
            DeliveryAddress address2 = address;
            address.city = "cairo";
            Console.WriteLine(address.city);// Cairo
            address2.city = "Giza";
            Console.WriteLine(address.city); // Cairo
            Console.WriteLine(address2.city); // Giza
            // struct  هنا يعتبر اي حاجه ببتخزن ف ال stack  م هي بتعمل علي نسخه تانيه و النسخه الاصليه بتفضل زي م هي مش بتتعدل عليعال 
            // Class لا لو عدلت ف ال حاجه بيتعدل لان هو كدا بيلغي الاول و بيشاور علي نفس الحاجه
            #endregion
        }
    }
}
