namespace assigment_oop_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer customer2 = customer;
            customer.name = "ahmed";


            // هنا هيطبع عادي لانه هو كدا مشاور علي نسخه واحده مفش مشاكل 
            Console.WriteLine(customer.name);
            customer2.name = "ali";
            
            Console.WriteLine(customer2.name);
            Console.WriteLine(customer.name);

        }
    }
}
