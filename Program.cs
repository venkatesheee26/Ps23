using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_22
{

    class Program
    {
        static void Main()
        {
            // Create instances of Source and Destination classes
            Source source = new Source
            {
                Id = 1,
                Name = "John Doe",
                Age = 30,
                Address = "123 Main St"
            };

            Destination destination = new Destination
            {
                Id = 0, // This value will be updated through dynamic property mapping
                Name = "Default", // This value will be updated through dynamic property mapping
                Age = 0, // This value will be updated through dynamic property mapping
                City = "New York",
                PhoneNumber = "22555-1234"
            };

            // Call the MapProperties method to map properties from Source to Destination
            Mapper.MapProperties(source, destination);

            // Display the values of the properties in the Destination class
            Console.WriteLine("Destination Properties after Mapping:");
            Console.WriteLine($"Id: {destination.Id}");
            Console.WriteLine($"Name: {destination.Name}");
            Console.WriteLine($"Age: {destination.Age}");
            Console.WriteLine($"City: {destination.City}");
            Console.WriteLine($"PhoneNumber: {destination.PhoneNumber}");
        }
    }

}
