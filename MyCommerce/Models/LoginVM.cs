using System.ComponentModel.DataAnnotations;

namespace MyCommerce.Models
{
    public class LoginVM
    {
        [MaxLength(20)]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
