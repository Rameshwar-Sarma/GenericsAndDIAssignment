using SerializationAndDeserialization.Attributes;

namespace SerializationAndDeserialization.Models
{
    /// <summary>
    /// Represents an employee entity with relevant details.
    /// </summary>
    [SerializableEntity]
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public bool IsPermanent { get; set; }
        public float Salary { get; set; }

    }
}
