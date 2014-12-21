using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo1.Models
{
    public class UserModels
    {
        [Required]
        public string Id { get; set; }
        
        [Display(Name = "EmailAddress")]
        [Required(ErrorMessage = "Missed Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }
        
        [Required]
        [Range(10000, 100000)]
        public Decimal Salary { get; set; }
    }

    public class User
    {
        public User()
        {
            userModels.Add(new UserModels { 
                Id = "1",
                Email = "harsha@soandso.com",
                DOB = DateTime.Today,
                Salary = 10000
            });
            userModels.Add(new UserModels
            {
                Id = "2",
                Email = "harsha1@soandso.com",
                DOB = DateTime.Today,
                Salary = 10000
            });
            userModels.Add(new UserModels
            {
                Id = "3",
                Email = "harsha2@soandso.com",
                DOB = DateTime.Today,
                Salary = 10000
            });
        }

        public IList<UserModels> userModels = new List<UserModels>();

        public void AddUser(UserModels user)
        {
            userModels.Add(user);
        }
    }
}