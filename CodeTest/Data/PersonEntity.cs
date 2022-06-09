using System.ComponentModel.DataAnnotations;

namespace CodeTest.Data
{
    public class PersonEntity
    {
        [Key]
        public int Id { get; set; }

        public string? ForeName { get; set; }

        public string? Surname { get; set; }
    }
}
