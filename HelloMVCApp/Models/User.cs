using System.ComponentModel.DataAnnotations;

namespace HelloMVCApp.Models
{
    public class User
    {
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(20)]
        public string Name { get; set; }

        public User()
        {
            Name = "Username";
        }
    }
}
