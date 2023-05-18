using System.ComponentModel.DataAnnotations;

namespace ASP_NET_APP.Model
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Required*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required*")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
