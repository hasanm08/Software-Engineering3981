using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSE.Models
{
    public class Owner
    {

        [Display(Name = "شناسه")]
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Enter valid id")]
        public int Id { get; set; }


        [Display(Name = "نام  ونام خانوادگی")]
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "The Title length should be between 2 and 20.", MinimumLength = 2)]

        public string Name { get; set; }
       // public int 
    }
}
