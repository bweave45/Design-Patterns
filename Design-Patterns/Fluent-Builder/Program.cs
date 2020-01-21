using Fluent_Builder.src;
using System;

namespace Fluent_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new CustomerBuilder();
            builder.AssignCustomerNumber(321123)
                   .AssignFirstName("Dude")
                   .AssignLastName("McGuy");

            //preform action to get/calculate age from elsewhere
            var age = 22;

            builder.AssignAge(age);

            var customer = builder.Build();

            Console.WriteLine(customer.ToString());
        }
    }
}
