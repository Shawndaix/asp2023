using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CstDemo1.Models
{
    public class UserInfo
    {
        public int UserID { get; set; }

        [StringLength(20,ErrorMessage ="Length < 20")]
        [Required(ErrorMessage="* required.")]

        public string UserName { get; set; }
        [Range(8,10)]
        [Required(ErrorMessage= "* required.")]
        public string UserEmail { get; set; }


        public string UserMobile { get; set; }

    }
}