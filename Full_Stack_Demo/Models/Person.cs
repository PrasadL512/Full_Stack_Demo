using System.ComponentModel.DataAnnotations;

namespace Full_Stack_Demo.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
