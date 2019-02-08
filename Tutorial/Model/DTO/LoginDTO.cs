using System.ComponentModel.DataAnnotations;

namespace Tutorial.Model.DTO
{
    public class LoginDTO
    {
        [Required,Display(Name ="用户名")]
        public string UserName { get; set; }
        [Required, Display(Name = "密码"),DataType(DataType.Password)]
        public string  Password { get; set; }
    }
}
