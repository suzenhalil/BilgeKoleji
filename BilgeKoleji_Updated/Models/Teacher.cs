using System.ComponentModel.DataAnnotations;

namespace BilgeKoleji_Updated.Models
{
    public class Teacher : User
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }
        public string Adress { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
