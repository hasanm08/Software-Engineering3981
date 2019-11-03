using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSE.Models
{
    public class House
    {
        [Display(Name ="آدرس")]
        public int Id { get; set; }
        public string Adress { get; set; }
        public int NumOfRooms { get; set; }
        public int Area { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
