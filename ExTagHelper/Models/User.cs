using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExTagHelper.Models
{
    public class User
    {
        [DisplayName("نام")]
        public string Name { get; set; }

        [DisplayName("نام خانوادگی")]
        public string LastName { get; set; }

        [DisplayName("ایمیل")]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("رمز عبور")]
        public string Password { get; set; }

        [Range(18,30)]
        [DisplayName("سن")]
        public string Age { get; set; }
    }
}
