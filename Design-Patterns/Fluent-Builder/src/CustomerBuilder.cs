using System;
using System.Collections.Generic;
using System.Text;

namespace Fluent_Builder.src
{
    public class CustomerBuilder
    {
        public int CustomerNumber { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public CustomerBuilder AssignCustomerNumber(int customerNumber)
        {
            CustomerNumber = customerNumber;
            return this;
        }

        public CustomerBuilder AssignFirstName(string firstName)
        {
            FirstName = firstName;
            return this;
        }

        public CustomerBuilder AssignLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }

        public CustomerBuilder AssignAge(int age)
        {
            Age = age;
            return this;
        }

        public Customer Build()
        {
            return new Customer(CustomerNumber, FirstName, LastName, Age);
        } 
    }
}
