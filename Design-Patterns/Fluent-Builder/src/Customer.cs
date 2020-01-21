using System;
using System.Collections.Generic;
using System.Text;

namespace Fluent_Builder.src
{
    public class Customer
    {
        public int CustomerNumber { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Customer(int customerNumber, string firstName, string lastName, int age)
        {
            CustomerNumber = customerNumber;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return string.Format("Customer: {0}. {1} {2}, Age: {3}", CustomerNumber, FirstName, LastName, Age);
        }
    }
}
