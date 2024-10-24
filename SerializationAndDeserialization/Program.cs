using SerializationAndDeserialization.Models;
using SerializationAndDeserialization.Services;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter your Format: \n 1. JSON 2. XML 3. KVP");
        int format = int.Parse(Console.ReadLine());
        // Create an instance of Employee and initialize its properties
        var Obj = new Employee
        {
            Id = 1,
            FirstName = "Rameshwara",
            LastName = "Yellepeddi",
            Department = "Delivery",
            IsPermanent = true,
            Salary = 10000
        };



        // JSON Serialization
        // Serialize the Employee object to JSON format
        if (format == 1)
        {
            var jsonSerializer = new GenericSerializer<Employee>(new JsonSerializer<Employee>());
            string json = jsonSerializer.Serialize(Obj);
            Console.WriteLine(value: "JSON: " + json);  // Output the serialized JSON string

            // Deserialize the JSON back into an Employee object
            var deserializedJson = jsonSerializer.Deserialize(json);
            Console.WriteLine("Deserialized JSON: " + deserializedJson);  // Output the deserialized employee's first name
        }
        else if (format == 2)
        {
            // XML Serialization
            // Serialize the Employee object to XML format
            var xmlSerializer = new GenericSerializer<Employee>(new XmlSerializer<Employee>());
            string xml = xmlSerializer.Serialize(Obj);
            Console.WriteLine("XML: " + xml);  // Output the serialized XML string

            // Deserialize the XML back into an Employee object
            var deserializedXml = xmlSerializer.Deserialize(xml);
            Console.WriteLine("Deserialized XML: " + deserializedXml);
        }
        else if (format == 3)
        {
            // Custom Key-Value Serialization
            // Serialize the Employee object to a custom key-value pair format
            var kvpSerializer = new GenericSerializer<Employee>(new KeyValuePairSerializer<Employee>());
            string kvp = kvpSerializer.Serialize(Obj);
            Console.WriteLine("Key-Value: " + kvp);  // Output the serialized key-value pair string

            // Deserialize the key-value pair format back into an Employee object
            var deserializedKvp = kvpSerializer.Deserialize(kvp);
            Console.WriteLine("Deserialized Key-Value: " + deserializedKvp);
        }
        else
        {
            Console.WriteLine("Please select the valid Format.");
        }
    }

}
