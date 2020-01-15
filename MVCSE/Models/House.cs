using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSE.Models
{
    public class House
    {
        [Display(Name = "شناسه")]
        [Required]
        [Range(0,int.MaxValue,ErrorMessage ="Enter valid id")]
        public int Id { get; set; }


        [Display(Name = "آدرس")]
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "The Title length should be between 2 and 20.", MinimumLength = 2)]

        public string Adress { get; set; }


        [Display(Name = "تعداد اتاق ها")]
        [Range(0, 20, ErrorMessage = "Enter valid Number")]
        public int NumOfRooms { get; set; }

        [Display(Name ="متراژ")]
        [Range(0, 2000, ErrorMessage = "Enter valid Number")]
        public int Area { get; set; }

        [Display(Name = "شناسه مالک")]
        [Required]
        public int OwnerId { get; set; }

        [Display(Name = " مالک")]
        public Owner Owner { get; set; }
    }
}
