using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //-- Arrange 
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            //-- Act
            LoggingService.WriteToFile(changedItems);

            foreach (var changedItem in changedItems)
            {
                switch (changedItem)
                {
                    case Product p:
                        Console.WriteLine("product " + p.ProductName);
                        break;
                    case Customer c:
                        Console.WriteLine("customer " + c.CustomerId);
                        break;
                }
            }
        }
    }

    public class Foo
    {

    }
}
