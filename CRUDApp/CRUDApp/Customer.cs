using System.ComponentModel.DataAnnotations;

namespace CRUDApp
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(45)]
        public string Name { get; set; }
    }
}