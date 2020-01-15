using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSE.Models
{
    public class House
    {
        
        public int Id { get; set; }


        [Display(Name = "آدرس")]
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "The Title length should be between 2 and 20.", MinimumLength = 2)]

        public string Adress { get; set; }
        public int NumOfRooms { get; set; }

        [Display(Name ="مساحت به همراه 15 متر بالکن ")]
        public int Area { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
